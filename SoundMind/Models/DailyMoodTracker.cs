using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoundMind.Models
{
    public class DailyMoodTracker
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Display(Name ="Check here if you exercised today")]
        public bool hasExercised { get; set; }
        public string Mood { get; set; }
        public string Notes { get; set; }
    }
}