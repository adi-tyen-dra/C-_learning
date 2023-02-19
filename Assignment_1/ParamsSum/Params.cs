using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Using_Params
{
    public class Sum_using_Params
    {
        public double Sum(params double[] numbers)
        {
            double count = 0d;
            foreach(double n in numbers)
            {
                count += n;
            }
            return count;

        }
    }
}
