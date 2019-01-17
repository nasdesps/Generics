using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CustomList<T>
    {
        public void CList<T>(T data)
        {
            List<T> list = new List<T>();
            list.Add(data);
            foreach (T i in list)
            {
                Console.Write($"{i}\n");
            }

            //return (T)Convert.ChangeType(data, typeof(T));

        }
    }
}
