namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(Ridetype.Normal);
            Console.WriteLine(invoiceGenerator.calculateFare(15.5, 25));
        }
    }
}
