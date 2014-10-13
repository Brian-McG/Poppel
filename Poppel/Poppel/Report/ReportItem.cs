using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel.Report
{
    public class ReportItem
    {

        public int productID{
            get{
                return productID;
            }
            set{
                productID=value;
            }
        }
        public ReportItem(){
            productID=0;
        }
    }
}
