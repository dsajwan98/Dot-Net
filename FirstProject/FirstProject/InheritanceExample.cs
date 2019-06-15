using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Employee
    {
        string _employeeName;
        int _employeeId;
        double _employeeSalary;

        //////public Employee()
        //////{
          
        //////}

        public string EmployeeName
        {
            get { return this._employeeName; }
            set { this._employeeName = value; }
        }

        public int EmployeeId
        {
            get { return this._employeeId; }
            set { this._employeeId = value; }
        }

        public double EmployeeSalary
        {
            get { return this._employeeSalary; }
            set { this._employeeSalary = value; }
        }
    }
    class Faculty : Employee
    {
        public Faculty () :base(){ }
        string _subjectName;
        string _departmentName;
        string _collegeName;
        int _workLoadInHours;

        public string SubjectName
        {
            get { return this._subjectName; }
            set { this._subjectName = value; }
        }
        public string departmentName
        {
            get { return this._departmentName; }
            set { this._departmentName = value; }
        }
        public string CollegeName
        {
            get { return this._collegeName; }
            set { this._collegeName = value; }
        }
        public int WorkLoadInHours
        {
            get { return this._workLoadInHours; }
            set { this._workLoadInHours = value; }
        }
    }
    class AdminStaff : Employee
    {
        string _designation;
        string _officeName;
        string _specialization;

        public string Designation
        {
            get { return this._designation; }
            set { this._designation = value; }
        }
        public string OfficeName
        {
            get { return this._officeName; }
            set { this._officeName = value; }
        }
        public string Specialization
        {
            get { return this._specialization; }
            set { this._specialization = value; }
        }

    }
    class MainClass
    { 

        //public static void Main(string[] args)
        
        //{
        //    Faculty facultyObj = new Faculty();
            
        //    facultyObj.EmployeeName = "Thanos";
        //    facultyObj.EmployeeId = 101;
        //    facultyObj.departmentName = "Computer Science";
        //    facultyObj.CollegeName = "DBIT";
        //    facultyObj.EmployeeSalary = 1000;
        //    facultyObj.SubjectName = "Dot Net";

        //    Console.WriteLine("Employee Name:"+ facultyObj.EmployeeName);
        //    Console.WriteLine("Employee Id:"+ facultyObj.EmployeeId);
        //    Console.WriteLine("Department Name:" + facultyObj.departmentName);
        //    Console.WriteLine("College Name:"+ facultyObj.CollegeName);
        //    Console.WriteLine("Employee Salary:"+ facultyObj.EmployeeSalary);
        //    Console.WriteLine("Subject Name:"+ facultyObj.SubjectName);
        //    Console.WriteLine();
        //    AdminStaff aobj = new AdminStaff();
        //    aobj.EmployeeName = "Thanos Srivastav";
        //    aobj.EmployeeId = 101;
        //    aobj.Designation = "Brahmand ke musafir";
        //    aobj.EmployeeSalary=1000000000000000;
        //    aobj.OfficeName = "Jupiter";
        //    aobj.Specialization = "Destruction";
        //    Console.WriteLine("Employee name:"+aobj.EmployeeName);
        //    Console.WriteLine("Employee Id:" + aobj.EmployeeId);
        //    Console.WriteLine("Designation:" + aobj.Designation);
        //    Console.WriteLine("Employee Salary:" + aobj.EmployeeSalary);
        //    Console.WriteLine("Office name:" + aobj.OfficeName);
        //    Console.WriteLine("Specialization:" + aobj.Specialization);
        //    Console.ReadLine();
        //}
    }
    
}
