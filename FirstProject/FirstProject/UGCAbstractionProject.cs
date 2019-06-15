using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public abstract class UGC
    {
        public abstract void SetUname (String Pname);
        public abstract String GetUname ();
    }
    public abstract class University:UGC
    {
        private String Name;
        public override void SetUname (String Pname)
        {
            this.Name=Pname;
        }
        public override string GetUname ()
        {
            return this.Name;
        }
        public abstract void SetCname (String Pname);
        public abstract String GetCname ();
    }

   public class College:University
   {
        private String Name;
        public override void SetCname (string Pname)
        {
            this.Name = Pname;
        }
        public override string GetCname ()
        {
            return this.Name;
        }
   }

    class UGCAbstractionProject
    {
        //public static void Main (String[] args)
        //{
        //    University UTU = new College();
        //    UTU.SetUname("Uttarakhand Technical University");
        //    College DBIT = new College();
        //    DBIT.SetCname("Dev Bhoomi Institute of Technology");
        //    Console.WriteLine(UTU.GetUname());
        //    Console.WriteLine(DBIT.GetCname());
        //    Console.ReadLine();
        //}
    }

}
