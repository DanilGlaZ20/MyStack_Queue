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
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите название книги:");
                String name = Convert.ToString(Console.ReadLine());
                Console.Write("  Введите год написания книги книги: ");
                int year = Convert.ToInt16(Console.ReadLine());
                var b = new Book(name, year);
                stack.Push(b);
            }
            
            Console.WriteLine("Книги в коробке:");
            foreach (var b in stack)
            {
                Console.WriteLine(  b.Name+" "+b.Year);
            }
            
            
            Console.WriteLine("Книги на полке:");
            foreach (var b in queue)
            {
                Console.WriteLine(  b.Name+" "+b.Year);
            }
            
            
                

        }
        
        
    }
}
