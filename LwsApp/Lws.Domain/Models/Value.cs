//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lws.Domain.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Value
    {
        public int Id { get; set; }
        public System.DateTime ServerDate { get; set; }
        public Nullable<System.DateTime> SensorDate { get; set; }
        public Nullable<int> NumberOfNP { get; set; }
        public Nullable<int> NumberOfPP { get; set; }
        public Nullable<int> Meter1Value { get; set; }
        public Nullable<int> Meter2Value { get; set; }
        public Nullable<int> Meter3Value { get; set; }
        public int SensorId { get; set; }
    
        public virtual Sensor Sensor { get; set; }
    }
}