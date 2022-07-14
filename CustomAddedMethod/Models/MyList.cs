using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAddedMethod.Models
{
    public class MyLIst<T>
    {
        public string[] arr;

        public MyLIst()
        {
            arr = new string[0];
        }

        public void Add(string name)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = name;
        }

        public void Clear(string name)
        {
            foreach (var item in arr)
            {
                if (item != name)
                {
                    Console.WriteLine(item);
                }

            }
        }


        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
