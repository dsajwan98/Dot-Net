using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class FindArea
    {
        public double area()
        {
            return 0;
        }
        class Circle : FindArea
        {
           double radius;
           public Circle(double radii)
            {
                this.radius = radii;
            }
            public double area()
            {
                return (3.14 * Math.Pow(radius,2));
            }
             
        }
        class Square : FindArea
        {
             int length;
            public Square(int side)
            {
                this.length = side;
            }
            public double Area()
            {
                return length * length;

            }
        }
    

     //class Addition
        //{
        //    public int Add(int f, int s, int t)
        //    {
        //        return f + s + t;

        //    }
        //    public int Add(int first, int second)
        //    {
        //        return first + second;
        //    }
        //}


        static void Main(string[] args)
        {

            Circle o = new Circle(5);
            double area = o.area();
            Console.WriteLine("area of circle is: " +area) ;
            Square obj = new Square(15);
            double Area = obj.Area();
            Console.WriteLine("area of square is: " +Area);
            Console.ReadLine();
            //Addition obj = new Addition();
            //int result =obj.Add(20, 30);
            //int result1=obj.Add(10, 20, 30);
            //Console.WriteLine("first addition result is:" +result);
            //Console.WriteLine("second addition result is:" +result1);
            //Console.ReadLine();
            
        }
    }
}
