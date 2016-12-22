//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lws.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Sensor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sensor()
        {
            this.States = new HashSet<State>();
            this.Values = new HashSet<Value>();
        }

        [DataMember(Name = "ssn")]
        public string Ssn { get; set; }
        [IgnoreDataMember]
        public int UserId { get; set; }
        [IgnoreDataMember]
        public byte[] QrCode { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string IsOptMeter1 { get; set; }
        [DataMember]
        public string IsOptMeter2 { get; set; }
        [DataMember]
        public string IsOptMeter3 { get; set; }
        [DataMember]
        public string Latitude { get; set; }
        [DataMember]
        public string Longitude { get; set; }
        [DataMember]
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<State> States { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<Value> Values { get; set; }
    }
}
