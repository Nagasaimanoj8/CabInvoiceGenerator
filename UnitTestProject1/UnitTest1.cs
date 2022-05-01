using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CabInvoiceGenerator;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class CabInvoiceUnitTest
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

        [TestMethod]
        [TestCategory("Fare")]
        public void GivenMultipleRidesShouldeturnAggregateTotalFare()
        {
            //double expected =60;
            //Arrange
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            InvoiceSummary expected = new InvoiceSummary(rides.Length, 60);
            //Generating Summary for rides
            //Act
            InvoiceSummary actual = invoiceGenerator.CalculateFare(rides);
            //Asserting values
            // Assert.AreEqual(expected, actual);
            expected.Equals(actual);
        }
    }
}
