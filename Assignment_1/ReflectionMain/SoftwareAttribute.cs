using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionMain
{
    public class SoftwareAttribute:Attribute
    {
        String projectName, description, clientName, startedDate, endDate;
        public String ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        public String ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public String StartedDate
        {
            get { return startedDate; }
            set { startedDate = value; }
        }
        public String EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

    }
    [Software(ProjectName ="AddingLoan", Description ="Want to add borrowing feature",ClientName ="GOI",StartedDate ="12 July 2019",EndDate ="15 August 2020")]
    public class HDFCAccount
    {
        public HDFCAccount() { Console.WriteLine("This is HDFC Account"); }
    }
    [Software(ProjectName = "CreditCardOrdering", Description = "Feature to order credit card online", ClientName = "ICICI Bank", StartedDate = "12 December 2022", EndDate = "24 March 2023")]
    public class ICICIAccount
    {
        public ICICIAccount() { Console.WriteLine("This is ICICI Account");  }
    }
}
