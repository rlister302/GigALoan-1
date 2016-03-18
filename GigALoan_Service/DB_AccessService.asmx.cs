using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GigALoan_Model;
using GigALoan_DAL;

namespace GigALoan_Service
{
    /// <summary>
    /// Summary description for DB_AccessService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DB_AccessService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<DTO_SPRT_Colleges> GetColleges()
        {
            List<DTO_SPRT_Colleges> returnList = new List<DTO_SPRT_Colleges>();
            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();
            List<SPRT_Colleges> newlist = context.SPRT_Colleges.Take(10).ToList();

            foreach(SPRT_Colleges entity in newlist)
            {
                returnList.Add(new DTO_SPRT_Colleges(entity.CollegeID, entity.CollegeName));
            }

            return returnList;
        }
    }
}
