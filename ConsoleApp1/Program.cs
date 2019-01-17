using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<T> customList = new CustomList<T>();
            Console.WriteLine("Please enter any value: ");
            customList.CList(Convert.ToString(Console.ReadLine()));
        }
    }
       
}
