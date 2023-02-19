using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using LitwareLib;
//Note :: Set this project as startup project
namespace SerializeAndDeserialize
{
    internal class BinarySerializer
    {
        static BinaryFormatter formatter;
        static void Main(string[] args)
        {
            Manager manager = new Manager();

           formatter = new BinaryFormatter();

            SerializeManager(manager);
            DeserializeManager(manager);
        }
        
        public static void SerializeManager(Manager manager)
        {
            //Serialization (Manager)
            FileStream stream = new FileStream(@"D:\AccountUserDetailsFile\Manager", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, manager);
            stream.Close();
        }
        public static void DeserializeManager(Manager mg)
        {
            //Deseralization (Manager)
            Stream stream = new FileStream(@"D:\AccountUserDetailsFile\Manager", FileMode.Open, FileAccess.Read);
            Manager newMg = (Manager)formatter.Deserialize(stream);
            newMg.PrintDetails();
            stream.Close();
        }
    }
}
