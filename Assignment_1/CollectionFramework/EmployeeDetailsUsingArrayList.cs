using System;
using System.Collections.Generic;
using System.Collections;
using LitwareLib;
namespace CollectionFramework
{
    public class EmployeeDetails
    {
        ArrayList list1;
        LinkedList<Employee> list2;
        public EmployeeDetails()
        {
            list1 = new ArrayList();
            list2=new LinkedList<Employee>();

        }
        public void ShowDetails()
        {
            Console.WriteLine("Total Number of Employees are : "+list1.Count);

            foreach (Employee emp in list1)
            {
                emp.ShowDetails();
            }

            foreach (Employee employee in list1)
            {
                employee.ShowDetails();
            }
        }
        public void AddEmployee(int EmpNo,String EmpName,double salary)
        {
            Employee emp=new Employee();

            emp.EmpNo= EmpNo;
            emp.EmpName= EmpName;
            emp.salary = salary;
            emp.SetDetails();
            emp.CalCulateSalary();

            list1.Add(emp);
            list2.AddLast(emp);
            
        }
        public void Search(String name)
        {
            bool found = false;
            foreach(Employee employee in list1)
            {
                if(employee.EmpName.Equals(name))
                {
                    Console.WriteLine("Search Found : "+employee.EmpName+" "+employee.EmpNo);
                    found = true;
                }
            }
            if(!found) 
            {
                Console.WriteLine($"No employee with name {name.ToUpper()} is present!" );
            }
        }
    }
}
