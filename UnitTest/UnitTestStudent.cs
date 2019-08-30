using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUpUnitTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTestStudent
    {
        private Student _stundent;

        [TestInitialize]
        public void Initilaize()
        {
            _stundent = new Student("Jacob", "Pulsen 27", 3, Gender.Male);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual(_stundent.Name, "Jacob");
            _stundent.Name = "Ib";
            Assert.AreEqual(_stundent.Name, "Ib");

            try
            {
                _stundent.Name = null;
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Name is empty.", e.Message);
            }

            try
            {
                _stundent.Name = "i";
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Name is too short.", e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameEmptyException()
        {
            _stundent.Name = "N";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameTooShortException()
        {
            _stundent.Name = null;
        }

        [TestMethod]
        public void TestAdress()
        {
            Assert.AreEqual(_stundent.Adress, "Pulsen 27");
            _stundent.Adress = "HejVej";
            Assert.AreEqual(_stundent.Adress, "HejVej");

            try
            {
                _stundent.Adress = null;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Adress is empty.", e.Message);
            }
        }

        [TestMethod]
        public void TestSemester()
        {
            Assert.AreEqual(_stundent.Semester, 3);
            _stundent.Semester = 1; //Minimum semester
            Assert.AreEqual(_stundent.Semester, 1);
            _stundent.Semester = 8; //Maximum semester
            Assert.AreEqual(_stundent.Semester, 8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestÍnvalidSemester()
        {
            _stundent.Semester = -1;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestÍnvalidSemester2()
        {
            _stundent.Semester = 369;
        }

        [TestMethod]
        public void TestGender()
        {
            Assert.AreEqual(_stundent.GenderType, Gender.Male);
            _stundent.GenderType = Gender.Female;
            Assert.AreEqual(_stundent.GenderType, Gender.Female);
        }

        [TestMethod]
        public void TestOverrideEquals()
        {
            Student student1 = new Student("Morten", "Et eller andet sted", 3, Gender.Male);
            Student student2 = new Student("Lucas", "Et andet sted", 3, Gender.Male);
            Student student3 = new Student("Morten", "Et eller andet sted", 3, Gender.Male);


            Assert.IsFalse(student1.Equals(student2));
            Assert.IsFalse(student2.Equals(student1));
            Assert.IsTrue(student1.Equals(student3));
        }

        [TestMethod]
        public void TestOverrideToString()
        {
            Assert.AreEqual("Name: Jacob", _stundent.ToString());
        }
    }
}
