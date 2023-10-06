using CabInvoiceGenerator;
namespace CabInvoiceGeneratorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(Ridetype.Normal);
            double distance = 120.0;
            int time = 10; 

            double fare = invoice.calculateFare(distance, time);
            double expected = 130;

            Assert.AreEqual(expected, fare);
        }
    }
}