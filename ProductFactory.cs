namespace BusinessRulesEngine
{
    /// <summary>
    /// The creator class declares the factory method this is to return an object of various products
    /// </summary>
    public abstract class ProductFactory
    {
        /// <summary>
        /// Abstract method
        /// </summary>
        /// <param name="productNumber">int productNumber</param>
        /// <returns>PaymentMode Type</returns>
        public abstract IPayMode GetInvoiceDetails(int productNumber);
    }
}