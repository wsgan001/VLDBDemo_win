﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateEx
{
    class Program
    {
        //paramters
        //	error
        //      scal
        // history future
        // pinterval
        //exact query																																																																																																																																																																																																																		
        static void Main(string[] args)
        {
            
            //ex1 scalability
            int size = 1000 * 100;
            double error = 1000;
            int interval = 1;
            for (int i = 100 * 1000; i < 2 * 1000 * 1000 + 100 * 1000; i += 100 * 1000)
            {
                size = i;
                Console.WriteLine("select a, b from mb[1,{0}] error={1} pinterval={2};", size, error, interval);
                Console.WriteLine("select a, b from uk3 where a <{0};", size);
            }
            size = 1000 * 1000;
            for (int i = 1; i < 8000;i+=500 )
            { 
                error =i;
                Console.WriteLine("select a, b from mb[1,{0}] error={1} pinterval={2};", size, error, interval);                
            }
            Console.WriteLine("select a, b from uk3 where a <{0};", size);
            error = 1;
            //interval
            int []intervals={1,2,4,8,16,32,48};
            foreach(int v in intervals) {
                interval=v;
                Console.WriteLine("select a, b from mb[1,{0}] error={1} pinterval={2} qcache=0 func=\'avg\';", size, error, interval);
                Console.WriteLine("select a/{0}, avg(b) from uk3 where a<{1} group by a/{0};", interval,size);
            }
            for (int i = 48*2; i < 1000*100; i +=48 )
            {
                interval = i;
                Console.WriteLine("select a, b from mb[1,{0}] error={1} pinterval={2} qcache=0 func=\'avg\';", size, error, interval);
                Console.WriteLine("select a/{0}, avg(b) from uk3 where a<{1} group by a/{0};", interval, size);
            }
            
     
        }
    }
}