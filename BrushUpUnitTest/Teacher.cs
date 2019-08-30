using System;

namespace BrushUpUnitTest
{
    public class Teacher : Person
    {
        public Teacher(string name, string adress, double salary, Gender gender) : base(name, adress, gender)
        {
            Name = name;
            Adress = adress;
            Salary = salary;
            GenderType = gender;
        }

        private double _salary;
        
        public double Salary
        {
            get { return _salary; }
            set
            {
                CheckSalary(value);
                _salary = value;
            }
        }

        private void CheckSalary(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("A teacher must recieve atleast some salary.");
            }
        }
    }
}
