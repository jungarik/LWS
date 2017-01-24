using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Lws.Web.Models.Values
{
    [DataContract]
    public class ValueViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime ServerDate { get; set; }

        [DataMember]
        public Nullable<DateTime> SensorDate { get; set; }

        [DataMember]
        public Nullable<int> NumberOfNP { get; set; }

        [DataMember]
        public Nullable<int> NumberOfPP { get; set; }

        [DataMember]
        public Nullable<int> Meter1Value { get; set; }

        [DataMember]
        public Nullable<int> Meter2Value { get; set; }

        [DataMember]
        public Nullable<int> Meter3Value { get; set; }

        [DataMember]
        public int SensorId { get; set; }

        //public virtual Sensor Sensor { get; set; }

    }
}