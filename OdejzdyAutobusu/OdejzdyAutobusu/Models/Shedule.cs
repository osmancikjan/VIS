using System;

namespace OdejzdyAutobusu.Models
{
    public class Shedule
    {
        int id { get; set; }
        int bus { get; set; }
        string busto { get; set; }
        TimeSpan time { get; set; }
        int delay { get; set; }
        string last_known { get; set; }
    }
}