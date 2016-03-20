using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GigALoan_Model
{
    [DataContract]
    class DTO_CHLD_GigImages
    {
        DTO_CHLD_GigImages()
        { }

        DTO_CHLD_GigImages(int gigID, string imageName)
        {
            this.GigID = gigID;
            this.ImageName = imageName;
        }

        [DataMember]
        public int ImageID { get; set; }
        [DataMember]
        public int GigID { get; set; }
        [DataMember]
        public string ImageURL { get; set; }
        [DataMember]
        public string ImageUUID { get; set; }
        [DataMember]
        public string ImageName { get; set; }
    }
}
