using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class AddressBll
    {
        public static List<Address> QueryList(string where = "")
        {
            return EntityHelper.DataTableToList<Address>(AddressDal.Query(where));
        }
        public static DataTable Query(string where = "")
        {
            return AddressDal.Query(where);
        }

        public static Address Get(string id)
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

        public static bool Add(Address address)
        {
            return AddressDal.Add(address);
        }

        public static bool Edit(Address address)
        {
            return AddressDal.Edit(address);
        }

        public static bool Delete(string id)
        {
            return AddressDal.Delete(id);
        }
    }
}
