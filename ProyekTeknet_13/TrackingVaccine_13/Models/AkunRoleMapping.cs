//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackingVaccine_13.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AkunRoleMapping
    {
        public int id_akunrole { get; set; }
        public int id_akun { get; set; }
        public int id_role { get; set; }
    
        public virtual Akun Akun { get; set; }
        public virtual RoleMaster RoleMaster { get; set; }
    }
}
