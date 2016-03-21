using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GigALoan_DAL;
using GigALoan_Model;
using Newtonsoft.Json;

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
        public string GetStudentsBySkillID(string json) {
            var requestObject = JsonConvert.DeserializeObject<DTO_SPRT_GigType>(json);

            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();

            List<DTO_CORE_Student> results = new List<DTO_CORE_Student>();

            var students = context.CORE_Students.Where(s => s.SPRT_GigTypes.Any(gt => gt.TypeID == requestObject.TypeID));

            foreach(var student in students)
            {
                results.Add(new DTO_CORE_Student
                {
                    StudentID = student.StudentID
                });
            }


            return JsonConvert.SerializeObject(results);
        }
    }
}
