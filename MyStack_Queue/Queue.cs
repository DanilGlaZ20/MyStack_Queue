using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MyStack_Queue
{
    public class MyQueue<T>: IEnumerable<T>
    {
        private T[] items;//эл очереди
        private int count;//кол-во элементов 
        
        private const int n = 10;
        private int Front=-1;//голова
        private int Rear = -1;//хвост
        public MyQueue() //конструктор создает массив items
        {
            items = new T[n];
        }

        public MyQueue(int length) //для самостоятельного установления длины массива
        {
            
            items = new T[length];
        }
            
        public bool IsEmpty // а есть ли очередь 
        {
            get { return count == 0; }
        }
        public int Count //возвращает кол-во элементов в очереди
        {
            get { return count; }
        }

        public void Enqueue(T num)
        {
            if (count == items.Length) Resize(items.Length + 10);
            items[++Rear] = num;
            count++;
        }

        public T Dequeue()
        {
            T value = items[0];
            items[0] = default(T);
            for (int i = 0; i < count - 1; i++) items[i] = items[i + 1];
            count--;
            items[count] = default(T);
            return value;
        }
        private void Resize(int max) //увеличить стек
        {

            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++) tempItems[i] = items[i];
            items = tempItems;

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i =0; i <=count-1; i++)
                {
                    yield return this.items[i];
                }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}