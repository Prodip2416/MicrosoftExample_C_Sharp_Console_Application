﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "prodip", "Tuhin", "Fatema" };

            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

        }
    }
}
