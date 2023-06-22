using System;
using static System.Console;

namespace OOPPersonConsole
{
    public class Person
    {
		//	Instance Variables
		private string		_firstName;
		private string		_lastName;
		private string		_eyeColor;
		private string		_hairColor;
		private int			_height;
		private int			_weight;
		private string		_gender;
		private bool		_isMarried;

        //  Default Constructor
        public Person() { }


        //	Getters (Accessors)
        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetEyeColor()
        {
            return _eyeColor;
        }

        public string GetHairColor()
        {
            return _hairColor;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public string GetGender()
        {
            return _gender;
        }

        public bool GetIsMarried()
        {
            return _isMarried;
        }

        //	Setters (Mutators)
        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        public void SetEyeColor(string eyeColor)
        {
            _eyeColor = eyeColor;
        }

        public void SetHairColor(string hairColor)
        {
            _hairColor = hairColor;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public void SetGender(string gender)
        {
            _gender = gender;
        }

        public void SetIsMarried(bool isMarried)
        {
            _isMarried = isMarried;
        }

        //  Class methods
        public void Eat(string food)
        {
            WriteLine(GetFirstName() + " " + GetLastName() +
                      " is eating " + food);
        }

        public void Drink(string liquid)
        {
            WriteLine(GetFirstName() + " " + GetLastName() +
                      " is drinking " + liquid);
        }

        public void Sleep(int numHours)
        {
            WriteLine(GetFirstName() + " " + GetLastName() +
                      " is sleeping " + numHours + " hours");
        }
    }
}
