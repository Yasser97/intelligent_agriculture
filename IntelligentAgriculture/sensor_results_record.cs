//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class sensor_results_record
    {
        public string MAC { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<double> Temperature { get; set; }
        public Nullable<double> Humidity { get; set; }
        public Nullable<double> Pressure { get; set; }
        public Nullable<double> Precipitation { get; set; }
        public Nullable<double> Wind_speed { get; set; }
        public Nullable<double> Wind_direction { get; set; }
        public Nullable<double> Soil_temperature { get; set; }
        public Nullable<double> Soil_water_content { get; set; }
        public Nullable<double> Light { get; set; }
        public Nullable<double> Dissolved_oxygen { get; set; }
        public Nullable<double> Oxygen_density { get; set; }
        public Nullable<double> CO2_density { get; set; }
        public Nullable<double> Water_level { get; set; }
        public int id { get; set; }
    }
}