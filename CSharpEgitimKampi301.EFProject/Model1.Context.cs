﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpEgitimKampi301.EFProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EgitimKampiEfTravelDbEntities : DbContext
    {
        public EgitimKampiEfTravelDbEntities()
            : base("name=EgitimKampiEfTravelDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<tblCustomer> tblCustomer { get; set; }
        public DbSet<tblGuide> tblGuide { get; set; }
        public DbSet<tblLocation> tblLocation { get; set; }
        public DbSet<tblAdmin> tblAdmin { get; set; }
    }
}
