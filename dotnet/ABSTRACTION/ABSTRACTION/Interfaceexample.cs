using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION
{
    public interface IAddition1
    {
         int Add(int first,int second);
         int Add(int first, int second, int third);
        
    }
    public interface IAddition2
    {
        int Add(int first, int second);
        int Add(int first, int second, int third);

    }
    class addition : IAddition1,IAddition2
    {
        //implict interface type
        public int Add(int first, int second)
        {
            return first + second;
        }
        public int Add(int first, int second,int third)
        {
            return first + second+third;
        }
        //explicit interface type
         int IAddition2.Add(int first, int second)
        {
            return first + second;
        }
        int IAddition2.Add(int first, int second, int third)
        { 
            return first + second + third;
        }
    }
    class Interfaceexample
    {
        public static void Main(string[] args)
        {
            addition o = new addition();
            int A=o.Add(10,20);
            int B=o.Add(10,20,30);
            IAddition2 obj = new addition();
            int C=obj.Add(50, 70);
            int D=obj.Add(10, 10, 10);
            Console.WriteLine("first interface result");
            Console.WriteLine("sum of two number is:" +A);
            Console.WriteLine("sum of three number is:" +B);
            Console.WriteLine("second interface result");
            Console.WriteLine("sum of two number is:"  +C);
            Console.WriteLine("sum of three number is:"  +D);
            Console.ReadLine();
        }



    }
}
