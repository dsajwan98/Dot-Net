using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    abstract class UniversityA
    {
        public abstract void Btech ();
        public abstract void Mtech ();
    }
    class UTU : UniversityA
    {
        public override void Btech ()
        {
            Console.WriteLine("Btech Course Fee in UTU is Lac."); 
        }
        public override void Mtech ()
        {
            Console.WriteLine("Mtech Course Fee in UTU is Lac."); 
        }
    }

    class UPTU : UniversityA
    {
        public override void Btech ()
        {
            Console.WriteLine("Btech Course Fee in UPTU is Lac.");
        }
        public override void Mtech ()
        {
            Console.WriteLine("Mtech Course Fee in UPTU is Lac.");
        }    
    }
    class AbstractionExample
    {
        //public static void Main (String[] args)
        //{
        //    UTU utuObj = new UTU();
        //    utuObj.Btech();
        //    utuObj.Mtech();
        //    UPTU uptuObj = new UPTU();
        //    uptuObj.Btech();
        //    uptuObj.Mtech();
        //    Console.ReadLine();
        //}
    }
}
