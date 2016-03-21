using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GigALoan_DAL;
using GigALoan_Model;

using System.Net;
using System.Net.Http;

using Newtonsoft.Json;

namespace GigALoan_Service
{
    /// <summary>
    /// Summary description for Search_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Search_Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string FindLocalAlerts(string request)
        {
            return "Stub Method... " + "You entered " + JsonConvert.DeserializeObject(request);
        }
        public string FindAlertByPay(string request)
        {
            return "Stub Method... " + "You entered " + JsonConvert.DeserializeObject(request);
        }
        public string FindAlertByType(string request)
        {
            return "Stub Method... " + "You entered " + JsonConvert.DeserializeObject(request);
        }
    }
}
