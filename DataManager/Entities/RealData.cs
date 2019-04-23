using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Entities
{
    public class RealData
    {
        public string AddrName { get; set; }
        public string StatName { get; set; }
        public long UniqueID { get; set; }
        public decimal Value { get; set; }
        public DateTime VTime { get; set; }
        public int VStatus { get; set; }
        public DateTime VSOTime { get; set; }
        public DateTime BATime { get; set; }
        public DateTime EATime { get; set; }
        public double AMaxValue { get; set; }
        public DateTime AMaxTime { get; set; }
        public double AMinValue { get; set; }
        public DateTime AMinTime { get; set; }
        public double AAvgValue { get; set; }
        public int AlarmStatus { get; set; }
        public long AlarmID { get; set; }
        public DateTime BCTime { get; set; }
        public DateTime ECTime { get; set; }
        public double CMaxValue { get; set; }
        public DateTime CMaxTime { get; set; }
        public double CMinValue { get; set; }
        public DateTime CMinTime { get; set; }
        public double CAvgValue { get; set; }
        public int CutStatus { get; set; }
        public long CutID { get; set; }
        public double StaMaxValue { get; set; }
        public double StaMinValue { get; set; }
        public DateTime StaBeginTime { get; set; }
        public DateTime StaEndTime { get; set; }
        public double MaxValue { get; set; }
        public double MaxVPosition { get; set; }
        public double MinValue { get; set; }
        public double MinVPosition { get; set; }
        public double AvgValue { get; set; }
        public int DataFlag { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Row_GUID { get; set; }
    }
}
