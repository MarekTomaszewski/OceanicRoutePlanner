//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OceanicRoutePlanner.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPermission
    {
        public int Id { get; set; }
        public Nullable<int> User { get; set; }
        public Nullable<int> Permission { get; set; }
    
        public virtual Permission Permission1 { get; set; }
        public virtual User User1 { get; set; }
    }
}
