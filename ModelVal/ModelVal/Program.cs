﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelVal
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.error_level = 2;
            Model.LoadModules("C:/VLDBDemo_win/data/n/org/b.txt");
            
            
            ArrayList s= Model.FindSimilairty();
            Model.GetValue(0, 2);
            Model.GradualCompression(s, 0.9);
           /* for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+ "\t"+Model.GetValue(0, i));
            }

            Model.compress();*/
        }
    }
}
