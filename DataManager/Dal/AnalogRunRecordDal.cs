using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class AnalogRunRecordDal
    {
        public static DataTable Query(string datestring, string where = "")
        {
            string sql = string.Format("SELECT s.*,a.AddrName,ds.StatName FROM AnalogRunRecord{0} s left join DeviceInfo d on s.UniqueID=d.UniqueID left join Address a on d.AddrID=a.AddrID left join DeviceStatus ds on s.StatusID=ds.StatID", datestring);
            if (!string.IsNullOrEmpty(where))
            {
                sql += " where (" + where + ")";
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(string datestring, AnalogRunRecord analogRunRecord)
        {
            string sql = string.Format("insert into AnalogRunRecord{0}(ID,UniqueID,StatusID,SValue,STime,DataFlag,LastUpdateTime", datestring)
                + ")VALUES("
                + "@ID,@UniqueID,@StatusID,@SValue,@STime,@DataFlag,getdate())";

            return SQLServerHelper.ExecSql(sql, getParamArr(analogRunRecord));
        }

        public static bool Edit(string datestring, AnalogRunRecord analogRunRecord)
        {
            string sql = string.Format("update AnalogRunRecord{0} set UniqueID=@UniqueID,StatusID=@StatusID,SValue=@SValue,STime=@STime,DataFlag=@DataFlag,LastUpdateTime=getdate() where ID=@ID", datestring);

            return SQLServerHelper.ExecSql(sql, getParamArr(analogRunRecord));
        }

        public static bool Delete(string datestring, string id)
        {
            string sql = string.Format("delete from AnalogRunRecord{0} where ID=@ID", datestring);
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("ID",SqlDbType.BigInt)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(AnalogRunRecord analogRunRecord)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@ID",SqlDbType.BigInt),
                new SqlParameter("@UniqueID",SqlDbType.BigInt),
                new SqlParameter("@StatusID",SqlDbType.Int),
                new SqlParameter("@SValue",SqlDbType.Float),
                new SqlParameter("@STime",SqlDbType.DateTime),
                new SqlParameter("@DataFlag",SqlDbType.Int)
            };
            parms[0].Value = analogRunRecord.ID;
            parms[1].Value = analogRunRecord.UniqueID;
            parms[2].Value = analogRunRecord.StatusID;
            parms[3].Value = analogRunRecord.SValue;
            parms[4].Value = analogRunRecord.STime;
            parms[5].Value = analogRunRecord.DataFlag;
            return parms;
        }
    }
}
