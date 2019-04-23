using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class Address
    {
        public long AddrID { get; set; }
        public string AddrCode { get; set; }
        public string AddrName { get; set; }
        public string Initials { get; set; }
        public string Describe { get; set; }
        public int IsActual { get; set; }
        public string TopoCode { get; set; }
        public int MaxNum { get; set; }
        public int OrderNum { get; set; }
        public DateTime DefTime { get; set; }
        public int IsUse { get; set; }
        public DateTime DelTime { get; set; }
        public int FPTypeID { get; set; }
        public int DataFlag { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Row_GUID { get; set; }
    }
}
