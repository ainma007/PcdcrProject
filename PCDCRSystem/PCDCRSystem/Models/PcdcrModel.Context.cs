﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCDCRSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PCDCREntities : DbContext
    {
        public PCDCREntities()
            : base("name=PCDCREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivitiesCategory_Table> ActivitiesCategory_Table { get; set; }
        public virtual DbSet<City_Table> City_Table { get; set; }
        public virtual DbSet<Corporation_Table> Corporation_Table { get; set; }
        public virtual DbSet<Programs_Table> Programs_Table { get; set; }
        public virtual DbSet<ProjectActivities_Table> ProjectActivities_Table { get; set; }
        public virtual DbSet<Projects_table> Projects_table { get; set; }
        public virtual DbSet<Province_Table> Province_Table { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ProjectControl_table> ProjectControl_table { get; set; }
        public virtual DbSet<Users_Table> Users_Table { get; set; }
        public virtual DbSet<ActivityPeopleCategory_Table> ActivityPeopleCategory_Table { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
    }
}
