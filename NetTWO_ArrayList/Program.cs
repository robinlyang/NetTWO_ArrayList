using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetTWO_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[3];
            Console.WriteLine(i.Length);

            ArrayList a = new ArrayList(); //you can allocat a number if you with ... = new ArrayList(1000);
            a.Add(200);
            a.Add(100);
            a.Add(400);

            a.Sort();

            int total = 0;

            for (int x = 0; x < a.Count; x++)
            {
                total = total + (int)a[x]; // must cast collections to use them total = total + a[x]; won't work
                Console.WriteLine(a[x]);
            }
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
