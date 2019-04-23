using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class SwitchStatusRecordDal
    {
        public static DataTable Query(string datestring, string where = "")
        {
            string sql = string.Format("SELECT s.*,a.AddrName,ds.StatName FROM SwitchStatusRecord{0} s left join DeviceInfo d on s.UniqueID=d.UniqueID left join Address a on d.AddrID=a.AddrID left join DeviceStatus ds on s.StatID=ds.StatID", datestring);
            if (!string.IsNullOrEmpty(where))
            {
                sql += " where (" + where + ")";
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(string datestring, SwitchStatusRecord switchStatusRecord)
        {
            string sql = string.Format("insert into SwitchStatusRecord{0}(ID,UniqueID,CauseRecID,StatID,BTime,ETime,DataFlag,LastUpdateTime,Row_GUID", datestring)
                + ")VALUES("
                + "@ID,@UniqueID,@CauseRecID,@StatID,@BTime,@ETime,@DataFlag,getdate(),@Row_GUID)";

            return SQLServerHelper.ExecSql(sql, getParamArr(switchStatusRecord));
        }

        public static bool Edit(string datestring, SwitchStatusRecord switchStatusRecord)
        {
            string sql = string.Format("update SwitchStatusRecord{0} set ID=@ID,UniqueID=@UniqueID,CauseRecID=@CauseRecID,StatID=@StatID,BTime=@BTime,ETime=@ETime,DataFlag=@DataFlag,LastUpdateTime=getdate() where Row_GUID=@Row_GUID", datestring);

            return SQLServerHelper.ExecSql(sql, getParamArr(switchStatusRecord));
        }

        public static bool Delete(string datestring, string id)
        {
            string sql = string.Format("delete from SwitchStatusRecord{0} where Row_GUID=@Row_GUID", datestring);
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("Row_GUID",SqlDbType.VarChar)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(SwitchStatusRecord switchStatusRecord)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@ID",SqlDbType.BigInt),
                new SqlParameter("@UniqueID",SqlDbType.BigInt),
                new SqlParameter("@CauseRecID",SqlDbType.Int),
                new SqlParameter("@StatID",SqlDbType.Int),
                new SqlParameter("@BTime",SqlDbType.DateTime),
                new SqlParameter("@ETime",SqlDbType.DateTime),
                new SqlParameter("@DataFlag",SqlDbType.Int),
                new SqlParameter("@Row_GUID",SqlDbType.VarChar)
            };
            parms[0].Value = switchStatusRecord.ID;
            parms[1].Value = switchStatusRecord.UniqueID;
            parms[2].Value = switchStatusRecord.CauseRecID;
            parms[3].Value = switchStatusRecord.StatID;
            parms[4].Value = switchStatusRecord.BTime;
            parms[5].Value = switchStatusRecord.ETime;
            parms[6].Value = switchStatusRecord.DataFlag;
            parms[7].Value = switchStatusRecord.Row_GUID;
            return parms;
        }
    }
}
