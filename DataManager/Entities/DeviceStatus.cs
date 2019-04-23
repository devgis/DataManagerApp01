using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class DeviceStatus
    {
        public int StatID { get; set; }
        public string StatName { get; set; }
        public int PartOf { get; set; }
        public int IsSys { get; set; }
        public int IsCut { get; set; }
        public string ImageUrl { get; set; }
        public int IsShowImage { get; set; }
        public string Describe { get; set; }
        public int OrderNum { get; set; }
        public DateTime DefTime { get; set; }
        public DateTime DelTime { get; set; }
        public int DataFlag { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Row_GUID { get; set; }
    }
}
