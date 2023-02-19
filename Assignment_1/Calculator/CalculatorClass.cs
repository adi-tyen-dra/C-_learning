using System;

namespace Calculator
{
    public class CalculatorClass
    {
        double a, b;
        string Oper;
        public void GetInput()
        {
            Console.WriteLine("Enter First number: ");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operation you want to perform: ");
            //Enter the Operation only within "+", "-", "/" and "*"
            Oper = Console.ReadLine();
            Console.WriteLine("Enter Second number: ");
            b =double.Parse(Console.ReadLine());

        }
        public String Answer()
        {
            switch(Oper)
            {
                case "+":
                    return (a+b).ToString();

                case "-":
                    return (a-b).ToString();

                case "*":
                    return (a*b).ToString();

                case "/":
                    return (a /b).ToString();

                default:
                    return "Invalid Operation!";
            }
        }
    }
}
