using System;
using System.Collections.Generic;

namespace Tasks_IJunior._05_Collections
{
   internal class Dynamic_List
   {
       static void Main(string[] args) 
       {
           bool isWorking = true;

           List<int> array = new List<int>();

           while (isWorking)
           {
               const string MenuNumber = "1";
               const string MenuSum = "2";
               const string MenuExit = "3";

               Console.WriteLine($"\n{MenuNumber} Ввести число {MenuSum} Почтитать сумму {MenuExit} Выйти\n");
               string userInput = Console.ReadLine();

               if (userInput == MenuNumber)
               {
                   AddNumber(array);
               }
               else if (userInput == MenuSum)
               {
                   ShowSum(array);
               }
               else if (userInput == MenuExit)
               {
                   isWorking = false;
               }
               else
               {
                   Console.WriteLine("\nВведины неверные данные");
               }
           }
       }

       static void AddNumber(List<int> array)
       {
           Console.WriteLine("\nВведите число: ");

           int number;
           bool isWorking = true;

           while (isWorking)
           {
           string userNumber = Console.ReadLine();

           if (int.TryParse(userNumber, out number))
           {
               array.Add(number);
               Console.WriteLine("\nЛист: ");

               for (int i = 0; i < array.Count; i++)
               {
                   Console.WriteLine(array[i]);
               }
               break;

           }
           else
           {
               Console.WriteLine("[ERROR]: Invalid input");
               break;
           }
           }
       }

       static void ShowSum(List<int> array)
       {
           int arraySum = 0;

           for (int i = 0; i < array.Count; i++)
               arraySum += array[i];

           Console.WriteLine($"\nСумму всех веденных чисел: {arraySum} ");
       }
   }
}
