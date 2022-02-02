using System;
using System.ServiceModel;
using Microsoft.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens;
using System.ServiceModel.Security;
using Microsoft.IdentityModel.SecurityTokenService;
using ServiceChecker4_8.Utilities;
using WSTrustChannelFactory = Microsoft.IdentityModel.Protocols.WSTrust.WSTrustChannelFactory;
using WSTrustChannel = Microsoft.IdentityModel.Protocols.WSTrust.WSTrustChannel;

namespace Mernis.Kps.Sample.WCF.Utilities
{
    public class KPSServiceFactory
    {
        #region Constructors

        private KPSServiceFactory() { }

        #endregion

        #region Fields

        private static KPSServiceFactory instance;

        private SecurityToken token;

        #endregion

        #region Properties

        public static KPSServiceFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new KPSServiceFactory();

                return instance;
            }
        }

        #endregion

        #region Methods

        public SecurityToken CreateToken(String SorgulayanTC)
        {
            if (token == null || token.ValidTo <= DateTime.Now.ToUniversalTime())
            {
                WSTrustChannelFactory trustChannelFactory = new WSTrustChannelFactory("STSIssuerService");
                trustChannelFactory.TrustVersion = TrustVersion.WSTrust13;
                trustChannelFactory.Credentials.UserName.UserName = KPSConfiguration.Instance.Username;
                trustChannelFactory.Credentials.UserName.Password = KPSConfiguration.Instance.Password;

                trustChannelFactory.Endpoint.Behaviors.Add(new KPSSorgulayanHeaderEndpointBehavior(SorgulayanTC));//Sorgulayan kimlik numarası yada servis kullanıcı adı buraya yazılır

                WSTrustChannel channel = (WSTrustChannel)trustChannelFactory.CreateChannel();
                RequestSecurityToken rst = new RequestSecurityToken(RequestTypes.Issue);
                rst.AppliesTo = new EndpointAddress(KPSConfiguration.Instance.EndPoint);
                RequestSecurityTokenResponse rstr;

                token = channel.Issue(rst, out rstr);
            }

            return token;
        }

        #endregion
    }
}
