using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageMarks
{
    public class Maximum_Marks
    {
        double[] Marks_Arr;
        public void Get_Input()
        {
            Marks_Arr = new double[5];
            Console.WriteLine("Enter the Average marks of 5 Students: ");
            for (int i = 0; i < 5; i++)
            {
                Marks_Arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public double Max_Marks()
        {
            double count = 0;
            foreach (double m in Marks_Arr)
            {
                if (count < m)
                {
                    count = m;
                }
            }
            return count;
        }
    }
}
