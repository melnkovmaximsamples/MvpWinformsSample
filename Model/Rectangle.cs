using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Sample.Model
{
    public class Rectangle
    {
        public double length { get; set; }
        public double width { get; set; }
        public double result { get { return length * width; } }
    }
}
