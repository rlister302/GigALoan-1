//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GigALoan_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CORE_Students
    {
        public CORE_Students()
        {
            this.CHLD_StudentImages = new HashSet<CHLD_StudentImages>();
            this.CHLD_StudentLoans = new HashSet<CHLD_StudentLoans>();
            this.CHLD_StudentReferences = new HashSet<CHLD_StudentReferences>();
            this.CORE_Gigs = new HashSet<CORE_Gigs>();
            this.SPRT_GigTypes = new HashSet<SPRT_GigTypes>();
        }
    
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateJoined { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public int MajorID { get; set; }
        public int CollegeID { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> Employed { get; set; }
        public string Employer { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Long { get; set; }
    
        public virtual ICollection<CHLD_StudentImages> CHLD_StudentImages { get; set; }
        public virtual ICollection<CHLD_StudentLoans> CHLD_StudentLoans { get; set; }
        public virtual ICollection<CHLD_StudentReferences> CHLD_StudentReferences { get; set; }
        public virtual ICollection<CORE_Gigs> CORE_Gigs { get; set; }
        public virtual SPRT_Colleges SPRT_Colleges { get; set; }
        public virtual SPRT_Majors SPRT_Majors { get; set; }
        public virtual ICollection<SPRT_GigTypes> SPRT_GigTypes { get; set; }
    }
}
