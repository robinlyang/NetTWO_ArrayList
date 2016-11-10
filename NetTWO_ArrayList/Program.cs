using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetTWO_ArrayList
{
    class worker
    {
        public string name;
        public int[] hours = new int[7];
        public int this[int x] //Indexor
        {
            get { return hours[x]; }
            set { hours[x] = value; }
        }
    }
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

            //SortedLists
            SortedList s = new SortedList();
            //key can be anything BUT first key determines type
            s[1234567] = "bob"; // adds if not found (1234567 is the key)
            s[1234567] = "ed"; //replace
            s[7654321] = "mary";
            s[123] = "ted";
            //s["AB"] = "ted"; will give an error
            if(s.ContainsKey(123)) //ContainsKey checks if data is already there
            {
                s.Remove(123); //will remove this data from the sorted list
            }
            //Stack
            Stack ss = new Stack(); //list in first out LIFO
            ss.Push(100);
            ss.Push(200);
            ss.Push(400);
            Console.WriteLine(ss.Pop()); //shows and removes from the top of the stack (i.e. 400)
            Console.WriteLine(ss.Peek()); //shows the next available number (only one level down)
            //Queue
            Queue qq = new Queue(); //first in first out FIFO
            qq.Enqueue(100);
            qq.Enqueue(200);
            qq.Enqueue(400);
            Console.WriteLine(qq.Dequeue());//shows and removes first one entered into queue (i.e. 100)
            //Indexor - Microsoft concept
            worker w = new worker();
            w.hours[3] = 5;
            w[3] = 5; // using the Indexor make it the same as above
            worker[] w2 = new worker[10];
            w2[0] = new worker(); //required for array class
            w2[0].name = "Bob";
            //Generic Collections
            SortedList<string, worker> data = new SortedList<string, worker>();
            worker w3 = new worker();
            w3.name = "bob";
            w3.hours[3] = 5;
            data["Monday"] = w3;
            Console.WriteLine(data["Monday"].name);
            List<int> num = new List<int>(); //like an arraylist
            num.Add(100);
            num.Add(200);
            total = 0;
            for(int x2 = 0; x2 < num.Count; x2++)
            {
                total = total + num[x2];
            }
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
