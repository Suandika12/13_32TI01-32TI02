﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Vaksin_Entities_13 : DbContext
    {
        public Vaksin_Entities_13()
            : base("name=Vaksin_Entities_13")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Akun> Akuns { get; set; }
        public virtual DbSet<AkunRoleMapping> AkunRoleMappings { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
    }
}
