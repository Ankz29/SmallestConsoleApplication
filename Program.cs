using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallestConsoleApplication;

namespace SmallestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.Write( "enter the array elements: " + "\n" );

            for (int i= 0 ; i< array.Length ; i++)
            {
                var arrayElements = Convert.ToInt32(Console.ReadLine());
            }

            var smallestElement = SmallestUtility.SmallestMethod( array );

            Console.Write( "The smallest elements from the array is: " + smallestElement );
            Console.Read();
        }
    }
}
