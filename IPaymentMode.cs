using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    /// <summary>
    /// Payment Mode Interface declares the operation that all the concrete Product Types must implement 
    /// </summary>
    public interface IPayMode
    {
        void InvoiceGenerator();
      
    }

}
