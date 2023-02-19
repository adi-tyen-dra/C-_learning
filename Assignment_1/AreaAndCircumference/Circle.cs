using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumference
{
    
    public class Circle
    {
        double p = 3.14d;
        public double CalculateArea(double radius)
        {
            return p*radius*radius;
        }
        public double CalculateCircumference(double radius) 
        {
            return 2 * p * radius;
        }
    }
}
