//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eticaret.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public System.Guid Id { get; set; }
        public string AdresDescription { get; set; }
        public int Member_Id { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Member Member { get; set; }
    }
}