using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GigALoan_Model
{
    [DataContract]
    public class DTO_SPRT_Colleges
    {
        public DTO_SPRT_Colleges()
        { }
        public DTO_SPRT_Colleges(int id, string name)
        {
            this.CollegeID = id;
            this.CollegeName = name;
        }
        [DataMember]
        public int CollegeID { get; set; }
        [DataMember]
        public string CollegeName { get; set; }
    }
}
