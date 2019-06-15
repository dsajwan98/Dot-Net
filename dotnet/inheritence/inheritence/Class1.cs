using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class employee
    {
        string name;
        int id;
        string department;
        string address;
        string qualification;
        string specilization;

    }

    class teachingstaff : employee
    {
        
        string workloadinaday;
        string workloadinaweek;
        string workloadinamonth;
        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int Id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        public string Department
        {
            get { return this.Department; }
            set { this.Department = value; }
        }
        public string Qualification
        {
            get { return this.Qualification; }
            set { this.Qualification = value; }
        }
        public string Speciliation
        {
            get { return this.Speciliation; }
            set { this.Speciliation = value; }
        }
        public string Address
        {
            get { return this.Address; }
            set { this.Address = value; }
        }
        public string Workinaday
        {
            get { return this.workloadinaday; }
            set { this.workloadinaday = value; }
        }
        public string Workinaweek
        {
            get { return this.Workinaweek; }
            set { this.Workinaweek = value; }
        }
        public string Workinamonth
        {
            get { return this.workloadinamonth; }
            set { this.workloadinamonth = value; }
        }

    }
    class nonteachingstaff : employee
    {
       
        string officename;

    }
    class Class1
    {

        public static void Main(String[] arg)
        {
            teachingstaff o = new teachingstaff();
            o.Name = "harsh";
            o.Id = 123;
            o.Qualification = "mtech";
            o.Speciliation = "java";
            o.Address = "dehradun";
            o.Workinaday = "5 hours";
            o.Workinaweek = "6 day";
            o.Workinamonth = "26 days";

            
            Console.WriteLine("name is :" + o.Name);
            Console.WriteLine("id is :" + o.Id);
            Console.WriteLine("qualification is :" + o.Qualification);
            Console.WriteLine("specilization is :" + o.Speciliation);
            Console.WriteLine("address is :" + o.Address);
            Console.WriteLine("workinaday is :" + o.Workinaday);
            Console.WriteLine("workinaweek is :" + o.Workinamonth);
            Console.WriteLine("workinamonth is :" + o.Workinamonth);
            Console.ReadLine();
        }

    }
}
