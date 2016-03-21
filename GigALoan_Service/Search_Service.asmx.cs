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
            return "Stub Method... " + "You entered " + request;
        }
        [WebMethod]
        public string FindAlertsByPay(string request)
        {
            var requestObject = JsonConvert.DeserializeObject<DTO_CORE_GigAlert>(request);

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            List<DTO_CORE_GigAlert> results = new List<DTO_CORE_GigAlert>();

            var alertList = context.CORE_GigAlerts.Where(ga => ga.PaymentAmt >= requestObject.PaymentAmt);

            foreach (CORE_GigAlerts alert in alertList)
            {
                results.Add(new DTO_CORE_GigAlert { 
                    AlertID = alert.AlertID,
                    ClientID = alert.ClientID,
                    TypeID = alert.TypeID,
                    Title = alert.Title,
                    Comment = alert.Comment,
                    PaymentAmt = alert.PaymentAmt,
                    DateCreated = alert.DateCreated,
                    Active = alert.Active
                });
            }

            return JsonConvert.SerializeObject(results);
        }
        [WebMethod]
        public string FindAlertsByType(string request)
        {
            var requestObject = JsonConvert.DeserializeObject<DTO_CORE_GigAlert>(request);

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            List<DTO_CORE_GigAlert> results = new List<DTO_CORE_GigAlert>();

            var alertList = context.CORE_GigAlerts.Where(ga => ga.SPRT_GigTypes.TypeID == requestObject.TypeID);

            foreach (CORE_GigAlerts alert in alertList)
            {
                results.Add(new DTO_CORE_GigAlert {
                    AlertID = alert.AlertID,
                    ClientID = alert.ClientID,
                    TypeID = alert.TypeID,
                    Title = alert.Title,
                    Comment = alert.Comment,
                    PaymentAmt = alert.PaymentAmt,
                    DateCreated = alert.DateCreated,
                    Active = alert.Active
                });
            }

            return JsonConvert.SerializeObject(results);
        }
    }
}
