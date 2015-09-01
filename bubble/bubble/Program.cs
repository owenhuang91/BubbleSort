using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new int[] { 11,5,66,34,56,23,11,22,3333,600,350,200,133,2 };
            var length = a.Count();


            for (int i = length; i > 1; i--)
            {
                for (int j = 0; j <= i-2; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        var tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
 
                }
            }


           

        }
    }
}
