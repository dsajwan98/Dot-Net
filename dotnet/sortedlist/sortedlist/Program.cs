using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    class Program
    {
        public static void Main(string[] args)
        {

            SortedList sortobj = new SortedList();
            sortobj.Add("opi", 1001);
            sortobj.Add("mty", 1002.09);
            sortobj.Add("asd", 1001);
            sortobj.Add("rty", 1001);
                Console.WriteLine("iterartion of non generic sortedlist");
                 for (int i = 0; i<sortobj.Count; i++)
                  {
                    Console.WriteLine("Key={0},Value={1}"sortobj.GetKey(i),sortobj.GetByIndex(i));
                  }
        SortedList<int, string> sortObj2 = new SortedList<int, string>();
            sortObj2.Add(10,"john");
            sortObj2.Add(25,"bob");
            sortObj2.Add(35,"steve");


            Console.WriteLine("iteration  of generic sorted list class");
                         for(int i=0;i<sortObj2.Count;i++)
                          {
                           Console.WriteLine("key={0},value={1}",sortObj2.Keys[i],sortObj2.Values[i]);
                           }
            Console.ReadLine();



        }
    }
}
