using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first;
using a;
using a.a1;

namespace first
{
    interface addition
    {
        int addition(int f, int l);
    }
    struct Mystructure : addition
    {
        public int x, y;
        public Mystructure(int q, int w)
        {
            x = q;
            y = w;
        }
        public int add(int f, int l)
        {
            return f + l;
        }

        public int addition(int f, int l)
        {
            throw new NotImplementedException();
        }
    }
}

public class myclass
{
    public int studentid;
    public string studentname;
}

class Program
{

}
enum ukcities { dehradun = 123, mussorrie = 123, haridwar = 123, nainital = 123 };
        // static void Main(string[] args)
         {
             //double num = 12345.78;
        decimal i;
i = Convert.ToDecimal(num);
        Console.WriteLine("result is" + i);

        //boxing example

        int k = 123;
object o = k;
//unboxing example

int e = (int)o;
Console.WriteLine("after unbox:" + e);


        Program obj = new Program();
        if (obj.Method1() || obj.Method2()) // | is called pipe
        {
            Console.WriteLine("inside if statemnet");

        }
        //ternatory operator example

        string result = null;
int f = 0;
//if (f > 0)
result = "f is greater than zero";
        else
          result = "f is less than zero";
        result = (f > 0) ? "f is greater than zero" :
            "f is less than zero";

        Console.WriteLine(result);
        // null coleasing operator example
        int? h = null;
int g = h ?? -1;

Console.WriteLine("value is :"+g);
        //  array example
        int[] a = new int[10];

        for (int l = 0; l<a.Length; l++)
         {
            a[l] = l + 100;
         }
        //for (int l = 0; l < a.Length; l++)
        //{
        //    Console.WriteLine("the value of array is:" + a[l]);
        //}
        foreach (int l in a)
        {
            Console.WriteLine("the value of array is:" +l);
        }
        structure example
        Mystructure st;
st.x = 10;
        st.y = 20;
        Mystructure stobj = new Mystructure(12, 10);
stobj.x = 1000;
        stobj.y = 2000;

        Console.WriteLine("x={0},y={1}", st.x, st.y);
        //class example


        myclass obj9 = new myclass();
obj9.studentid = 101;
        obj9.studentname = "harsh";
        Console.WriteLine("studentid={0},studentname={1}", obj9.studentid, obj9.studentname);




                    //enum example
                    string[] citynames = Enum.GetNames(typeof(ukcities));
int[] pin = (int[])Enum.GetValues(typeof(ukcities));
                    for (int i = 0; i<citynames.Length; i++)
                    {
                        Console.WriteLine("cityname={0},pincode={1}",citynames[i],pin[i]);

                    }
                    Console.ReadLine();
                }
            }
        }
                    
        harsh obj = new harsh();
        int result = obj.Addition(20, 30);
        s o = new s();
        int result1 = o.Multiplcation(2, 3);
        pqr o1 = new pqr();
        int result2 = o.Multiplcation(5, 4);
        q obj2 = new q();
        int result3 = obj2.Division(10, 2);
        Console.WriteLine("hello welocme to .net first lab");
            Console.WriteLine("result of addition is: "+result);
            Console.WriteLine("result of multiplication is: "+result1);
            Console.WriteLine("result of multiplication is: " + result2);
            Console.WriteLine("result of divison is: " + result3);
            Console.ReadLine();
            

        
        public bool Method1()
{
    Console.WriteLine("method1 called");
    return true;

}
public bool Method2()
{
    Console.WriteLine("method2 called");
    return false;
}


