﻿using System;

namespace OdejzdyAutobusu.Models
{
    public class Shedule
    {
        public int bus { get; set; }
        public string busto { get; set; }
        public DateTime time { get; set; }
        public int delay { get; set; }
        public string last_known { get; set; }
    }
}