using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace МојТермин.Models
{
    public class Term
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int Place { get; set; }
        public string Day { get; set; }
        public Patient Patient { get; set; }

        public Doctor Doctor { get; set; }
    }
}
