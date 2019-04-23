using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class DeviceInfo
    {
        public string DevLabel { get; set; }
        public string TypeName { get; set; }
        public string AddrName { get; set; }
        public long UniqueID { get; set; }
        public int RegisterNum { get; set; }
        public int TypeID { get; set; }
        public long AddrID { get; set; }
        public long AddrTypeID { get; set; }
        public int VZero { get; set; }
        public int SZero { get; set; }
        public int VOne { get; set; }
        public int SOne { get; set; }
        public int VTwo { get; set; }
        public int STwo { get; set; }
        public decimal UAlarm { get; set; }
        public decimal UCut { get; set; }
        public decimal UAlarmRer { get; set; }
        public decimal UCutRer { get; set; }
        public decimal UWring { get; set; }
        public decimal DAlarm { get; set; }
        public decimal DCut { get; set; }
        public decimal DAlarmRer { get; set; }
        public decimal DCutRer { get; set; }
        public decimal DWring { get; set; }
        public long FBUniqueID { get; set; }
        public string CutArea { get; set; }
        public DateTime DefTime { get; set; }
        public DateTime ModTime { get; set; }
        public int Status { get; set; }
        public DateTime DeleteTime { get; set; }
        public string SpecialDes { get; set; }
        public long CalRelationID { get; set; }
        public int DataFlag { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Row_GUID { get; set; }
    }
}
