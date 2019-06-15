using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    //class teacher
    //{
    //    public string tname;
    //    public string tid;
    //    public string salary;
    //    public string department;



    //}
    //class staff : teacher
    //{
    //    public string sname;
    //    public string sid;


    //    public staff(string staffname, string staffid)
    //    {
    //        this.sname = staffname;
    //        this.sid = staffid;

    //    }


    //    public void WriteMethod()
    //    {
    //        Console.WriteLine("staff name is:" +sname);
    //        Console.WriteLine("staff id is:" +sid);
    //        Console.WriteLine("staff salary is:" +salary);
    //        Console.WriteLine("staff department is" + department);
    //    }

    //}

    ////class baseclass
    ////{
    ////    public string studentname;
    ////    public int studentid;
    ////    public static int count;
    ////    static baseclass()
    ////    {
    ////        count = 0;
    ////        Console.WriteLine("base class static constructor called");

    ////    }
    ////    public baseclass()
    ////    {
    ////        Console.WriteLine("base class constructor called");
    ////    }
    ////    public baseclass(string stdname, int stdid)
    ////    {
    ////        this.studentname = stdname;
    ////        this.studentid = stdid;
    ////    }
    ////    public void WriteMethod()
    ////    {
    ////        Console.WriteLine("student name is:" + studentname);
    ////        Console.WriteLine("student id is:" + studentid);
    ////    }
    ////    class derivedclass : baseclass
    ////    {
    ////        int marks;
    ////        static derivedclass()
    ////        {
    ////            Console.WriteLine("derived class static constructor called");
    ////        }
    ////        public derivedclass() : base()
    ////        {
    ////            Console.WriteLine("derived called constructor called");

    ////        }
    ////        public derivedclass(string stdname, int stdid)
    ////        {
    ////            this.studentname = stdname;
    ////            this.studentid = stdid;
    ////        }

    ////    }


    class employee
    {
        public string name;
        public int id;
        public string department;
        public  string address;
        public string qualification;
        public string specilization;

    }

    class teachingstaff : employee
    {

         public string workloadinaday;
        public string workloadinaweek;
        public string workloadinamonth;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public string Qualification
        {
            get { return this.qualification; }
            set { this.qualification = value; }
        }
        public string Speciliation
        {
            get { return this.specilization; }
            set { this.specilization = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Workloadinaday
        {
            get { return this.Workinaday; }
            set { this.Workinaday = value; }
        }
        public string Workloadinaweek
        {
            get { return this.Workinaweek; }
            set { this.Workinaweek = value; }
        }
        public string Worklaodinamonth
        {
            get { return this.Workinamonth; }
            set { this.Workinamonth = value; }
        }

    }
    class nonteachingstaff : employee
    {

        string officename;

    }
    class Class1
    {

       

        class Program
        {
            static void Main(string[] args)
            {
                teachingstaff o = new teachingstaff();
                o.name = "harsh";
                o.id = 123;
                o.qualification = "mtech";
                o.specilization = "java";
                o.address = "dehradun";
                o.Workinaday = "5 hours";
                o.Workinaweek = "6 day";
                o.Workinamonth = "26 days";


                Console.WriteLine("name is :" + o.name);
                Console.WriteLine("id is :" + o.id);
                Console.WriteLine("qualification is :" + o.qualification);
                Console.WriteLine("specilization is :" + o.specilization);
                Console.WriteLine("address is :" + o.address);
                Console.WriteLine("workinaday is :" + o.Workinaday);
                Console.WriteLine("workinaweek is :" + o.Workinamonth);
                Console.WriteLine("workinamonth is :" + o.Workinamonth);
                Console.WriteLine("=================================================");
                Console.WriteLine("name of");
                Console.ReadLine();
            }



        }
        }
    }


