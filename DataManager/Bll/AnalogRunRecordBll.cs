using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class AnalogRunRecordBll
    {
        public static List<AnalogRunRecord> QueryList(string datestring, string where = "")
        {
            return EntityHelper.DataTableToList<AnalogRunRecord>(AnalogRunRecordDal.Query(datestring, where));
        }

        public static DataTable Query(string datestring, string where = "")
        {
            return AnalogRunRecordDal.Query(datestring, where);
        }

        public static AnalogRunRecord Get(string datestring, string id)
        {
            var list = QueryList(datestring, string.Format("ID={0}", id));
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static bool Add(string datestring, AnalogRunRecord analogRunRecord)
        {
            return AnalogRunRecordDal.Add(datestring, analogRunRecord);
        }

        public static bool Edit(string datestring, AnalogRunRecord analogRunRecord)
        {
            return AnalogRunRecordDal.Edit(datestring, analogRunRecord);
        }

        public static bool Delete(string datestring, string id)
        {
            return AnalogRunRecordDal.Delete(datestring, id);
        }
    }
}
