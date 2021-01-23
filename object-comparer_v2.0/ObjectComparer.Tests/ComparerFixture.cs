using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerFixture
    {
        [TestMethod]
        public void Null_values_are_similar_test()
        {
            object first = null, second = null;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void INT_values_are_similar_test()
        {
            int first = 10, second = 10;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void INT_values_are_NOT_similar_test()
        {
            int first = 10, second = 20;
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void STRING_values_are_similar_test()
        {
            string first = "first", second = "first";
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void STRING_values_are_NOT_similar_test()
        {
            string first = "first", second = "second";
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void STRINGARRAY_values_are_similar_test()
        {
            var first = new string[] { "A", "B" };
            var second = new string[] { "B", "A" };

            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void STRINGARRAY_values_are_NOT_similar_test()
        {
            var first = new string[] { "A", "B" };
            var second = new string[] { "C", "A" };

            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void INTARRAY_values_are_similar_test()
        {
            var first = new int[] { 101, 102 };
            var second = new int[] { 102, 101 };

            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void INTARRAY_values_are_NOT_similar_test()
        {
            var first = new int[] { 101, 102 };
            var second = new int[] { 103, 101 };

            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }
        

        [TestMethod]
        public void Students_are_similar_test()
        {
            var a = new Student
            {
                Name = "John",
                Id = 100,
                Marks = new[] { 80, 90, 100 }
            };

            var b = new Student
            {
                Name = "John",
                Id = 100,
                Marks = new[] { 90, 80, 100 }
            };

            Assert.IsTrue(Comparer.AreSimilar(a, b));
        }

        [TestMethod]
        public void Students_are_not_similar_test()
        {
            var a = new Student
            {
                Name = "John",
                Id = 100,
                Marks = new[] { 80, 90, 100 }
            };

            var b = new Student
            {
                Name = "John",
                Id = 101,
                Marks = new[] { 90, 80, 100 }
            };

            Assert.IsFalse(Comparer.AreSimilar(a, b));
        }

        [TestMethod]
        public void StudentsList_are_similar_test()
        {
            var studentListA = new List<Student>();
            var a = new Student
            {
                Name = "John",
                Id = 100,
                Marks = new[] { 80, 90, 100 }
            };

            studentListA.Add(a);

            var studentListB = new List<Student>();
            var b = new Student
            {
                Name = "John",
                Id = 100,
                Marks = new[] { 90, 80, 100 }
            };
            studentListB.Add(b);

            Assert.IsTrue(Comparer.AreSimilar(studentListA, studentListB));
        }

        [TestMethod]
        public void Students_are_similar_InDictionary()
        {
            var a = new Student
            {
                Name = "John",
                Id = 100,
                Marks = new[] { 80, 90, 100 }
            };

            var b = new Student
            {
                Name = "John",
                Id = 100,
                Marks = new[] { 90, 80, 100 }
            };
            var StudentDictionaryA
                = new Dictionary<int, Student>();
            StudentDictionaryA.Add(a.Id, a);

            var StudentDictionaryB
                = new Dictionary<int, Student>();
            StudentDictionaryB.Add(b.Id, b);

            Assert.IsTrue(Comparer.AreSimilar(StudentDictionaryA, StudentDictionaryB));
        }

        [TestMethod]
        public void Students_are_not_similar_InDictionary()
        {
            var a = new Student
            {
                Name = "John",
                Id = 100,
                Marks = new[] { 80, 90, 100 }
            };

            var b = new Student
            {
                Name = "John",
                Id = 101,
                Marks = new[] { 90, 80, 100 }
            };
            var StudentDictionaryA
                = new Dictionary<int, Student>();
            StudentDictionaryA.Add(a.Id, a);

            var StudentDictionaryB
                = new Dictionary<int, Student>();
            StudentDictionaryB.Add(b.Id, b);

            Assert.IsFalse(Comparer.AreSimilar(StudentDictionaryA, StudentDictionaryB));
        }

        [TestMethod]
        public void Values_are_not_similar_InDictionary()
        {
          
            var StudentDictionaryA
                = new Dictionary<int, string>();
            StudentDictionaryA.Add(10, "Test1");

            var StudentDictionaryB
               = new Dictionary<int, string>();
            StudentDictionaryB.Add(10, "TestB");

            Assert.IsFalse(Comparer.AreSimilar(StudentDictionaryA, StudentDictionaryB));
        }

        [TestMethod]
        public void Keys_are_not_similar_InDictionary()
        {

            var StudentDictionaryA
                = new Dictionary<int, string>();
            StudentDictionaryA.Add(10, "Test1");

            var StudentDictionaryB
               = new Dictionary<int, string>();
            StudentDictionaryB.Add(11, "Test1");

            Assert.IsFalse(Comparer.AreSimilar(StudentDictionaryA, StudentDictionaryB));
        }

        [TestMethod]
        public void Values_are_similar_InDictionary()
        {

            var StudentDictionaryA
                = new Dictionary<int, string>();
            StudentDictionaryA.Add(10, "Test1");

            var StudentDictionaryB
               = new Dictionary<int, string>();
            StudentDictionaryB.Add(10, "Test1");

            Assert.IsTrue(Comparer.AreSimilar(StudentDictionaryA, StudentDictionaryB));
        }      

    }
}
