﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxAttendees { get; set; }
        public int GuildId { get; set; }
    }
}
