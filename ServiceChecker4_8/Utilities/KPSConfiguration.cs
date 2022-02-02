using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceChecker4_8.Utilities
{
    public class KPSConfiguration
    {
        #region Fields

        public static KPSConfiguration Instance = new KPSConfiguration();

        private string endPoint;
        private string username;
        private string password;

        #endregion

        #region Constructors

        private KPSConfiguration()
        {
            endPoint = "https://kpsv2.nvi.gov.tr/Services/RoutingService.svc";
        }

        #endregion

        #region Properties

        public string EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

    }
}
