using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class DeviceTypeBll
    {
        public static List<DeviceType> QueryList(string where = "")
        {
            return EntityHelper.DataTableToList<DeviceType>(DeviceTypeDal.Query(where));
        }
        public static DataTable Query(string where = "")
        {
            return DeviceTypeDal.Query(where);
        }

        public static DeviceType Get(string id)
        {
            var list = QueryList(string.Format("Row_GUID='{0}'", id));
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static bool Add(DeviceType deviceType)
        {
            return DeviceTypeDal.Add(deviceType);
        }

        public static bool Edit(DeviceType deviceType)
        {
            return DeviceTypeDal.Edit(deviceType);
        }

        public static bool Delete(string id)
        {
            return DeviceTypeDal.Delete(id);
        }
    }
}
