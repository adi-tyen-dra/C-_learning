using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection
{
    internal class LoadAssembly
    {
        internal LoadAssembly() 
        {
            //Load Assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            //Get the class type
            Type methodType = assembly.GetType("Reflection.Methods");

            //Create class instance
            object methodInstance = Activator.CreateInstance(methodType);

            //Get the method to be called
            MethodInfo Sum = methodType.GetMethod("Sum");
            MethodInfo Product = methodType.GetMethod("Product");

            //Define parameters for passing
            object[] parameters = new object[2] { 10, 5 };

            //Call the function
            object sum = Sum.Invoke(methodInstance, parameters);
            object product = Product.Invoke(methodInstance, parameters);

            Console.WriteLine("Sum --> " + sum);
            Console.WriteLine("Product --> " + product);
        }
    }
    internal class Methods
    {
        int sum, product;

        public int Sum(int a, int b)
        {
            sum = a + b;
            return a + b;
        }
        public int Product(int a, int b)
        {
            product = a * b;
            return product;
        }
    }
}
