using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpUnitTest
{
    public class Person
    {
        private string _name;
        private string _adress;
        private Gender _genderType;

        public Person(string name, string adress, Gender genderType)
        {
            _name = name;
            _adress = adress;
            _genderType = genderType;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                CheckName(value);
                _name = value;
            }
        }

        public string Adress
        {
            get { return _adress; }
            set
            {
                CheckAdress(value);
                _adress = value;
            }
        }

        public Gender GenderType
        {
            get { return _genderType; }
            set { _genderType = value; }
        }

        private void CheckName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name is empty.");
            }

            if (value.Length < 2)
            {
                throw new ArgumentException("Name too short.");
            }
        }

        private void CheckAdress(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Adress is empty.");
            }
        }
    }
}
