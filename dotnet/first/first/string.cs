using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class @string
    {

        public static void main(String[] args)
        {
            // compare method example
           String fstring = "this is a text";
           string sstring = "this is a test";
            int result = String.Compare(fstring, sstring);
            string getmessage = (result == 0) ? "strings are equal" : "String are not equal";

            Console.WriteLine(result);
            Console.ReadLine();
        }



    }
}
