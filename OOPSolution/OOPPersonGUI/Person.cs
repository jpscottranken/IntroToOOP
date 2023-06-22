using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPersonGUI
{
    public class Person
    {
        //  Instance variables
        private string _firstName;
        private string _lastName;
        private string _eyeColor;
        private string _hairColor;
        private int    _height;
        private int    _weight;
        private string _gender;
        private bool   _maritalStatus;

        //  Set (mutator) and Get (accessor) data using properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }

            //get => _firstName;
            //set => _firstName = value;
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string EyeColor
        {
            get
            {
                return _eyeColor;
            }
            set
            {
                _eyeColor = value;
            }
        }

        public string HairColor
        {
            get
            {
                return _hairColor;
            }
            set
            {
                _hairColor = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public bool MaritalStatus
        {
            get
            {
                return _maritalStatus;
            }
            set
            {
                _maritalStatus = value;
            }
        }

    }
}
