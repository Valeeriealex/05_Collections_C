using System;
using System.Collections.Generic;

namespace Tasks_IJunior._05_Collections
{
   internal class Association_In_Collection
   {
       static void Main(string[] args)
       {
           string[] array1 = { "1", "2", "1" };
           string[] array2 = { "3", "2" };
           List<string> collection = new List<string>();

           PrintArray(array1);
           Console.WriteLine("+");
           PrintArray(array2);
           AddUniqueValue(array1, collection);
           AddUniqueValue(array2, collection);
           Console.WriteLine("=>");
           PrintArray(collection.ToArray());
       }

       static void AddUniqueValue(string[] array, List<string> sortArray)
       {
           for (int i = 0; i < array.Length; i++)
           {
               if (sortArray.Contains(array[i]) == false)
               {
                   sortArray.Add(array[i]);
               }
           }
       }

       static void PrintArray(string[] array)
       {
           foreach (string number in array)
           {
               Console.WriteLine(number);
           }
       }

       //static void PrintArray(List<string> array)
       //{
       //    foreach (string number in array)
       //    {
       //        Console.WriteLine(number);
       //    }
       //}
   }
}
