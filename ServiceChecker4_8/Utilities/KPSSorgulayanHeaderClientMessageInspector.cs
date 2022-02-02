using System;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace ServiceChecker4_8.Utilities
{
    public class KPSSorgulayanHeaderClientMessageInspector : IClientMessageInspector
    {
        private string sorgulayan;

        public KPSSorgulayanHeaderClientMessageInspector(string sorgulayan)
        {
            if (String.IsNullOrWhiteSpace(sorgulayan))
            {
                throw new ArgumentNullException(sorgulayan);
            }

            this.sorgulayan = sorgulayan;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            // nothing to do.
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            request.Headers.Add(MessageHeader.CreateHeader("Sorgulayan", "http://kps.nvi.gov.tr/2011/01/01/sorgulayan", sorgulayan));
            return null;
        }
    }
}
