using System;
using System.IO;
using BankAccount;

namespace FileIOMethods
{
    public class SaveUserDetailsInFile
    {
        String path = @"D:\AccountUserDetailsFile";
        public SaveUserDetailsInFile() 
        {
            //Initializing Account class object
            Console.WriteLine("Enter customer account number:");
            int AccountNumber=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter customer name:");
            String CustomerName=Console.ReadLine();

            Console.WriteLine("Enter customer balance");
            double CustomerBalance=double.Parse(Console.ReadLine());

            //Writing to file
            String text = $"Customer Account Number is {AccountNumber}.His/Her name is {CustomerName}.His/Her account balance is {CustomerBalance}Rs. ";
            WriteToFile(text);

            //Reading File
            ReadFromFile();
        }
        
        public void WriteToFile(String text)
        {
            StreamWriter writer = new StreamWriter(path,false);
            writer.WriteLine(text);
            writer.Close();
        }
        public void ReadFromFile()
        {
            StreamReader reader = new StreamReader(path);
            string read;
            while ((read = reader.ReadLine()) != null)
            {
                Console.WriteLine(read);
            }
            reader.Close();
        }

    }
}
