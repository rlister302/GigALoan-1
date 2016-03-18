namespace GigALoan_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SPRT_Colleges
    {
        public SPRT_Colleges()
        {
            this.CORE_Students = new HashSet<CORE_Students>();
        }
    
        public int CollegeID { get; set; }
        public string CollegeName { get; set; }
    
        public virtual ICollection<CORE_Students> CORE_Students { get; set; }
    }
}
