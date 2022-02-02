using System;
using System.ServiceModel.Configuration;
using System.Configuration;

namespace ServiceChecker4_8.Utilities
{
    public class KPSSorgulayanHeaderBehaviorElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(KPSSorgulayanHeaderEndpointBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new KPSSorgulayanHeaderEndpointBehavior(Sorgulayan);
        }

        [ConfigurationProperty("Sorgulayan", IsRequired=true)]
        public string Sorgulayan
        { 
            get
            {
                return base["Sorgulayan"] as string;
            }
            set
            {
                base["Sorgulayan"] = value;
            }
        }
    }
}
