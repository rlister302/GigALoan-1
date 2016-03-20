using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GigALoan_Model
{
    [DataContract]
    class DTO_SPRT_Majors
    {
        DTO_SPRT_Majors()
        { }

        DTO_SPRT_Majors(int id, string name)
        {
            this.MajorID = id;
            this.MajorName = name;
        }

        [DataMember]
        public int MajorID { get; set; }
        [DataMember]
        public string MajorName { get; set; }
    }
}
