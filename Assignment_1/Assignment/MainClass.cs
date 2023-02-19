using Calculator;
using AverageMarks;
using System;
using Sum_Using_Params;
using Swap;
using AreaAndCircumference;
using BookDetails;
using LitwareLib;
using CollectionFramework;
using System.Numerics;
using BankAccount;
using FileIOMethods;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace Assignment
{
    
    internal class MainClass
    {
        static void Main(string[] args)
        {
            //Some Questions are merged with the single question
            Console.WriteLine("Enter the Question number you want to Run from the following sequence: ");
            Console.WriteLine("1. Calculator\n2. Maximum Average marks\n3. Addition using Params\n4. Swapping\n5. Area and Circumference of a Circle" +
                "\n6. Book Details\n7. Calculate Employee Salary\n8. Custom Generic Class My Stack\n9. Array Operations\n10. Collection Framework" +
                "Team\n11. LitWare Lib Manager\n12. Bank Account Operations\n13. Different Bank Accounts");
            int Qnumber = int.Parse(Console.ReadLine());

            switch (Qnumber)
            {

                case 1:
                    CalculatorClass obj = new CalculatorClass();
                    obj.GetInput();
                    Console.WriteLine($"Your Answer is: {obj.Answer()}");
                    break;

                case 2:
                    Maximum_Marks obj2 = new Maximum_Marks();
                    obj2.Get_Input();
                    Console.WriteLine($"Maximum average marks is: {obj2.Max_Marks()}");
                    break;
                
                case 3:
                    Sum_using_Params obj3 = new Sum_using_Params();
                    Console.WriteLine("Sum is : " + obj3.Sum(1, 2, 3, 4, 5));
                    break;

                case 4:
                    Swaping obj4 = new Swaping();
                    obj4.Get_Input();
                    obj4.SwapNumber();
                    break;

                case 5:
                    Console.WriteLine("Enter the radius of the circle:");
                    double radius = double.Parse(Console.ReadLine());
                    Circle obj5 = new Circle();
                    Console.WriteLine("Circumference: " + obj5.CalculateCircumference(radius));
                    Console.WriteLine("Area: " + obj5.CalculateArea(radius));
                    break;
                
                case 6:
                    Books obj6 = new Books();
                    obj6.Get_Detail();
                    obj6.Show_Detail();
                    break;
                
                case 7:
                    Employee obj7 = new Employee();
                    obj7.GetInput();
                    obj7.CalCulateSalary();

                    Manager Obj7 = new Manager();
                    Obj7.CalCulateSalary();

                    MarketingExecutive oBj7 = new MarketingExecutive();
                    oBj7.CalCulateSalary();
                    break;
                
                case 8:
                    MyStack<int> obj8 = new MyStack<int>(5);
                    obj8.push(1);
                    obj8.push(2);
                    obj8.PrintStack();
                    MyStack<int> newobj8 = (MyStack<int>)obj8.Clone();
                    newobj8.push(5);
                    newobj8.PrintStack();
                    break;
                
                case 9:
                    ArrayOperations obj9 = new ArrayOperations();
                    obj9.DifferentArrayOperations();

                    EmployeeDetails Obj9 = new EmployeeDetails();
                    Obj9.AddEmployee(7431, "Rohit", 14000);
                    Obj9.AddEmployee(2592, "Divyansh", 25000);
                    Obj9.ShowDetails();
                    Obj9.Search("Rohit");
                    Obj9.Search("Sannu");

                    /*MyStack<String> oBj9 = new MyStack<String>(2);
                    oBj9.push("A");
                    oBj9.push("B");
                    MyStack<String> newStack = (MyStack<int>)oBj9.Clone();
                    newStack.push("C");*/
                    break;

               case 10:
                    Team India = new Team(3);
                    India.AddPlayer("KL Rahul", 50);
                    India.AddPlayer("Virat", 77);
                    India.AddPlayer("Jadeja", 101);

                    foreach (Players player in India.team)  
                    {
                        Console.WriteLine("Player name:  " + player._name + " Run scored : " + player._runScored);
                    }

                    static void Main(string[] args)
                    {
                        IEnumerable<Players> team = GetArray();
                        foreach (var player in team)  
                        {
                            Console.WriteLine("Player name:  " + player._name + " Run scored : " + player._runScored);
                        }

                    }
                    static IEnumerable<Players> GetArray()
                    {
                        Team India = new Team(3);
                        India.AddPlayer("KL Rahul", 50);
                        India.AddPlayer("Virat", 77);
                        India.AddPlayer("Jadeja", 101);

                        foreach (Players player in India)
                        {
                            yield return player;
                        }
                    }
                    break;
                
                case 11:
                    Manager obj11 = new Manager();
                    obj11.CalCulateSalary();
                    PrintDetailsDelegate Print = obj11.ShowDetails;
                    Print();


                    MarketingExecutive Obj11 = new MarketingExecutive();
                    Obj11.CalCulateSalary();
                    Print = Print + Obj11.ShowDetails;
                    Print();
                    break;
                
                case 12:
                    Account obj12 = new Account(4576, "Rohit", 35000);
                    obj12.UnderBalance += Account.Obj_UnderBalance;
                    obj12.BalanceZero += Account.Obj_BalanceZero;

                    obj12.Deposit(10000);
                    obj12.Withdraw(2000);
                    break;
                case 13:
                    ICICIBank obj13 = new ICICIBank(9823, "Rohit", 35000);
                    obj13.Deposit(10000);
                    obj13.Withdraw(60000);


                    HDFCBank Obj13 = new HDFCBank(7465, "Rohit", 35000);
                    Obj13.Deposit(10000);
                    Obj13.Withdraw(30000);
                    break;
                default:
                    Console.WriteLine("Now a Valid Question Number!");
                    break;

            }
        
        }

    }
    
}



