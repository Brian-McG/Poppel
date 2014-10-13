using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Order;
using System.Collections.ObjectModel;
using Poppel.Database;

namespace Poppel.Report
{
    public class ExpiredProductReport : Report
    {
        #region Properties
        public Collection<StockItem> expiredProducts
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
        public ExpiredProductReport(): base()
        {
            expiredProducts = new Collection<StockItem>();
        }

        public Collection<StockItem> getStock()
        {
            String date = "";
            PoppelDatabase pd = new PoppelDatabase();
            date = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
           //Brian: Use 
            // this.expiredProducts=pd.readStock(date);
            return expiredProducts;
        }
    }
}
