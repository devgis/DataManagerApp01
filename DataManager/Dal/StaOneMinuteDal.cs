using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class StaOneMinuteDal
    {
        public static DataTable Query(string datestring,string where = "")
        {
            string sql = string.Format("SELECT s.*,a.AddrName,ds.StatName FROM StaOneMinute{0} s left join DeviceInfo d on s.UniqueID=d.UniqueID left join Address a on d.AddrID=a.AddrID left join DeviceStatus ds on s.StatID=ds.StatID", datestring);
            if (!string.IsNullOrEmpty(where))
            {
                sql += " where (" + where + ")";
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(string datestring, StaOneMinute staOneMinute)
        {
            string sql = string.Format("insert into StaOneMinute{0}(ID,UniqueID,StaTime,MaxValue,MaxVTime,MinValue,MinVTime,AvgValue,StatID,DataFlag,LastUpdateTime", datestring)
                + ")VALUES("
                + "@ID,@UniqueID,@StaTime,@MaxValue,@MaxVTime,@MinValue,@MinVTime,@AvgValue,@StatID,@DataFlag,getdate())";

            return SQLServerHelper.ExecSql(sql, getParamArr(staOneMinute));
        }

        public static bool Edit(string datestring, StaOneMinute staOneMinute)
        {
            string sql = string.Format("update StaOneMinute{0} set UniqueID=@UniqueID,StaTime=@StaTime,MaxValue=@MaxValue,MaxVTime=@MaxVTime,MinValue=@MinValue,MinVTime=@MinVTime,AvgValue=@AvgValue,StatID=@StatID,DataFlag=@DataFlag,LastUpdateTime=getdate() where ID=@ID", datestring); 

            return SQLServerHelper.ExecSql(sql, getParamArr(staOneMinute));
        }

        public static bool Delete(string datestring, string id)
        {
            string sql = string.Format("delete from StaOneMinute{0} where ID=@ID", datestring);
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("ID",SqlDbType.BigInt)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(StaOneMinute staOneMinute)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@ID",SqlDbType.BigInt),
                new SqlParameter("@UniqueID",SqlDbType.BigInt),
                new SqlParameter("@StaTime",SqlDbType.DateTime),
                new SqlParameter("@MaxValue",SqlDbType.Float),
                new SqlParameter("@MaxVTime",SqlDbType.DateTime),
                new SqlParameter("@MinValue",SqlDbType.Float),
                new SqlParameter("@MinVTime",SqlDbType.DateTime),
                new SqlParameter("@AvgValue",SqlDbType.Float),
                new SqlParameter("@StatID",SqlDbType.Int),
                new SqlParameter("@DataFlag",SqlDbType.Int)
            };
            parms[0].Value = staOneMinute.ID;
            parms[1].Value = staOneMinute.UniqueID;
            parms[2].Value = staOneMinute.StaTime;
            parms[3].Value = staOneMinute.MaxValue;
            parms[4].Value = staOneMinute.MaxVTime;
            parms[5].Value = staOneMinute.MinValue;
            parms[6].Value = staOneMinute.MinVTime;
            parms[7].Value = staOneMinute.AvgValue;
            parms[8].Value = staOneMinute.StatID;
            parms[9].Value = staOneMinute.DataFlag;
            return parms;
        }
    }
}
