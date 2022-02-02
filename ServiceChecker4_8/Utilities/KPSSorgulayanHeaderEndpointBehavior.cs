using System;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;

namespace ServiceChecker4_8.Utilities
{
    public class KPSSorgulayanHeaderEndpointBehavior : IEndpointBehavior
    {
        private string sorgulayan;

        public KPSSorgulayanHeaderEndpointBehavior(string sorgulayan)
        {
            this.sorgulayan = sorgulayan;
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(new KPSSorgulayanHeaderClientMessageInspector(this.sorgulayan));
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            
        }
    }
}
