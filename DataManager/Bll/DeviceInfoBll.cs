using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class DeviceInfoBll
    {
        public static List<DeviceInfo> QueryList(string where = "")
        {
            return EntityHelper.DataTableToList<DeviceInfo>(DeviceInfoDal.Query(where));
        }
        public static DataTable Query(string where = "")
        {
            return DeviceInfoDal.Query(where);
        }

        public static DeviceInfo Get(string id)
        {
            var list = QueryList(string.Format("d.Row_GUID='{0}'", id));
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static bool Add(DeviceInfo deviceInfo)
        {
            return DeviceInfoDal.Add(deviceInfo);
        }

        public static bool Edit(DeviceInfo deviceInfo)
        {
            return DeviceInfoDal.Edit(deviceInfo);
        }

        public static bool Delete(string id)
        {
            return DeviceInfoDal.Delete(id);
        }
    }
}
