using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_part1.Models
{
    public class Chips:Food
    {
        public bool IsAllowed { get; set; }
    }
}