using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class EnumExample
    {
        
        enum UkCities
        {
            Dehradun = 248001,
            Haridwar = 123456,
            Roorkee = 645321,
            Mussoorie = 159856
        };
        enum WeekDays
        {Sunday, Monday=2000, Tuesday, Wednesday, Thursday, Friday, Saturday };
        //public static void Main(string[] args)
        //{
        //    //System.Type type=typeof(int);
        //    //Console.WriteLine(type);
        //    int DayValue = (int)WeekDays.Sunday;
        //    int PinCodeValue = (int)UkCities.Dehradun;
        //    Console.WriteLine("Pincode is:"+PinCodeValue);
        //    string[] CityNames = Enum.GetNames(typeof(UkCities));
        //    //int[] PinCodes=new int[4];
        //    int[] PinCodes =(int[]) Enum.GetValues(typeof(UkCities));
        //    for(int i=0; i< CityNames.Length;i++)
        //    {
        //       int pincode=(int)PinCodes[i];
        //       Console.WriteLine(pincode);
        //    }
        //    Console.WriteLine("Day value is:"+DayValue);
        //    Console.WriteLine(PinCodes);
        //    Console.WriteLine(WeekDays.Saturday);
        //    Console.ReadLine();
        //}
    }
}
