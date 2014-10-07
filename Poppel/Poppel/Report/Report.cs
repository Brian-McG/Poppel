using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel.Report
{
    public class Report
    {
        #region Properties
        public String id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public String createdBy
        {
            get
            {
                return createdBy;
            }
            set
            {
                createdBy = value;
            }
        }

        public DateTime date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public String title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        #endregion
        public Report(String createdBy, DateTime date, String title, String ID)
        {
            this.id = ID;
            this.date = date;
            this.createdBy = createdBy;
            this.title = title;
        }

        public Report()
        {
        }
       
    }
}
