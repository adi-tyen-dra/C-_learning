using System;

namespace CollectionFramework
{
    public class ArrayOperations
    {
        public void DifferentArrayOperations()
        {
            int[] array1 = new int[5] {5, 4, 3, 2, 1 };
            Console.WriteLine("Array1 is :  ");
            PrintArray(array1);

            String[] array2 = new String[3] { "Ranjit", "Shuvendu", "Brijesh" };

            int[] array3 = new int[3];

            //Coping Using Array.Copy
            Array.Copy(array1, 0, array3, 0, 3);
            Console.WriteLine("Coping Using Array.Copy from array1 to array2 ");
            PrintArray(array3);

            //Soring using Array.Sort
            Array.Sort(array1);
            Console.WriteLine("Soring using Array.Sort " );
            PrintArray(array1);

            //Clear method in Array Class
            Array.Clear(array3, 0, 1);
            Console.WriteLine("Clear method in Array Class " +array3);
            PrintArray(array3);

            //Reverse using Array.Reverse
            Array.Reverse(array1);
            Console.WriteLine("Reverse using Array.Reverse "+array1);
            PrintArray(array1);
        }
        public void PrintArray(int [] array)
        {
            foreach(int element in array)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine("\n");
        }
    }
}
