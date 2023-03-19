using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            string[] strArray = new string[3];
            decimal[] decArray = new decimal[4];
            MyArray<int> IntMyArray = new MyArray<int>(intArray);
            MyArray<string> StrMyArray = new MyArray<string>(strArray);
            MyArray<decimal> DecMyArray = new MyArray<decimal>(decArray);

            IntMyArray.AddElement(4, 1);
            Console.WriteLine(IntMyArray.array[1]);
            Console.WriteLine(IntMyArray.GetElement(1));
            IntMyArray.RemoveElement(1);
            Console.WriteLine(IntMyArray.GetElement(1));
            Console.WriteLine(IntMyArray.GetLength());           
        }
    }
}
