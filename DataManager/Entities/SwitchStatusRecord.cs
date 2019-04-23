using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class SwitchStatusRecord
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

        public long CauseRecID
        {
            get;
            set;
        }

        public int StatID
        {
            get;
            set;
        }

        public DateTime BTime
        {
            get;
            set;
        }

        public DateTime ETime
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
        public string Row_GUID
        {
            get;
            set;
        }
    }
}
