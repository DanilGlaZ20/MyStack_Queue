using System;
using System.Collections.Generic;

namespace MyStack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack < Book > st= new Stack<Book>();
            int n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Convert.ToString(Console.ReadLine());
                st.Push(new Book(Convert.ToString(Convert.ToString(input[0])),Convert.ToInt16(input[1])));
                    
            }

            foreach (var p in st)
            {
                Console.WriteLine(p);
            }
            
            
            
        }
    }
}
