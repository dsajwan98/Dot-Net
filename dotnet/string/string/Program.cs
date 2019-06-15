using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            
            
            //
            // compare method example
            // ascii value of 1st string is greter than scond 1
            // ascii value of 2st string is greter than first -1
            // both are equal return 0
            String fstring = "this is a test";
                string sstring = "this is a.hfdhjkfd9";
                int result = String.Compare(fstring, sstring);
                string getmessage = (result == 0) ? "strings are equal" : "String are not equal";
            Console.WriteLine(result);
            Console.WriteLine(getmessage);
            //contains method example
            String str = "this is a text";
            if(str.Contains("text"))
            {
                Console.WriteLine("text string exit");

            }
            
            else
{

                Console.WriteLine("text string not exit");
            }
            //substring example
            string substring =str.Substring(5,6);
            Console.WriteLine(substring);
            //join string
            String[] strarray=new string[] { "this is a text", "this is a value", "this is args string" };
                

            string MyString = String.Join("\n",strarray);
            Console.WriteLine(MyString);
            //repalce method
            string stringr=str.Replace("test", "teXt");
            Console.WriteLine(stringr);
            //stringbuilder
            
            StringBuilder k = new StringBuilder("dbgi welcome to all of you");
            k.AppendFormat("{0:C}", 50);
            //StringBuilder ki = new StringBuilder("dbgi dehradun",2,9, 20);


            //k.AppendLine("hello");//append method
            //k.AppendLine("i am from");
            //k.AppendLine("btech cse 3rd year");
            //Console.WriteLine(ki);
            //insert object
            k.Insert(6, "c sharp");
            k.Remove(3, 5);
            k.Replace("dbgi", "dbit");
            Console.WriteLine(k);
            Console.ReadLine();



        }


    }

}
