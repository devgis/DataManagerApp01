using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class TriggerRelations
    {
        public long RelaID
        {
            get;
            set;
        }

        public long FBID
        {
            get;
            set;
        }

        public long UniqueID
        {
            get;
            set;
        }

        public long SEID
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
