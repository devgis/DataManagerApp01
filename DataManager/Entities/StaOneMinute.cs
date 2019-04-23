using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class StaOneMinute
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

        public DateTime StaTime
        {
            get;
            set;
        }

        public double MaxValue
        {
            get;
            set;
        }

        public DateTime MaxVTime
        {
            get;
            set;
        }

        public double MinValue
        {
            get;
            set;
        }

        public DateTime MinVTime
        {
            get;
            set;
        }

        public double AvgValue
        {
            get;
            set;
        }

        public int StatID
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
