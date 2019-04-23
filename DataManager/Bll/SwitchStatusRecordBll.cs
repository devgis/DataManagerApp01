using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class SwitchStatusRecordBll
    {
        public static List<SwitchStatusRecord> QueryList(string datestring, string where = "")
        {
            return EntityHelper.DataTableToList<SwitchStatusRecord>(SwitchStatusRecordDal.Query(datestring, where));
        }

        public static DataTable Query(string datestring, string where = "")
        {
            return SwitchStatusRecordDal.Query(datestring, where);
        }

        public static SwitchStatusRecord Get(string datestring, string id)
        {
            var list = QueryList(datestring, string.Format("s.Row_GUID='{0}'", id));
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static bool Add(string datestring, SwitchStatusRecord switchStatusRecord)
        {
            return SwitchStatusRecordDal.Add(datestring, switchStatusRecord);
        }

        public static bool Edit(string datestring, SwitchStatusRecord switchStatusRecord)
        {
            return SwitchStatusRecordDal.Edit(datestring, switchStatusRecord);
        }

        public static bool Delete(string datestring, string id)
        {
            return SwitchStatusRecordDal.Delete(datestring, id);
        }
    }
}
