using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GigALoan_DAL;
using GigALoan_Model;

namespace GigALoan_Service
{
    /// <summary>
    /// Summary description for Colleges_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Colleges_Service : System.Web.Services.WebService
    {
        [WebMethod]
        public DTO_SPRT_Colleges GetCollegeByID(int id)
        {
            DTO_SPRT_Colleges returnCollege = new DTO_SPRT_Colleges();

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            DTO_SPRT_Colleges result =
                (from college in context.SPRT_Colleges
                where college.CollegeID == id
                select new DTO_SPRT_Colleges
                {
                    CollegeID = college.CollegeID,
                    CollegeName = college.CollegeName
                }).Single();

            return result;
        }

        [WebMethod]
        public List<DTO_SPRT_Colleges> GetTenColleges()
        {
            List<DTO_SPRT_Colleges> returnList = new List<DTO_SPRT_Colleges>();
            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();
            List<SPRT_Colleges> newlist = context.SPRT_Colleges.Take(10).ToList();

            foreach (SPRT_Colleges entity in newlist)
            {
                returnList.Add(new DTO_SPRT_Colleges(entity.CollegeID, entity.CollegeName));
            }

            return returnList;
        }

        [WebMethod]
        public List<DTO_SPRT_Colleges> GetTwentyColleges()
        {
            List<DTO_SPRT_Colleges> returnList = new List<DTO_SPRT_Colleges>();
            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();
            List<SPRT_Colleges> newlist = context.SPRT_Colleges.Take(20).ToList();

            foreach (SPRT_Colleges entity in newlist)
            {
                returnList.Add(new DTO_SPRT_Colleges(entity.CollegeID, entity.CollegeName));
            }

            return returnList;
        }
    }
}
