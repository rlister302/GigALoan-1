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
    
    public partial class SPRT_GigCategories
    {
        public SPRT_GigCategories()
        {
            this.SPRT_GigTypes = new HashSet<SPRT_GigTypes>();
        }
    
        public int CategoryID { get; set; }
        public string Category { get; set; }
    
        public virtual ICollection<SPRT_GigTypes> SPRT_GigTypes { get; set; }
    }
}
