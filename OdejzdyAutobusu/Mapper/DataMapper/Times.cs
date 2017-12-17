using System;
using System.Xml.Serialization;

namespace Mapper.DataMapper
{
    
    public class Times
    {
        public int bus { get; set; }
        public string last { get; set; }
        public DateTime leaving { get; set; }
        public int delay { get; set; }
        public string last_known { get; set; }
    }
}
