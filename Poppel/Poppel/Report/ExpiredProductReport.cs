using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Domain;
using System.Collections.ObjectModel;

namespace Poppel.Report
{
    public class ExpiredProductReport : Report
    {
        private Collection<Product> expiredProducts;
        public ExpiredProductReport(Collection<Product> expiredProducts): base()
        {
            this.expiredProducts = expiredProducts;
        }

        #region Properties
        private Collection<Product> ExpiredProduct
        {
            get
            {
                return expiredProducts;
            }
        }
        #endregion
    }
}
