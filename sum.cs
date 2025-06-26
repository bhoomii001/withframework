using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withframework
{
    internal class sum
    {
        public static void Main(String[] args)
        {
            //int a = 5;
            //int b = 6;
            //int sum;
            //sum = a + b;
            //Console.WriteLine(sum);
            //Console.Read();

            //   int a = int.Parse(Console.Read());


            int a = Convert.ToInt32(Console.ReadLine());
         
            int b = Convert.ToInt32(Console.ReadLine());
          
            int sum = a + b;
            Console.Write("sum of two number "+ sum);
            Console.Write("Hello class from github");
            Console.ReadLine();
        }
    }
}
