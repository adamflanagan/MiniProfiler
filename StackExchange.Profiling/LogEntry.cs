using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace StackExchange.Profiling
{
    [DataContract]
    public class LogEntry
    {
        [DataMember(Order = 1)]
        public DateTime Time { get; set; }
        [DataMember(Order = 2)]
        public string Message { get; set; }
        [DataMember(Order = 3)]
        public string Context { get; set; }
        [DataMember(Order = 4)]
        public string Level { get; set; } // TODO: Possibly tie into existing ProfilingLevel enum
    }
}
