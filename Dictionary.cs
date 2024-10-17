using System;
using System.Collections.Generic;

namespace Tasks_IJunior._05_Collections
{
   internal class Dictionary
   {

       static void Main(string[] args)
       {
           Dictionary<string, string> dictionary = new Dictionary<string, string>();

           dictionary.Add("переменная", "это поименованная, либо адресуемая иным способом область памяти, адрес которой можно использовать для осуществления доступа к данным и изменять значение в ходе выполнения программы.");
           dictionary.Add("условные операторы", "созданы для управления процессом выполнения программы условные операторы: if и switch, а для запуска повторяющихся действий циклы: for, while (do/while) и foreach.");
           dictionary.Add("массив", "это упорядоченный набор элементов, каждый из которых хранит одно значение, идентифицируемое с помощью одного или нескольких индексов, бывает одномерный и многомерный.");
           dictionary.Add("функции", "это фрагмент программного кода, к которому можно обратиться из другого места программы.");
           dictionary.Add("коллекции", "это гибкий способ работы с группами объектов: List, Queue, Stack, Dictionary.");

           bool isWorking = true;

           while (isWorking)
           {
               string entrance = "1";
               string exit = "2";

               Console.WriteLine($"\nСловарь.\n{entrance}- начать поиск знаения слов\n{exit} - выйти\n");
               string userChoice = Console.ReadLine();

               if (userChoice == entrance)
               {
                   ScreachWorld(dictionary);
               }
               else if (userChoice == exit)
               {
                   isWorking = false;
               }
               else
               {
                   Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
               }
           }
       }

       static void ScreachWorld(Dictionary<string, string> dictionary)
       {
           Console.WriteLine("\nВведите слово: ");
           string userWorld = Console.ReadLine();
           string author = userWorld.ToLower();

           if (dictionary.ContainsKey(author))
           {
               Console.WriteLine(dictionary[author]);
           }
           else
           {
               Console.WriteLine("Такого слова нет");
           }
       }
   }
}
