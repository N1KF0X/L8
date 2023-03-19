using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    internal class MyArray <T>
    {
        T[] array;

        public MyArray(int length)
        {
            this.array = new T[length]; 
        }

        public void AddElement(T item, int index)
        {
            if (index >= 0 || index < array.Length)
            {
                this.array[index] = item;
            }
            else
            {
                Console.WriteLine($"Индекс выходит за пределы массива. Максимальный индекс: {array.Length - 1}");
            }
        }

        public void RemoveElement(int index) 
        {
            if (index >= 0 || index < array.Length)
            {
                array[index] = default;
            }
            else
            {
                Console.WriteLine($"Индекс выходит за пределы массива. Максимальный индекс: {array.Length - 1}");
            }
        }

        public T GetElement(int index)
        {
            T element = default;
            if (index >= 0 || index < array.Length)
            {
                element = array[index];
            }
            else
            {
                Console.WriteLine($"Индекс выходит за пределы массива. Максимальный индекс: {array.Length - 1}");             
            }
            return element;
        }

        public int GetLength()
        {
            return array.Length;
        }
    }
}
