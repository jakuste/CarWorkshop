﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarWorkshopModelContext : DbContext
    {
        public CarWorkshopModelContext()
            : base("name=CarWorkshopModelContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Act_dict> Act_dict { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<Object_type> Object_type { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
