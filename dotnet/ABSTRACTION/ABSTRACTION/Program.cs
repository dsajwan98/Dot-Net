//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ABSTRACTION
//{
//    abstract class UGC
//    {
//        public abstract void regestration();
//        public abstract void fees();

//    }
//    class University : UGC {
//        public override void regestration()
//        {
//            Console.WriteLine("please regester yourself");
//        }
//        public override void fees()
//        {
//            Console.WriteLine("btech fees is 1 lakh in university");
//            Console.WriteLine("mtech fees is 2 lakh in university");
//            Console.WriteLine("**********************************");
//        }

//    }
//    class college : UGC
//    {
//        public override void regestration()
//        {
//            Console.WriteLine("please fill the regestration form");
            
//        }
//        public override void fees()
//        {
//            Console.WriteLine("btech fees is 2 lakh in college");
//            Console.WriteLine("polythenic fees is 50 thousand in college");
//        }
    

//    //abstract class University
//    //{
//    //    public abstract void Btech();
//    //    public abstract void Mtech();
//    //}
//    //class UTU : University
//    //{
//    //    public override void Btech()
//    //    {
//    //        Console.WriteLine("btech course fee in utu is 1 lakh");
//    //    }
//    //    public override void Mtech()
//    //    {
//    //        Console.WriteLine("mtech course fee in utu is 1.5 lakh");
//    //    }
//    //}
//    //class UPTU : University
//    //{
//    //    public override void Btech()
//    //    {
//    //        Console.WriteLine("btech course fee in uptu is 1 lakh");
//    //    }
//    //    public override void Mtech()
//    //    {
//    //        Console.WriteLine("mtech course fee in uptu is 1.5 lakh");
//    //    }
//    //}
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            University o = new University();
////            o.regestration();
////            o.fees();
////            college obj = new college();
////            obj.regestration();
////            obj.fees();
////            Console.ReadLine();
////            //    UTU o = new UTU();
////        //    o.Btech();

////        //    o.Mtech();
////        //    UPTU obj = new UPTU();
////        //    obj.Btech();
////        //    obj.Mtech();
////        //    Console.ReadLine();
////        }
////    }
////}
