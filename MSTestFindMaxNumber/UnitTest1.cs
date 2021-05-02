using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericDemoTest;

namespace MSTestFindMaxNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

            //UC1 for finding Integer value
            
            [DataRow(1, 2, 3, 3)]
            [DataRow(1, 4, 2, 4)]
            [DataRow(5, 2, 1, 5)]
            public void MaximumIntegerNumber_ReturnMaximumNumber(int a, int b, int c, int max)
            {
                int result = MaximumNumber.MaximumIntegerNumber(a, b, c);
                Assert.AreEqual(result, max);
            }
        //UC2 for finding Float value
            [TestMethod]
            [DataRow(1.1f, 2.2f, 3.3f, 3.3f)]
            [DataRow(1.1f, 4.4f, 2.2f, 4.4f)]
            [DataRow(5.5f, 2.2f, 1.1f, 5.5f)]
            public void MaximumFloatNumber_PassThreeNumbers_ReturnMaximumNumber(float a, float b, float c, float max)
            {
                double result = MaximumNumber.MaximumDoubleNumber(a, b, c);
                Assert.AreEqual(result, max);
            }
        //UC3 for finding String
        [TestMethod]
        [DataRow("1", "2", "3", "3")]
        [DataRow("1", "4", "2", "4")]
        [DataRow("5", "2", "1", "5")]
        public void MaximumStringNumber_PassThreeNumbers_ReturnMaximumNumber(string a, string b, string c, string max)
        {
            string result = MaximumNumber.MaximumStringVAlue("a"," b", "c");
            Assert.AreEqual(result, max);
        }

        [TestMethod]
        public void MaximumNumberGenericInteger_PassThreeNumbers_ReturnMaximumNumber()
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            MaximumGeneric<int> generic = new MaximumGeneric<int>(intArray);
            int result = generic.MaxMethod();
            Assert.AreEqual(result, 678);
        }

        //UC4 more than 3 parameters
        [TestMethod]
        public void MaximumNumberGenericFloat_PassThreeNumbers_ReturnMaximumNumber()
        {
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            MaximumGeneric<double> genericDouble = new MaximumGeneric<double>(doubleArray);
            double result = genericDouble.MaxMethod();
            Assert.AreEqual(result, 55.5);
        }

        [TestMethod]
        public void MaximumNumberGenericString_PassThreeNumbers_ReturnMaximumNumber()
        {
            string[] stringArray = { "111", "222", "333", "55", "999" };
            MaximumGeneric<string> genericString = new MaximumGeneric<string>(stringArray);
            string result = genericString.MaxMethod();
            Assert.AreEqual(result, "999");
        }
    }
}

