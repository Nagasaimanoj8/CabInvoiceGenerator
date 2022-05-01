using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CabInvoiceGenerator;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoiceGenerator = null;

        /// <summary>
        /// Givens the distance and time when analyse should return total fare.
        /// </summary>
        [TestMethod]
        public void GivenDistanceAndTime_WhenAnalyse_ShouldReturnTotalFare()
        {
            //Arrange
            //Create instance of invoice generator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double expectedFare = 25;
            //Calculating Fare
            //Act
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            //Asserting values
            Assert.AreEqual(expectedFare, actualFare);
        }

    }
}
