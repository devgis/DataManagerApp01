using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class DeviceTypeDal
    {
        public static DataTable Query(string where = "")
        {
            string sql = "select * from DeviceType where IsUse=1";
            if (!string.IsNullOrEmpty(where))
            {
                sql += " and (" + where+")";
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(DeviceType deviceType)
        {
            string sql = "insert into DeviceType(TypeID,TypeName,ShowName,Describe,IsAnalog,Unit,Format,Range,IsActual,IsSystem,DepthLevel,TopoCode,IsUse,OrderNum,IconFile,DefTime,DataFlag,LastUpdateTime,Row_GUID"
                + ")VALUES("
                + "@TypeID,@TypeName,@ShowName,@Describe,@IsAnalog,@Unit,@Format,@Range,@IsActual,@IsSystem,@DepthLevel,@TopoCode,1,@OrderNum,@IconFile,getdate(),1,getdate(),@Row_GUID)";

            return SQLServerHelper.ExecSql(sql, getParamArr(deviceType));
        }

        public static bool Edit(DeviceType deviceType)
        {
            string sql = "update DeviceType set TypeID=@TypeID,TypeName=@TypeName,ShowName=@ShowName,Describe=@Describe,IsAnalog=@IsAnalog,Unit=@Unit,Format=@Format,Range=@Range,IsActual=@IsActual,IsSystem=@IsSystem,DepthLevel=@DepthLevel,TopoCode=@TopoCode,OrderNum=@OrderNum,IconFile=@IconFile,LastUpdateTime=getdate() where Row_GUID=@Row_GUID";
            return SQLServerHelper.ExecSql(sql, getParamArr(deviceType));
        }

        public static bool Delete(string id)
        {
            string sql = "update DeviceType set StopUseTime=getdate(),IsUse=0 where Row_GUID=@Row_GUID";
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("Row_GUID",SqlDbType.VarChar)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(DeviceType deviceType)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@TypeID",SqlDbType.VarChar),
                new SqlParameter("@TypeName",SqlDbType.VarChar),
                new SqlParameter("@ShowName",SqlDbType.VarChar),
                new SqlParameter("@Describe",SqlDbType.VarChar),
                new SqlParameter("@IsAnalog",SqlDbType.VarChar),
                new SqlParameter("@Unit",SqlDbType.VarChar),
                new SqlParameter("@Format",SqlDbType.VarChar),
                new SqlParameter("@Range",SqlDbType.VarChar),
                new SqlParameter("@IsActual",SqlDbType.VarChar),
                new SqlParameter("@IsSystem",SqlDbType.VarChar),
                new SqlParameter("@DepthLevel",SqlDbType.VarChar),
                new SqlParameter("@TopoCode",SqlDbType.VarChar),
                new SqlParameter("@IsUse",SqlDbType.VarChar),
                new SqlParameter("@OrderNum",SqlDbType.VarChar),
                new SqlParameter("@IconFile",SqlDbType.VarChar),
                new SqlParameter("@DefTime",SqlDbType.VarChar),
                new SqlParameter("@StopUseTime",SqlDbType.VarChar),
                new SqlParameter("@DataFlag",SqlDbType.VarChar),
                new SqlParameter("@LastUpdateTime",SqlDbType.VarChar),
                new SqlParameter("@Row_GUID",SqlDbType.VarChar)
            };
            parms[0].Value = deviceType.TypeID;
            parms[1].Value = deviceType.TypeName;
            parms[2].Value = deviceType.ShowName;
            parms[3].Value = deviceType.Describe;
            parms[4].Value = deviceType.IsAnalog;
            parms[5].Value = deviceType.Unit;
            parms[6].Value = deviceType.Format;
            parms[7].Value = deviceType.Range;
            parms[8].Value = deviceType.IsActual;
            parms[9].Value = deviceType.IsSystem;
            parms[10].Value = deviceType.DepthLevel;
            parms[11].Value = deviceType.TopoCode;
            parms[12].Value = deviceType.IsUse;
            parms[13].Value = deviceType.OrderNum;
            parms[14].Value = deviceType.IconFile;
            parms[15].Value = deviceType.DefTime;
            parms[16].Value = deviceType.StopUseTime;
            parms[17].Value = deviceType.DataFlag;
            parms[18].Value = deviceType.LastUpdateTime;
            parms[19].Value = deviceType.Row_GUID;
            return parms;
        }
    }
}
