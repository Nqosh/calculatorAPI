using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator_API.Model
{
    public class Calculator
    {
        public int Id { get; set; }
        public string ValueX { get; set; }
        public string ValueY { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
