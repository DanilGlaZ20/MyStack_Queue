using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace MyStack_Queue
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n=Convert.ToInt16(Console.ReadLine());
            var stack= new MyStack<Book>();
            var queue= new MyQueue<Book>();
            String name = null;
            int year = 0; 
            var b = new Book(name, year);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите название книги:");
                  name = Convert.ToString(Console.ReadLine());
                Console.Write("  Введите год написания книги книги: ");
                  year = Convert.ToInt16(Console.ReadLine());
                 b = new Book(name, year);
                stack.Push(b);
                queue.Enqueue(b);
            }
            Console.WriteLine(" Книги на полке:");
            foreach (var book in queue)
            {
                Console.WriteLine(  book.Name+" "+book.Year);
            }
            
            Console.WriteLine("\nКниги в коробке:");
            foreach (var book in stack)
            {
                Console.WriteLine(  book.Name+" "+book.Year);
            }
            

            stack.Pop();
            queue.Dequeue();
            
            Console.WriteLine("После того как забрали 1 книгу"+ "\nКниги на полке:");
            foreach (var book in queue)
            {
                Console.WriteLine(  book.Name+" "+book.Year);
            }
            
            Console.WriteLine("\nКниги в коробке:");
            foreach (var book in stack)
            {
                Console.WriteLine(  book.Name+" "+book.Year);
            }
            
            
        }

        


    }
}
