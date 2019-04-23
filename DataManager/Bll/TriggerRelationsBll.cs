using DataManager.Common;
using DataManager.Dal;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager.Bll
{
    public class TriggerRelationsBll
    {
        public static List<TriggerRelations> QueryList(string datestring, string where = "")
        {
            return EntityHelper.DataTableToList<TriggerRelations>(TriggerRelationsDal.Query(datestring, where));
        }

        public static DataTable Query(string datestring, string where = "")
        {
            return TriggerRelationsDal.Query(datestring, where);
        }

        public static TriggerRelations Get(string datestring, string id)
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

        public static bool Add(string datestring, TriggerRelations triggerRelations)
        {
            return TriggerRelationsDal.Add(datestring, triggerRelations);
        }

        public static bool Edit(string datestring, TriggerRelations triggerRelations)
        {
            return TriggerRelationsDal.Edit(datestring, triggerRelations);
        }

        public static bool Delete(string datestring, string id)
        {
            return TriggerRelationsDal.Delete(datestring, id);
        }
    }
}
