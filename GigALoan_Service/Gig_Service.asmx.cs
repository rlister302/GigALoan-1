using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GigALoan_Model;
using GigALoan_DAL;

using Newtonsoft.Json;
using System.Data.SqlClient;

namespace GigALoan_Service
{
    /// <summary>
    /// Summary description for Gig_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Gig_Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string CreateGig(string gigFromAlert)
        {
            var gig = JsonConvert.DeserializeObject<DTO_CORE_Gig>(gigFromAlert);

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            string insertString = "IF ((SELECT Active FROM CORE_GigAlerts WHERE AlertID = " + gig.AlertID + ") = 1) " +
                "INSERT INTO CORE_Gigs(AlertID, DateAccepted, StudentID, ClientComments, StudentRating, ClientRating) VALUES(" +
                gig.AlertID + ", " + gig.DateAccepted.ToString("yyyy-mm-dd") + ", " + gig.StudentID + ", '" + gig.ClientComments + "', 0, 0) " +
                "UPDATE CORE_GigAlerts SET Active = 0 FROM CORE_GigAlerts WHERE AlertID = " + gig.AlertID;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=tcp:s05.winhost.com;Database=DB_42039_gig;User ID=DB_42039_gig_user;Password=gigaloan";

            SqlCommand cmd = new SqlCommand(insertString, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            var result = context.CORE_Gigs.Where(g => g.AlertID == gig.AlertID).Single();

            DTO_CORE_Gig gigToBeReturned = new DTO_CORE_Gig
            {
                AlertID = result.AlertID,
                ClientComments = result.ClientComments,
                ClientRating = 0.0,
                DateAccepted = result.DateAccepted,
                DateClosed = Convert.ToDateTime(null),
                GigID = result.GigID,
                StudentComments = "",
                StudentID = result.StudentID,
                StudentRating = 0.0
            };

            string resultString = JsonConvert.SerializeObject(gigToBeReturned);

            return resultString ;
        }
    }
}
