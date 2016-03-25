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
                    TypeID = alert.TypeID,
                    Title = alert.Title,
                    Comment = alert.Comment
                    /*TODO: Get Alert images(or at least the first) loaded as well*/
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
                    TypeID = alert.TypeID,
                    Title = alert.Title,
                    Comment = alert.Comment
                    /*TODO: Get Alert images(or at least the first) loaded as well*/
                });
            }

            return JsonConvert.SerializeObject(results);
        }
        [WebMethod]
        public string FindGigByAlertID(string request)
        {
            DTO_CORE_Gig result;

            var requestObject = JsonConvert.DeserializeObject<CORE_Gigs>(request);

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            var gig = context.CORE_Gigs.Where(g => g.AlertID == requestObject.AlertID).Single();

            result = new DTO_CORE_Gig{
                GigID = gig.GigID, 
                StudentID = gig.StudentID, 
                AlertID = gig.AlertID,
                DateAccepted = gig.DateAccepted, 
                StudentComments = gig.StudentComments, 
                ClientComments = gig.ClientComments
            };

            if (gig.DateClosed != null)
                result.DateClosed = (DateTime)gig.DateClosed;
            if (gig.StudentRating != null)
                result.StudentRating = (double)gig.StudentRating;
            if (gig.ClientRating != null)
                result.ClientRating = (double)gig.ClientRating;

            return JsonConvert.SerializeObject(result);
        }
        [WebMethod]
        public string FindGigsByStudentID(string request)
        {
            List<DTO_CORE_Gig> resultList = new List<DTO_CORE_Gig>();

            var requestObject = JsonConvert.DeserializeObject<CORE_Gigs>(request);

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            var gigList = context.CORE_Gigs.Where(g => g.StudentID == requestObject.StudentID);

            foreach (CORE_Gigs gig in gigList)
            {
                DTO_CORE_Gig result = new DTO_CORE_Gig
                {
                    GigID = gig.GigID,
                    StudentID = gig.StudentID,
                    AlertID = gig.AlertID,
                    DateAccepted = gig.DateAccepted,
                    StudentComments = gig.StudentComments,
                    ClientComments = gig.ClientComments
                };

                if (gig.DateClosed != null)
                    result.DateClosed = (DateTime)gig.DateClosed;
                if (gig.StudentRating != null)
                    result.StudentRating = (double)gig.StudentRating;
                if (gig.ClientRating != null)
                    result.ClientRating = (double)gig.ClientRating;

                resultList.Add(result);
            }
            return JsonConvert.SerializeObject(resultList);
        }
        [WebMethod]
        public string FindGigsByClientID(string request)
        {
            List<DTO_CORE_Gig> resultList = new List<DTO_CORE_Gig>();

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            var requestObject = JsonConvert.DeserializeObject<CORE_GigAlerts>(request);

            var gigList = context.CORE_Gigs.Where(g => g.CORE_GigAlerts.ClientID == requestObject.ClientID);

            foreach (CORE_Gigs gig in gigList)
            {
                DTO_CORE_Gig result = new DTO_CORE_Gig
                {
                    GigID = gig.GigID,
                    StudentID = gig.StudentID,
                    AlertID = gig.AlertID,
                    DateAccepted = gig.DateAccepted,
                    StudentComments = gig.StudentComments,
                    ClientComments = gig.ClientComments
                };

                if (gig.DateClosed != null)
                    result.DateClosed = (DateTime)gig.DateClosed;
                if (gig.StudentRating != null)
                    result.StudentRating = (double)gig.StudentRating;
                if (gig.ClientRating != null)
                    result.ClientRating = (double)gig.ClientRating;

                resultList.Add(result);
            }
            return JsonConvert.SerializeObject(resultList);
        }

    }
}
