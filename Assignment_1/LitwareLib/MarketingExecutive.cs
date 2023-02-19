using System;


namespace LitwareLib
{
    [Serializable]
    public class MarketingExecutive:Employee, IPrintable
    {
        private double KilomterTravelled;
        private double TourAllowance;
        private double TelephoneAllowance=1000d;
        private double OldGrossSalary;

        public MarketingExecutive()
        {
            base.GetInput();

            OldGrossSalary = base.GrossSalary;

            Console.WriteLine("Enter the kilometers Travelled");
            KilomterTravelled = Convert.ToDouble(Console.ReadLine());
        }
        public override void CalCulateSalary()
        {
            base.CalCulateSalary();
            TourAllowance = KilomterTravelled * 5;

            GrossSalary += (TourAllowance + TelephoneAllowance);
            PF = 0.1 * OldGrossSalary;
            NetSalary = OldGrossSalary - (PF + TDS);



            
            ShowDetails();
        }

        
    }
}
