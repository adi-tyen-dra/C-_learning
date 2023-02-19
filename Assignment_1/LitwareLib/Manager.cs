using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace LitwareLib
{
    [Serializable]
    public class Manager:Employee,IPrintable
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private double OldGrossSalary;

        public Manager() 
        {  
            base.GetInput();

            OldGrossSalary = base.GrossSalary;

      
        }   
        public override void CalCulateSalary()
        {
            base.CalCulateSalary();

            PetrolAllowance = 0.08 * salary;
            FoodAllowance = 0.13 * salary;
            OtherAllowance = 0.03 * salary;

            GrossSalary += (PetrolAllowance + FoodAllowance + OtherAllowance);
            PF = 0.1 * OldGrossSalary;
            NetSalary = OldGrossSalary - (PF + TDS);



            ShowDetails();
            
        }
        

    }
}
