using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class DeviceStatusDal
    {
        public static DataTable Query(string where = "")
        {
            string sql = "select * from DeviceStatus where DataFlag=1";
            if (!string.IsNullOrEmpty(where))
            {
                sql += " and (" + where+")";
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(DeviceStatus deviceStatus)
        {
            string sql = "insert into DeviceStatus(StatID,StatName,PartOf,IsSys,IsCut,ImageUrl,IsShowImage,Describe,OrderNum,DataFlag,DefTime,Row_GUID"
                + ")VALUES("
                + "@StatID,@StatName,@PartOf,@IsSys,@IsCut,@ImageUrl,@IsShowImage,@Describe,@OrderNum,1,getdate(),@Row_GUID)";

            return SQLServerHelper.ExecSql(sql, getParamArr(deviceStatus));
        }

        public static bool Edit(DeviceStatus deviceStatus)
        {
            string sql = "update DeviceStatus set StatID=@StatID,StatName=@StatName,PartOf=@PartOf,IsSys=@IsSys,IsCut=@IsCut,ImageUrl=@ImageUrl,IsShowImage=@IsShowImage,Describe=@Describe,OrderNum=@OrderNum,LastUpdateTime=getdate() where Row_GUID=@Row_GUID";

            return SQLServerHelper.ExecSql(sql, getParamArr(deviceStatus));
        }

        public static bool Delete(string id)
        {
            string sql = "update DeviceStatus set DataFlag=0,DelTime=getdate() where Row_GUID=@Row_GUID";
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("Row_GUID",SqlDbType.VarChar)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(DeviceStatus deviceStatus)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@StatID",SqlDbType.VarChar),
                new SqlParameter("@StatName",SqlDbType.VarChar),
                new SqlParameter("@PartOf",SqlDbType.VarChar),
                new SqlParameter("@IsSys",SqlDbType.VarChar),
                new SqlParameter("@IsCut",SqlDbType.VarChar),
                new SqlParameter("@ImageUrl",SqlDbType.VarChar),
                new SqlParameter("@IsShowImage",SqlDbType.VarChar),
                new SqlParameter("@Describe",SqlDbType.VarChar),
                new SqlParameter("@OrderNum",SqlDbType.VarChar),
                new SqlParameter("@DefTime",SqlDbType.VarChar),
                new SqlParameter("@DelTime",SqlDbType.VarChar),
                new SqlParameter("@DataFlag",SqlDbType.VarChar),
                new SqlParameter("@LastUpdateTime",SqlDbType.VarChar),
                new SqlParameter("@Row_GUID",SqlDbType.VarChar)
            };
            parms[0].Value = deviceStatus.StatID;
            parms[1].Value = deviceStatus.StatName;
            parms[2].Value = deviceStatus.PartOf;
            parms[3].Value = deviceStatus.IsSys;
            parms[4].Value = deviceStatus.IsCut;
            parms[5].Value = deviceStatus.ImageUrl;
            parms[6].Value = deviceStatus.IsShowImage;
            parms[7].Value = deviceStatus.Describe;
            parms[8].Value = deviceStatus.OrderNum;
            parms[9].Value = deviceStatus.DefTime;
            parms[10].Value = deviceStatus.DelTime;
            parms[11].Value = deviceStatus.DataFlag;
            parms[12].Value = deviceStatus.LastUpdateTime;
            parms[13].Value = deviceStatus.Row_GUID;
            return parms;
        }
    }
}
