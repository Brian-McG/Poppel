using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel.Report
{
    public class Report
    {
        protected String id;
        protected String createdBy;
        protected DateTime date;
        protected String title;
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
        #region Properties
        public String ID
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

        public String CreatedBy
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

        public DateTime Date
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

        public String Title
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
    }
}
