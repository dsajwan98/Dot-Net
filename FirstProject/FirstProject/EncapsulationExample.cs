using System;

namespace FirstProject
{
    class StudentAccessor
    {
        private string _studentName;
        private int _studentId;
        private int _marks;
        private string _Course;
        public string studName
        {
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please insert Student Name");
                }
                else
                {
                    this._studentName = value; 
                
                }
            } 
            get{
                return _studentName;
            }
        }
        public int studentId
        {
            set
            {
                if (value > 0)
                {
                    this._studentId = value;
                }
                else
                {
                    throw new Exception("Please enter student id");
                }
                //(value > 0) ? this._studentId = value : new Exception("Please enter student id");
                
            }
            get
            {
                return _studentId;
            }
        }
        public int marks
        {
            set
            {
                if (value > 0)
                {
                    this._marks = value;
                }
                else
                {
                    throw new Exception("Please enter student marks");
                }
                
            }
            get
            {
                return _marks;
            }
        }
        public string Course
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (string.Equals(value, "B.tech"))
                    {
                        this._Course = value;
                    }
                    else
                    {
                        throw new Exception("Please insert valid course");

                    }
                }
                else
                {
                    throw new Exception("Please insert valid course");

                }
            }
            get
            {
                return _Course;
            }
        }
        //public void SetStudentName (string studentName)
        //{
        //    if (!string.IsNullOrEmpty(studentName))
        //        this.studentName = studentName;
        //    else
        //        throw new Exception("Please insert student Name.");
        //}
        //public string GetStudentName ()
        //{
        //    return studentName;
        //}
        //public void SetStudentId (string studentId)
        //{
        //    if (!string.IsNullOrEmpty(studentId))
        //        this.studentId = studentId;
        //    else
        //        throw new Exception("Please insert student ID.");
        //}
        //public string GetStudentId ()
        //{
        //    return studentId;
        //}
    }
    class EncapsulationExample
    {
        ////public static void Main (String[] args)
        ////{
        ////    StudentAccessor studentObj = new StudentAccessor();
        ////    studentObj.studName="name";
        ////    studentObj.studentId = 1;
        ////    studentObj.marks = 348;
        ////    Console.WriteLine("Name is: " + studentObj.studName);
        ////    Console.WriteLine("Id is: "+ studentObj.studentId);
        ////    Console.WriteLine("Marks are:"+ studentObj.marks);
        ////    //studentObj.SetStudentName("John");
        ////    //Console.WriteLine("Student Name is :"+studentObj.GetStudentName());
        ////    //studentObj.SetStudentId("1");
        ////    //Console.WriteLine("Student ID is :"+ studentObj.GetStudentId());
        ////    Console.ReadLine();
        ////}
    }
}
