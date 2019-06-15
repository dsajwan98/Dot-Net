using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday
{
    class Program
    {
         static void Main(string[] args)
        {
            MyStruc a;
            a.sa = 89;
            MyStruc b = a;
            b.sa = 77;
            
            Console.WriteLine("values {0}", a.sa);
        }
    }


    public struct MyStruc
    {
       public int sa;
  

       public MyStruc(int a)
       {
           this.sa = a;
       }
    }
}
