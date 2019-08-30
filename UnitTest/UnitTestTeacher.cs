using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUpUnitTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTestTeacher
    {
        private Teacher _teacher;

        [TestInitialize]
        public void Initialize()
        {
            _teacher = new Teacher("John", "Skolevej", 1000.50, Gender.Male);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("John", _teacher.Name);
            _teacher.Name = "Bo";
            Assert.AreEqual("Bo", _teacher.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameLength()
        {
            _teacher.Name = "i";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameEmpty()
        {
            _teacher.Name = null;
        }

        [TestMethod]
        public void TestAdress()
        {
            Assert.AreEqual("Skolevej", _teacher.Adress);
            _teacher.Adress = "VejSkole";
            Assert.AreEqual("VejSkole", _teacher.Adress);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAdressEmpty()
        {
            _teacher.Adress = null;
        }

        [TestMethod]
        public void TestSalary()
        {
            Assert.AreEqual(1000.50, _teacher.Salary, 0.1);
            _teacher.Salary = 1500.95;
            Assert.AreEqual(1500.95, _teacher.Salary, 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSalaryValid()
        {
            _teacher.Salary = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSalaryValid2()
        {
            _teacher.Salary = -180;
        }

        [TestMethod]
        public void TestGender()
        {
            Assert.AreEqual(Gender.Male, _teacher.GenderType);
            _teacher.GenderType = Gender.Other;
            Assert.AreEqual(_teacher.GenderType, Gender.Other);
        }
    }
}
