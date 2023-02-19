using ReflectionMain;
using System;
using System.Reflection;


namespace ReflectionMain
{
    internal class MainMethod
    {
        static void Main(string[] args)
        {
            //LoadAssembly obj = new LoadAssembly();

            var attributes  = typeof(HDFCAccount).GetCustomAttributes(true);
            foreach(var attribute in attributes)
            {
                var attributeValue = (SoftwareAttribute)attribute;
                Console.WriteLine($"Project Name : {attributeValue.ProjectName}\nDescription : " +
                    $"{attributeValue.Description}\nClient Name : {attributeValue.ClientName}\nStart Date : " +
                    $"{attributeValue.StartedDate}\nEnd Date : {attributeValue.EndDate}\n\n");
            }
            attributes = typeof(ICICIAccount).GetCustomAttributes(true);
            foreach (var attribute in attributes)
            {
                var attributeValue = (SoftwareAttribute)attribute;
                Console.WriteLine($"Project Name : {attributeValue.ProjectName}\nDescription : " +
                    $"{attributeValue.Description}\nClient Name : {attributeValue.ClientName}\nStart Date : " +
                    $"{attributeValue.StartedDate}\nEnd Date : {attributeValue.EndDate}");
            }
        }

    }
    
}
