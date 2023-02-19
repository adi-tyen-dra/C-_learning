using System;

namespace LitwareLib
{
    public delegate void PrintDetailsDelegate();
    [Serializable]
    public class Employee:IPrintable
    {
        public int EmpNo;
        public String EmpName;
        public double salary;
        public double HRA;
        public double TA;
        public double DA;
        public double PF;
        public double TDS;
        public double NetSalary;
        public double GrossSalary;

        public void GetInput()
        {

            ReEnter:
            try
            {
                Console.WriteLine("Enter the employee Id :");
                EmpNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee name :");
                EmpName = Console.ReadLine();
                Console.WriteLine("Enter the employee salary :");
                salary = double.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Enter valid values in fields! \n"+ex.Message);
                goto ReEnter;
            }
            catch(OverflowException ex) 
            {
                Console.WriteLine("Enter values in range 0 to {1} only",double.MaxValue +" "+ex.Message);
                goto ReEnter;
            }

            SetDetails();
            
        }
        public void SetDetails()
        {
            if (salary < 5000)
            {
                HRA = ((double)10 / 100) * salary;
                TA = ((double)5 / 100) * salary;
                DA = ((double)15 / 100) * salary;
            }
            else if (salary < 10000)
            {
                HRA = ((double)15 / 100) * salary;
                TA = ((double)10 / 100) * salary;
                DA = ((double)20 / 100) * salary;
            }
            else if (salary < 15000)
            {
                HRA = ((double)20 / 100) * salary;
                TA = ((double)15 / 100) * salary;
                DA = ((double)25 / 100) * salary;
            }
            else if (salary < 20000)
            {
                HRA = ((double)25 / 100) * salary;
                TA = ((double)20 / 100) * salary;
                DA = ((double)30 / 100) * salary;
            }
            else
            {
                HRA = ((double)30 / 100) * salary;
                TA = ((double)25 / 100) * salary;
                DA = ((double)35 / 100) * salary;
            }

            GrossSalary=salary+HRA+TA+DA;

        }
        public virtual void CalCulateSalary()
        {
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);

            
            ShowDetails();  
        }
       
        public virtual void ShowDetails()
        {

            Console.WriteLine($"\nDetails of Marketing Executive {EmpName.ToUpper()} are :");
            Console.WriteLine($"Employee ID : {EmpNo}");
            Console.WriteLine($"Salary : {salary}");
            Console.WriteLine($"HRA : {HRA}");
            Console.WriteLine($"TA : {TA}");
            Console.WriteLine($"DA : {DA}");
            Console.WriteLine($"PF : {PF}");
            Console.WriteLine($"TDS : {TDS}");
            Console.WriteLine($"Net salary : {NetSalary}");
            Console.WriteLine($"Gross salary : {GrossSalary}");

        }
    }
}
