using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class DeviceType
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string ShowName { get; set; }
        public string Describe { get; set; }
        public int IsActual { get; set; }
        public string Unit { get; set; }
        public int Format { get; set; }
        public string Range { get; set; }
        public int IsAnalog { get; set; }
        public int IsSystem { get; set; }
        public int DepthLevel { get; set; }
        public string TopoCode { get; set; }
        public int IsUse { get; set; }
        public int OrderNum { get; set; }
        public string IconFile { get; set; }
        public DateTime DefTime { get; set; }
        public DateTime StopUseTime { get; set; }
        public int DataFlag { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Row_GUID { get; set; }
    }
}
