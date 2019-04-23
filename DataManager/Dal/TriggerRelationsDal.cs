using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class TriggerRelationsDal
    {
        public static DataTable Query(string datestring, string where = "")
        {
            string sql = string.Format("SELECT s.*,a.AddrName FROM TriggerRelations{0} s left join DeviceInfo d on s.UniqueID=d.UniqueID left join Address a on d.AddrID=a.AddrID", datestring);
            if (!string.IsNullOrEmpty(where))
            {
                sql += " where (" + where + ")";
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(string datestring, TriggerRelations triggerRelations)
        {
            string sql = string.Format("insert into TriggerRelations{0}(RelaID,FBID,UniqueID,SEID,DataFlag,LastUpdateTime,Row_GUID", datestring)
                + ")VALUES("
                + "@RelaID,@FBID,@UniqueID,@SEID,@DataFlag,getdate(),@Row_GUID)";

            return SQLServerHelper.ExecSql(sql, getParamArr(triggerRelations));
        }

        public static bool Edit(string datestring, TriggerRelations triggerRelations)
        {
            string sql = string.Format("update TriggerRelations{0} set RelaID=@RelaID,FBID=@FBID,UniqueID=@UniqueID,SEID=@SEID,DataFlag=@DataFlag,LastUpdateTime=getdate() where Row_GUID=@Row_GUID", datestring);

            return SQLServerHelper.ExecSql(sql, getParamArr(triggerRelations));
        }

        public static bool Delete(string datestring, string id)
        {
            string sql = string.Format("delete from TriggerRelations{0} where Row_GUID=@Row_GUID", datestring);
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("Row_GUID",SqlDbType.VarChar)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(TriggerRelations triggerRelations)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@RelaID",SqlDbType.BigInt),
                new SqlParameter("@FBID",SqlDbType.BigInt),
                new SqlParameter("@UniqueID",SqlDbType.BigInt),
                new SqlParameter("@SEID",SqlDbType.BigInt),
                new SqlParameter("@DataFlag",SqlDbType.Int),
                new SqlParameter("@Row_GUID",SqlDbType.VarChar)
            };
            parms[0].Value = triggerRelations.RelaID;
            parms[1].Value = triggerRelations.FBID;
            parms[2].Value = triggerRelations.UniqueID;
            parms[3].Value = triggerRelations.SEID;
            parms[4].Value = triggerRelations.DataFlag;
            parms[5].Value = triggerRelations.Row_GUID;
            return parms;
        }
    }
}
