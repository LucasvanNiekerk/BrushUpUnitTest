using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpUnitTest
{
    /// <summary>
    /// Student class which includes name, adress and which semester they are attending.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student object which includes name, adress and which semester they are attending.
        /// </summary>
        public Student(string name, string adress, int semester, Gender gender)
        {
            CheckNameIsValid(name);
            CheckSemesterIsValid(semester);
            
            Name = name;
            Adress = adress;
            Semester = semester;
            GenderType = gender;
        }
        
        private string _name;
        private string _adress;
        private int _semester;
        private Gender _genderType;
        
        /// <summary>
        /// Name must be atleast 2 characters.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                CheckNameIsValid(value);
                _name = value;
            }
        }
        
        /// <summary>
        /// Must contain atleast 1 character.
        /// </summary>
        public String Adress
        {
            get { return _adress; }
            set
            {
                CheckAdressIsValid(value);
                _adress = value;
            }
        }

        /// <summary>
        /// Semester must be between 1 and 8 (including 1 and 8).
        /// </summary>
        public int Semester
        {
            get { return _semester; }
            set
            {
                CheckSemesterIsValid(value);
                _semester = value;
            }
        }

        public Gender GenderType
        {
            get { return _genderType; }
            set { _genderType = value; }
        }


        private void CheckNameIsValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is empty.");
            }

            if (name.Length < 2)
            {
                throw new ArgumentException("Name is too short.");
            }
        }

        private void CheckAdressIsValid(string adress)
        {
            if (string.IsNullOrWhiteSpace(adress))
            {
                throw new ArgumentException("Adress is empty.");
            }
        }

        private void CheckSemesterIsValid(int semester)
        {
            if (semester < 1 || semester > 8)
            {
                throw new ArgumentException("Not a valid semester.");
            }
        }

        public override string ToString()
        {
            return "Name: " + Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Student objectToCompare = (Student) obj;
                return Name == objectToCompare.Name && 
                       Adress == objectToCompare.Adress &&
                       Semester == objectToCompare.Semester &&
                       GenderType == objectToCompare.GenderType;
            }
        }
    }
}
