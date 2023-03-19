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
            //Лаба №8

            MyArray<int> IntMyArray = new MyArray<int>(5);
            MyArray<string> StrMyArray = new MyArray<string>(3);
            MyArray<decimal> DecMyArray = new MyArray<decimal>(4);

            IntMyArray.AddElement(4, 1);
            Console.WriteLine(IntMyArray.GetElement(1));
            IntMyArray.RemoveElement(1);
            Console.WriteLine(IntMyArray.GetElement(1));
            Console.WriteLine(IntMyArray.GetLength());

            //Лаба №9
            LogDB logDB = new LogDB(5);
            PassDB passDB = new PassDB(5);  

            Console.WriteLine("\nВведите логин:");
            logDB.AddElement(Console.ReadLine(), 0);
            Console.WriteLine("\nВведите пароль:");
            logDB.AddElement(Console.ReadLine(), 0);

            Console.ReadKey();
        }
    }
}
