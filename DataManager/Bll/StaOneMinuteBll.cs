using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class StaOneMinuteBll
    {
        public static List<StaOneMinute> QueryList(string datestring, string where = "")
        {
            return EntityHelper.DataTableToList<StaOneMinute>(StaOneMinuteDal.Query(datestring, where));
        }

        public static DataTable Query(string datestring, string where = "")
        {
            return StaOneMinuteDal.Query(datestring, where);
        }

        public static StaOneMinute Get(string datestring, string id)
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

        public static bool Add(string datestring, StaOneMinute staOneMinute)
        {
            return StaOneMinuteDal.Add(datestring, staOneMinute);
        }

        public static bool Edit(string datestring, StaOneMinute staOneMinute)
        {
            return StaOneMinuteDal.Edit(datestring, staOneMinute);
        }

        public static bool Delete(string datestring, string id)
        {
            return StaOneMinuteDal.Delete(datestring, id);
        }
    }
}
