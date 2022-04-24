using System;
using System.Net;
using System.Reflection;

namespace MyStack_Queue
{
    public class Stack<T> : IAbstractStack<T>
    {
        private T[] items; //эл стека
        private int count; //кол-во элементов в массиве
        private const int n = 10;

        public Stack() //конструктор создает массив items
        {
            items = new T[n];
        }

        public Stack(int length) //для самостоятельного установления длины массива
        {
            items = new T[length];
        }

        public bool IsEmpty // а пуст ли стек
        {
            get { return count == 0; }
        }

        public int Count //возвращает кол-во элементов в стеке
        {
            get { return count; }
        }

        public void Push(T num)//положить
        {
            if (count == items.Length) Resize(items.Length + 10);

            items[count++] = num;
        }

        public void Pop()//взять
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст");
            T num = items[--count];
            items[count] = default;
             
        }

        public T Peek()//подсмотреть
        {
            return items[count - 1];
        }

        private void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++) tempItems[i] = items[i];
            items = tempItems;
            
        }






    }

    public interface IAbstractStack<T>
    {

    }
}
