using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestConsoleApplication
{
   public static class SmallestUtility
    {
       public static int Smallest = 0; 
        public static int SmallestMethod(int[] array)
        {
            Smallest = array[9];

            for (int j = 0; j < array.Length; j++ )
            {
                if (array[j] > Smallest)
                {
                    Smallest = array[j];
                }
            }

                return Smallest;
        }
    }
}
