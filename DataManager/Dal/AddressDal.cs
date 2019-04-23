using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class AddressDal
    {
        public static DataTable Query(string where = "")
        {
            string sql = "select * from Address where IsUse=1";
            if (!string.IsNullOrEmpty(where))
            {
                sql += " and (" + where+")";
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(Address address)
        {
            string sql = "insert into Address(AddrID,AddrCode,AddrName,Initials,Describe,IsActual,TopoCode,MaxNum,OrderNum,DefTime,IsUse,FPTypeID,DataFlag,LastUpdateTime,Row_GUID"
                + ")VALUES("
                + "(select max(AddrID)+1 from address),@AddrCode,@AddrName,@Initials,@Describe,@IsActual,@TopoCode,@MaxNum,@OrderNum,getdate(),1,@FPTypeID,@DataFlag,getdate(),@Row_GUID)";

            return SQLServerHelper.ExecSql(sql, getParamArr(address));
        }

        public static bool Edit(Address address)
        {
            string sql = "update address set AddrID=@AddrID,AddrCode=@AddrCode,AddrName=@AddrName,Initials=@Initials,Describe=@Describe,IsActual=@IsActual,TopoCode=@TopoCode,MaxNum=@MaxNum,OrderNum=@OrderNum,FPTypeID=@FPTypeID,LastUpdateTime=getdate() where Row_GUID=@Row_GUID";

            return SQLServerHelper.ExecSql(sql, getParamArr(address));
        }

        public static bool Delete(string id)
        {
            string sql = "update address set DelTime=getdate(),IsUse=0 where Row_GUID=@Row_GUID";
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("Row_GUID",SqlDbType.VarChar)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(Address address)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@AddrID",SqlDbType.VarChar),
                new SqlParameter("@AddrCode",SqlDbType.VarChar),
                new SqlParameter("@AddrName",SqlDbType.VarChar),
                new SqlParameter("@Initials",SqlDbType.VarChar),
                new SqlParameter("@Describe",SqlDbType.VarChar),
                new SqlParameter("@IsActual",SqlDbType.VarChar),
                new SqlParameter("@TopoCode",SqlDbType.VarChar),
                new SqlParameter("@MaxNum",SqlDbType.VarChar),
                new SqlParameter("@OrderNum",SqlDbType.VarChar),
                new SqlParameter("@DefTime",SqlDbType.VarChar),
                new SqlParameter("@IsUse",SqlDbType.VarChar),
                new SqlParameter("@DelTime",SqlDbType.VarChar),
                new SqlParameter("@FPTypeID",SqlDbType.VarChar),
                new SqlParameter("@DataFlag",SqlDbType.VarChar),
                new SqlParameter("@LastUpdateTime",SqlDbType.VarChar),
                new SqlParameter("@Row_GUID",SqlDbType.VarChar)
            };
            parms[0].Value = address.AddrID;
            parms[1].Value = address.AddrCode;
            parms[2].Value = address.AddrName;
            parms[3].Value = address.Initials;
            parms[4].Value = address.Describe;
            parms[5].Value = address.IsActual;
            parms[6].Value = address.TopoCode;
            parms[7].Value = address.MaxNum;
            parms[8].Value = address.OrderNum;
            parms[9].Value = address.DefTime;
            parms[10].Value = address.IsUse;
            parms[11].Value = address.DelTime;
            parms[12].Value = address.FPTypeID;
            parms[13].Value = address.DataFlag;
            parms[14].Value = address.LastUpdateTime;
            parms[15].Value = address.Row_GUID;
            return parms;
        }
    }
}
