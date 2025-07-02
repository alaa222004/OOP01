using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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

    #region Q3

    public enum Seas_on
    {
        Spring,
        Summer,
        Autumn,
        Winter
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

            #region Q2

            //Define a struct "Person" with properties "Name" and "Age". Create an array of three
            //"Person" objects and populate it with data.Then, write a C# program to display the details 
            // of all the persons in the array.
            #endregion

            #region Q3

            //        Create an enum called "Seas on" with the four seasons(Spring, Summer, Autumn, Winter) 
            //        as its members.Write a C# program that takes a season name as input from the user and 
            //displays the corresponding month range for that season. Note range for seasons
            //( spring march to may , summer june to august , autumn September to November , winter December to Februar

            string season_name=Console.ReadLine();

            if(season_name == "March" || season_name == "April" || season_name == "May")
                Console.WriteLine(Seas_on.Spring);
            else if(season_name == "June" || season_name == "July" || season_name == "August")
                Console.WriteLine(Seas_on.Summer);
            else
                Console.WriteLine(Seas_on.Winter);
            




                //January
            //February: (فبراير)
            //March: (مارس)
            //April: (إبريل)
            //May: (مايو)
            //June: (يونيو)
            //July: (يوليو)
            //August: (أغسطس)
            //September: (سبتمبر)
            //October: (أكتوبر)
            //November: (نوفمبر)
            //December

                #endregion
        }
    }
}
