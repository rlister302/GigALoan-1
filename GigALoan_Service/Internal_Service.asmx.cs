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
    /// Summary description for Internal_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Internal_Service : System.Web.Services.WebService {

        [WebMethod]
        public List<DTO_CORE_Student> GetStudentsBySkillID(int id) {
            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();
            List<DTO_CORE_Student> results = new List<DTO_CORE_Student>();
            var students = context.CORE_Students.Where(s => s.SPRT_GigTypes.Any(gt => gt.TypeID == id));

            foreach(var student in students)
            {
                DTO_CORE_Student s = new DTO_CORE_Student();
                s.StudentID = student.StudentID;
                results.Add(s);
            }
            

            return results;
        }
    }
}
