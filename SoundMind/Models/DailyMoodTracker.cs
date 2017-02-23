using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundMind.Models
{
    public class DailyMoodTracker
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Mood { get; set; }
        public string Notes { get; set; }
    }
}