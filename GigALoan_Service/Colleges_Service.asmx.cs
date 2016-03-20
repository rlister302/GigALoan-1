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
        /* Adding a record to a table with a stored proc 
           This proc is a temp proc because it edits the Colleges which was
           not intended to be messed with. */
        [WebMethod] 
        public int AddCollege(String collegeName)
        {
            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();
            var result = context.proc_AddCollegeTest(collegeName);

            //Adding a record to the College Table using EF
            //SPRT_Colleges newCollege = new SPRT_Colleges();
            //newCollege.CollegeName = "Atlanta Technical College";
            //context.SPRT_Colleges.Add(newCollege);
            //context.SaveChanges();

            return result;
        }

        [WebMethod]
        public DTO_SPRT_College GetCollegeByID(int id)
        {
            DTO_SPRT_College returnCollege = new DTO_SPRT_College();

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            //Retrieving a College by ID using Stored Proc and Linq Lambda
            var college = context.proc_GetColleges().Where(col => col.CollegeID == id).Single();
            DTO_SPRT_College result = new DTO_SPRT_College(college.CollegeID, college.CollegeName);

            //Retrieving a College by ID using Linq
            //DTO_SPRT_Colleges result =
            //    (from college in context.SPRT_Colleges
            //    where college.CollegeID == id
            //    select new DTO_SPRT_Colleges
            //    {
            //        CollegeID = college.CollegeID,
            //        CollegeName = college.CollegeName
            //    }).Single();

            return result;
        }

        [WebMethod]
        public List<DTO_SPRT_College> GetColleges()
        {
            List<DTO_SPRT_College> returnList = new List<DTO_SPRT_College>();
            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();
            //List<SPRT_Colleges> newlist = context.SPRT_Colleges.ToList();         

            //Retrieving Golleges using a Stored Proc
            var list = context.proc_GetColleges().ToList();
            foreach (var entity in list)
            {
                returnList.Add(new DTO_SPRT_College(entity.CollegeID, entity.CollegeName));
            }

            return returnList;
        }

        [WebMethod]
        public List<DTO_SPRT_College> GetTwentyColleges()
        {
            List<DTO_SPRT_College> returnList = new List<DTO_SPRT_College>();
            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();
            List<SPRT_Colleges> newlist = context.SPRT_Colleges.Take(20).ToList();

            foreach (SPRT_Colleges entity in newlist)
            {
                returnList.Add(new DTO_SPRT_College(entity.CollegeID, entity.CollegeName));
            }

            return returnList;
        }
    }
}
