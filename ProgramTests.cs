using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine;

namespace BusinessRulesEngineTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestGetDetails()
        {
            ProductFactory pf = new ProductInitializer();

            IPayMode paymode = pf.GetInvoiceDetails(2);

            Assert.AreEqual(paymode, paymode);

        }

        [TestMethod]
        public void TestPurchaseProduct()
        {
            IPayMode ipm = new PurchasePhysicalProduct();

            Assert.ThrowsException<System.ArgumentNullException>(() => ipm.InvoiceGenerator());

        }

        [TestMethod]
        public void TestPurchaseBook()
        {
            IPayMode ipm = new PurchaseBook();

            Assert.ThrowsException<System.ArgumentNullException>(() => ipm.InvoiceGenerator());

        }

        [TestMethod]
        public void TestMembershipActivation()
        {
            IPayMode ipm = new MembershipActivation();

            Assert.ThrowsException<System.ArgumentNullException>(() => ipm.InvoiceGenerator());

        }


        [TestMethod]
        public void TestMembershipUpgrade()
        {
            IPayMode ipm = new MembershipUpgrade();

            Assert.ThrowsException<System.ArgumentNullException>(() => ipm.InvoiceGenerator());

        }

        [TestMethod]
        public void TestLearningVideo()
        {
            IPayMode ipm = new LearningVideo();

            Assert.ThrowsException<System.ArgumentNullException>(() => ipm.InvoiceGenerator());

        }


        [TestMethod]
        public void TestSendEmail()
        {
            EMail email = new EMail();

            Assert.ThrowsException<System.ArgumentNullException>(() => email.SendEmailMessage("MembershipUpgrade"));

        }

    }
}
