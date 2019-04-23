using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class DeviceStatusBll
    {
        public static List<DeviceStatus> QueryList(string where = "")
        {
            return EntityHelper.DataTableToList<DeviceStatus>(DeviceStatusDal.Query(where));
        }
        public static DataTable Query(string where = "")
        {
            return DeviceStatusDal.Query(where);
        }

        public static DeviceStatus Get(string id)
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

        public static bool Add(DeviceStatus deviceStatus)
        {
            return DeviceStatusDal.Add(deviceStatus);
        }

        public static bool Edit(DeviceStatus deviceStatus)
        {
            return DeviceStatusDal.Edit(deviceStatus);
        }

        public static bool Delete(string id)
        {
            return DeviceStatusDal.Delete(id);
        }
    }
}
