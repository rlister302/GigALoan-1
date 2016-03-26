using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GigALoan_DAL;
using GigALoan_Model;
using Newtonsoft.Json;
using System.Device.Location;


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

        private const double METERS_IN_MILE = 1609.344;

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

        [WebMethod]
        public List<DTO_CORE_Student> AlertLocalStudents(DTO_CORE_GigAlert alert, int range)
        {
            GigALoan_DAL.DB_42039_gigEntities1 context = new GigALoan_DAL.DB_42039_gigEntities1();
            if (range == 0)
                range = 10; //10 miles
            
            var localStudents = context.proc_GetLocalStudentsByAlert(alert.AlertID, range).ToList();
            List<DTO_CORE_Student> returnList = new List<DTO_CORE_Student>();

            foreach (var s in localStudents)
            {
                returnList.Add(new DTO_CORE_Student
                {
                    StudentID = s.Value
                });
            }

            return returnList;
        }


        public bool isLocal(double lat1, double lon1, double lat2, double lon2, int range)
        {
            GeoCoordinate start = new GeoCoordinate(lat1, lon1);
            GeoCoordinate end = new GeoCoordinate(lat2, lon2);

            double distance = start.GetDistanceTo(end);

            distance = distance / METERS_IN_MILE;

            /*IF we can't use GeoCoordinate --
            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI * theta / 180;
            double distance =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            distance = Math.Acos(dist);
            distance = distance * 180 / Math.PI;
            distance = distance * 60 * 1.1515;
            */

            if (distance <= range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
