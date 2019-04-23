using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class RealDataBll
    {
        public static List<RealData> QueryList(string where = "")
        {
            return EntityHelper.DataTableToList<RealData>(RealDataDal.Query(where));
        }

        public static DataTable Query(string where = "")
        {
            return RealDataDal.Query(where);
        }

        public static RealData Get(string id)
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

        public static bool Add(RealData realData)
        {
            return RealDataDal.Add(realData);
        }

        public static bool Edit(RealData realData)
        {
            return RealDataDal.Edit(realData);
        }

        public static bool Delete(string id)
        {
            return RealDataDal.Delete(id);
        }
    }
}
