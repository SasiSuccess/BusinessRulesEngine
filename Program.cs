using System;
using Microsoft.Extensions.Logging;

namespace BusinessRulesEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Physical Product : 1\n Book : 2\n Membership : 3\n Upgrade Membership : 4\n Learning Ski Video : 5");
                Console.WriteLine("------------------------------- " + Environment.NewLine);
                

                ProductFactory productFactory = new ProductInitializer();

                IPayMode physicalProduct = productFactory.GetInvoiceDetails(1);
                physicalProduct.InvoiceGenerator();
                Console.WriteLine("-------------------------------" + Environment.NewLine);

                IPayMode purchaseBook = productFactory.GetInvoiceDetails(2);
                purchaseBook.InvoiceGenerator();
                Console.WriteLine("-------------------------------" + Environment.NewLine);

                IPayMode membershipActivation = productFactory.GetInvoiceDetails(3);
                membershipActivation.InvoiceGenerator();
                Console.WriteLine("-------------------------------" + Environment.NewLine);

                IPayMode membershipUpgrade = productFactory.GetInvoiceDetails(4);
                membershipUpgrade.InvoiceGenerator();
                Console.WriteLine("-------------------------------");

                IPayMode learningVideo = productFactory.GetInvoiceDetails(5);
                learningVideo.InvoiceGenerator();

            }
            catch (Exception e)
            {
                LoggerMessage.DefineScope(e.Message);
            }
            
        }
    }
}
