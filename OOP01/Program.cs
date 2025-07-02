using System;
using System.ComponentModel;

namespace OOP01
{
    #region Q1
    public enum WeekDays
    {
        Sunday,
        Monday, 
        Tuesday, 
        Wednesday,
        Thursday, 
        Friday,
        Saturday

    }
    #endregion 

    internal class Program
    {
        static void Main()
        {
            #region Q1
            //Create an enum called "WeekDays" with the days of the week(Monday to Sunday) 
            // as its members.Then, write a C# program that prints out all the days of the week using this enum.


            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            
             {
                Console.WriteLine(day);
            }


            #endregion
        }
    }
}
