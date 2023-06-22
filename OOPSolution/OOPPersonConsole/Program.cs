using System;
using static System.Console;

namespace OOPPersonConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Instantiate a new person object.
            //  Refer to this objects as person1
            Person person1 = new Person();

            //  Print out all default values  for person1
            //  By Calling the Getter Methods for person1
            WriteLine("Print out all default values for person1 using getters");
            WriteLine("The first name of person1 is: " + person1.GetFirstName());
            WriteLine("The last  name of person1 is: " + person1.GetLastName());
            WriteLine("The eye color  of person1 is: " + person1.GetEyeColor());
            WriteLine("The hair color of person1 is: " + person1.GetHairColor());
            WriteLine("The height of person1 is: " + person1.GetHeight().ToString());
            WriteLine("The weight of person1 is: " + person1.GetWeight().ToString());
            WriteLine("The gender of person1 is: " + person1.GetGender());
            WriteLine("The marital status of person1 is: " + person1.GetIsMarried());
            WriteLine("\n\n");

            //  Call the Setter for each instance variable for person1
            person1.SetFirstName("Jeff");
            person1.SetLastName("Scott");
            person1.SetEyeColor("Blue");
            person1.SetHairColor("Brown");
            person1.SetHeight(72);
            person1.SetWeight(250);
            person1.SetGender("Male");
            person1.SetIsMarried(true);

            //  Call the Getter Methods for person1
            WriteLine("Print out all values for person1 using getters after using setters");
            WriteLine("The first name of person1 is: " + person1.GetFirstName());
            WriteLine("The last  name of person1 is: " + person1.GetLastName());
            WriteLine("The eye color  of person1 is: " + person1.GetEyeColor());
            WriteLine("The hair color of person1 is: " + person1.GetHairColor());
            WriteLine("The height of person1 is: " + person1.GetHeight().ToString());
            WriteLine("The weight of person1 is: " + person1.GetWeight().ToString());
            WriteLine("The gender of person1 is: " + person1.GetGender());
            WriteLine("The marital status of person1 is: " + person1.GetIsMarried());

            //  Call non-getter/non-setter methods of the Person class
            WriteLine("\n\n");
            WriteLine("Call non-getter/non-setter methods of the Person class");
            person1.Eat("Cake");
            person1.Drink("Milk");
            person1.Sleep(8);

            ReadLine();
        }
    }
}
