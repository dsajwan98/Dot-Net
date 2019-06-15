using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class student {
        string _name;
        int _studentid;
         string _coursename;
        //public void Setname(String sname)
        //{
        //    this.name = sname;
        //}
        //public string Getname()
        //{
        //    return this.name;
        //}
        public string Name
        {
            get
            {
                return this._name;
                
                
            }
            set
            {
               this._name = value;
                
            }
        }
        public string course
        {
            get
            {
                return this._coursename;


            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("please insert your course");
                    //throw new Exception("please insert your course");
                }
               
                    
                
                else
                {
                    this._coursename = value;
                }
            

            }
        }
        public int Id
        {
            get
            {
                return this._studentid;


            }
            set
            {
                this._studentid = value;

            }
        }





    }
    class Program
    {
        static void Main(string[] args)
        {
            //it is the process of covering up of data and function into a single unit(called class)
            student o = new student();
            o.Name = "harsh";
            o.course = "";
            o.Id = 123;
          /*  o.name = "harsh"*/;
            //o.studentid =1;
            //o.coursename = "btech";
            Console.WriteLine("student name is:"+o.Name);
            Console.WriteLine("student course is:" + o.course);
            Console.WriteLine("student id is:" + o.Id);
            Console.ReadLine();
        }
    }
}
