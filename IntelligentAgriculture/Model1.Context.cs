﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentAgriculture
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class intelligent_agricultureEntities : DbContext
    {
        public intelligent_agricultureEntities()
            : base("name=intelligent_agricultureEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<controllable_equipment> controllable_equipment { get; set; }
        public virtual DbSet<equipment_information> equipment_information { get; set; }
        public virtual DbSet<sensor_results_record> sensor_results_record { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<weather_forecast> weather_forecast { get; set; }
        public virtual DbSet<socket> socket { get; set; }
    }
}
