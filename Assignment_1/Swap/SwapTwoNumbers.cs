using System;

namespace Swap
{
    public class Swaping
    {
        int a, b;
        public void Get_Input()
        {
            Console.WriteLine("Enter first number: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine($"Value before Swapping: \na={a}\nb={b}");
        }
        public void SwapNumber()
        {
            int k = a;
            a = b;
            b = k;

            Console.WriteLine($"Value after Swapping: \na={a}\nb={b}");
        }
    }
}
