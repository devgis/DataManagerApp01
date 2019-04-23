using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class AnalogRunRecord
    {
        public long ID
        {
            get;
            set;
        }

        public long UniqueID
        {
            get;
            set;
        }

        public int StatusID
        {
            get;
            set;
        }

        public double SValue
        {
            get;
            set;
        }

        public DateTime STime
        {
            get;
            set;
        }

        public int DataFlag
        {
            get;
            set;
        }

        public DateTime LastUpdateTime
        {
            get;
            set;
        }
    }
}
