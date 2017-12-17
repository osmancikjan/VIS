using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mapper.DataMapper
{
    [XmlRoot("Times")]
    public class TimesAdd
    {
        public int id { get; set; }
        public int s_id { get; set; }
        public int b_id { get; set; }
        public DateTime leaving { get; set; }
        public int delay { get; set; }
        public int next_stop { get; set; }
        public int last_known_stop { get; set; }
    }
}
