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
        #region Properties
        private Collection<Product> expiredProducts
        {
            get
            {
                return expiredProducts;
            }
            set
            {
                expiredProducts = value;
            }
        }
        #endregion
        public ExpiredProductReport(Collection<Product> expiredProducts): base()
        {
            this.expiredProducts = expiredProducts;
        }

    
    }
}
