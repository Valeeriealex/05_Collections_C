using System;
using System.Collections.Generic;

namespace Tasks_IJunior._05_Collections
{
   internal class Queue
   {
       static void Main(string[] args)
       {
           Queue<int> buyers = FillQueue();

           int buyerNumber = 1;
           int purchaseAmount;
           int counter = 0;

           bool isWorking = true;

           while (isWorking)
           {
               if (buyers.Count > 0)
               {
                   purchaseAmount = buyers.Dequeue();
                   counter += purchaseAmount;
                   Console.WriteLine($"{buyerNumber++} покупатель сделал покупку на сумму {purchaseAmount} рублей.");
                   Console.WriteLine($"Ваш счет: {counter}");
                   Console.ReadKey();
                   Console.Clear();
               }
               else
               {
                   Console.WriteLine($"Счет: {counter}");
                   Console.WriteLine("Очередь покупателей закончилась");
                   Console.ReadKey();
                   Console.Clear();
                   isWorking = false;
               }
           }
       }

       static Queue<int> FillQueue()
       {
           Queue<int> buyers = new Queue<int>(); //очередь покупателлей

           buyers.Enqueue(100);
           buyers.Enqueue(250);
           buyers.Enqueue(300);
           buyers.Enqueue(450);
           buyers.Enqueue(500);

           return buyers;
       }
   }
}
        
