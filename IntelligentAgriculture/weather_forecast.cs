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
    
    public partial class weather_forecast
    {
        public int id { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<double> Temp_avg { get; set; }
        public Nullable<double> Temp_max { get; set; }
        public Nullable<double> Temp_min { get; set; }
        public Nullable<double> Wind_max { get; set; }
        public Nullable<double> Precipitation { get; set; }
        public Nullable<double> Humidity_avg { get; set; }
        public string Description { get; set; }
    }
}
