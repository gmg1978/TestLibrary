using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace UnitTestTestLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TriangleTest()
        {
            // Create an instance to test:
            Triangle _triangle = new Triangle(10,5,7);

            // Define a test input and output value:
            double expectedResult = 25;

            // Run the method under test:
            double actualResult = _triangle.Area;
            
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
            //Assert.AreEqual(expectedResult, actualResult, 0.001, "Ошибка в расчете");
        
            
        }
    }
}
