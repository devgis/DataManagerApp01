using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class DeviceInfoDal
    {
        public static DataTable Query(string where = "")
        {
            string sql = "select d.*,a.AddrName,t.TypeName from DeviceInfo d left join Address a on d.AddrID=a.AddrID left join DeviceType t on d.TypeID=t.TypeID";
            if (!string.IsNullOrEmpty(where))
            {
                sql += " where Status<>0 and (" + where+")";
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(DeviceInfo deviceInfo)
        {
            string sql = "insert into DeviceInfo(DevLabel,UniqueID,RegisterNum,TypeID,AddrID,AddrTypeID,VZero,SZero,VOne,SOne,VTwo,STwo,UAlarm,UCut,UAlarmRer,UCutRer,UWring,DAlarm,DCut,DAlarmRer,DCutRer,DWring,FBUniqueID,DefTime,Status,SpecialDes,CalRelationID,DataFlag,LastUpdateTime,CutArea,ModTime,Row_GUID"
                + ")VALUES("
                + "@DevLabel,@UniqueID,@RegisterNum,@TypeID,@AddrID,@AddrTypeID,@VZero,@SZero,@VOne,@SOne,@VTwo,@STwo,@UAlarm,@UCut,@UAlarmRer,@UCutRer,@UWring,@DAlarm,@DCut,@DAlarmRer,@DCutRer,@DWring,@FBUniqueID,getdate(),@Status,@SpecialDes,@CalRelationID,1,getdate(),@CutArea,getdate(),@Row_GUID)";
            
            return SQLServerHelper.ExecSql(sql, getParamArr(deviceInfo));
        }

        public static bool Edit(DeviceInfo deviceInfo)
        {
            string sql = "update DeviceInfo set DevLabel=@DevLabel,UniqueID=@UniqueID,RegisterNum=@RegisterNum,TypeID=@TypeID,AddrID=@AddrID,AddrTypeID=@AddrTypeID,VZero=@VZero,SZero=@SZero,VOne=@VOne,SOne=@SOne,VTwo=@VTwo,STwo=@STwo,UAlarm=@UAlarm,UCut=@UCut,UAlarmRer=@UAlarmRer,CutArea=@CutArea,UCutRer=@UCutRer,UWring=@UWring,DAlarm=@DAlarm,DCut=@DCut,DAlarmRer=@DAlarmRer,DCutRer=@DCutRer,DWring=@DWring,FBUniqueID=@FBUniqueID,ModTime=getdate(),Status=@Status,SpecialDes=@SpecialDes,CalRelationID=@CalRelationID,LastUpdateTime=getdate() where Row_GUID=@Row_GUID";
            
            return SQLServerHelper.ExecSql(sql, getParamArr(deviceInfo));
        }

        public static bool Delete(string id)
        {
            //string sql = "delete from DeviceInfo where Row_GUID=@Row_GUID";
            string sql = "update DeviceInfo set DeleteTime=getdate(),Status=0 where Row_GUID=@Row_GUID";
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("Row_GUID",SqlDbType.VarChar)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(DeviceInfo deviceInfo)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@DevLabel",SqlDbType.VarChar),
                new SqlParameter("@UniqueID",SqlDbType.VarChar),
                new SqlParameter("@RegisterNum",SqlDbType.VarChar),
                new SqlParameter("@TypeID",SqlDbType.VarChar),
                new SqlParameter("@AddrID",SqlDbType.VarChar),
                new SqlParameter("@AddrTypeID",SqlDbType.VarChar),
                new SqlParameter("@VZero",SqlDbType.VarChar),
                new SqlParameter("@SZero",SqlDbType.VarChar),
                new SqlParameter("@VOne",SqlDbType.VarChar),
                new SqlParameter("@SOne",SqlDbType.VarChar),
                new SqlParameter("@VTwo",SqlDbType.VarChar),
                new SqlParameter("@STwo",SqlDbType.VarChar),
                new SqlParameter("@UAlarm",SqlDbType.VarChar),
                new SqlParameter("@UCut",SqlDbType.VarChar),
                new SqlParameter("@UAlarmRer",SqlDbType.VarChar),
                new SqlParameter("@UCutRer",SqlDbType.VarChar),
                new SqlParameter("@UWring",SqlDbType.VarChar),
                new SqlParameter("@DAlarm",SqlDbType.VarChar),
                new SqlParameter("@DCut",SqlDbType.VarChar),
                new SqlParameter("@DAlarmRer",SqlDbType.VarChar),
                new SqlParameter("@DCutRer",SqlDbType.VarChar),
                new SqlParameter("@DWring",SqlDbType.VarChar),
                new SqlParameter("@FBUniqueID",SqlDbType.VarChar),
                new SqlParameter("@CutArea",SqlDbType.VarChar),
                new SqlParameter("@DefTime",SqlDbType.VarChar),
                new SqlParameter("@ModTime",SqlDbType.VarChar),
                new SqlParameter("@Status",SqlDbType.VarChar),
                new SqlParameter("@DeleteTime",SqlDbType.VarChar),
                new SqlParameter("@SpecialDes",SqlDbType.VarChar),
                new SqlParameter("@CalRelationID",SqlDbType.VarChar),
                new SqlParameter("@DataFlag",SqlDbType.VarChar),
                new SqlParameter("@LastUpdateTime",SqlDbType.VarChar),
                new SqlParameter("@Row_GUID",SqlDbType.VarChar)
            };
            parms[0].Value = deviceInfo.DevLabel;
            parms[1].Value = deviceInfo.UniqueID;
            parms[2].Value = deviceInfo.RegisterNum;
            parms[3].Value = deviceInfo.TypeID;
            parms[4].Value = deviceInfo.AddrID;
            parms[5].Value = deviceInfo.AddrTypeID;
            parms[6].Value = deviceInfo.VZero;
            parms[7].Value = deviceInfo.SZero;
            parms[8].Value = deviceInfo.VOne;
            parms[9].Value = deviceInfo.SOne;
            parms[10].Value = deviceInfo.VTwo;
            parms[11].Value = deviceInfo.STwo;
            parms[12].Value = deviceInfo.UAlarm;
            parms[13].Value = deviceInfo.UCut;
            parms[14].Value = deviceInfo.UAlarmRer;
            parms[15].Value = deviceInfo.UCutRer;
            parms[16].Value = deviceInfo.UWring;
            parms[17].Value = deviceInfo.DAlarm;
            parms[18].Value = deviceInfo.DCut;
            parms[19].Value = deviceInfo.DAlarmRer;
            parms[20].Value = deviceInfo.DCutRer;
            parms[21].Value = deviceInfo.DWring;
            parms[22].Value = deviceInfo.FBUniqueID;
            parms[23].Value = deviceInfo.CutArea;
            parms[24].Value = deviceInfo.DefTime;
            parms[25].Value = deviceInfo.ModTime;
            parms[26].Value = deviceInfo.Status;
            parms[27].Value = deviceInfo.DeleteTime;
            parms[28].Value = deviceInfo.SpecialDes;
            parms[29].Value = deviceInfo.CalRelationID;
            parms[30].Value = deviceInfo.DataFlag;
            parms[31].Value = deviceInfo.LastUpdateTime;
            parms[32].Value = deviceInfo.Row_GUID;

            return parms;
        }
    }
}
