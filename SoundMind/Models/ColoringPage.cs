using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoundMind.Models
{
    public class ColoringPage
    {
        public int Id { get; set; }
        public string Image { get; set; }
    }
}