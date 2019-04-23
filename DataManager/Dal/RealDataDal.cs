using DataManager.Common;
using DataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManager.Dal
{
    public class RealDataDal
    {
        public static DataTable Query(string where = "")
        {
            string sql = "SELECT r.*,a.AddrName,s.StatName FROM RealData r left join DeviceInfo d on r.UniqueID=d.UniqueID left join Address a on d.AddrID=a.AddrID left join DeviceStatus s on r.VStatus=s.StatID";
            if (!string.IsNullOrEmpty(where))
            {
                sql += " where " + where;
            }
            return SQLServerHelper.GetDataTable(sql);
        }

        public static bool Add(RealData realData)
        {
            //string sql = "insert into RealData(UniqueID,Value,VTime,VStatus,VSOTime,BATime,EATime,AMaxValue,AMaxTime,AMinValue,AMinTime,AAvgValue,AlarmStatus,AlarmID,BCTime,ECTime,CMaxValue,CMaxTime,CMinValue,CMinTime,CAvgValue,CutStatus,CutID,StaMaxValue,StaMinValue,StaBeginTime,StaEndTime,MaxValue,MaxVPosition,MinValue,MinVPosition,AvgValue,DataFlag,LastUpdateTime,Row_GUID"
            //    + ")VALUES("
            //    + "@UniqueID,@Value,@VTime,@VStatus,@VSOTime,@BATime,@EATime,@AMaxValue,@AMaxTime,@AMinValue,@AMinTime,@AAvgValue,@AlarmStatus,@AlarmID,@BCTime,@ECTime,@CMaxValue,@CMaxTime,@CMinValue,@CMinTime,@CAvgValue,@CutStatus,@CutID,@StaMaxValue,@StaMinValue,@StaBeginTime,@StaEndTime,@MaxValue,@MaxVPosition,@MinValue,@MinVPosition,@AvgValue,@DataFlag,@LastUpdateTime,@Row_GUID)";
            string sql = "insert into RealData(UniqueID,Value,VStatus,VTime,VSOTime,AMaxValue,AMinValue,AAvgValue,AlarmStatus,AlarmID,CMaxValue,CMinValue,CAvgValue,CutStatus,CutID,StaMaxValue,StaMinValue,MaxValue,MaxVPosition,MinValue,MinVPosition,AvgValue,DataFlag,LastUpdateTime,Row_GUID"
                + ")VALUES("
                + "@UniqueID,@Value,@VStatus,getdate(),getdate(),@AMaxValue,@AMinValue,@AAvgValue,@AlarmStatus,@AlarmID,@CMaxValue,@CMinValue,@CAvgValue,@CutStatus,@CutID,@StaMaxValue,@StaMinValue,@MaxValue,@MaxVPosition,@MinValue,@MinVPosition,@AvgValue,1,getdate(),@Row_GUID)";
            return SQLServerHelper.ExecSql(sql, getParamArr(realData));
        }

        public static bool Edit(RealData realData)
        {
            //string sql = "update RealData set UniqueID=@UniqueID,Value=@Value,VTime=@VTime,VStatus=@VStatus,VSOTime=@VSOTime,BATime=@BATime,AMaxValue=@EATime,AMaxValue=@AMaxValue,AMaxTime=@AMaxTime,AMinValue=@AMinValue,AMinTime=@AMinTime,AAvgValue=@AAvgValue,AlarmStatus=@AlarmStatus,AlarmID=@AlarmID,BCTime=@BCTime,ECTime=@ECTime,CMaxValue=@CMaxValue,CMaxTime=@CMaxTime,CMinValue=@CMinValue,CMinTime=@CMinTime,CAvgValue=@CAvgValue,CutStatus=@CutStatus,CutID=@CutID,StaMaxValue=@StaMaxValue,StaMinValue=@StaMinValue,StaBeginTime=@StaBeginTime,StaEndTime=@StaEndTime,MaxValue=@MaxValue,MaxVPosition=@MaxVPosition,MinValue=@MinValue,MinVPosition=@MinVPosition,AvgValue=@AvgValue,DataFlag=@DataFlag,LastUpdateTime=@LastUpdateTime where Row_GUID=@Row_GUID";
            string sql = "update RealData set UniqueID=@UniqueID,Value=@Value,VStatus=@VStatus,VTime=getdate(),VSOTime=getdate(),AMaxValue=@AMaxValue,AMinValue=@AMinValue,AAvgValue=@AAvgValue,AlarmStatus=@AlarmStatus,AlarmID=@AlarmID,CMaxValue=@CMaxValue,CMinValue=@CMinValue,CAvgValue=@CAvgValue,CutStatus=@CutStatus,CutID=@CutID,StaMaxValue=@StaMaxValue,StaMinValue=@StaMinValue,MaxValue=@MaxValue,MaxVPosition=@MaxVPosition,MinValue=@MinValue,MinVPosition=@MinVPosition,AvgValue=@AvgValue,DataFlag=@DataFlag,LastUpdateTime=getdate() where Row_GUID=@Row_GUID";
            return SQLServerHelper.ExecSql(sql, getParamArr(realData));
        }

        public static bool Delete(string id)
        {
            string sql = "delete from RealData where Row_GUID=@Row_GUID";
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("Row_GUID",SqlDbType.VarChar)
            };

            parms[0].Value = id;
            return SQLServerHelper.ExecSql(sql, parms);
        }

        private static SqlParameter[] getParamArr(RealData realData)
        {
            SqlParameter[] parms = new SqlParameter[] {
                new SqlParameter("@UniqueID",SqlDbType.VarChar),
                new SqlParameter("@Value",SqlDbType.VarChar),
                new SqlParameter("@VTime",SqlDbType.VarChar),
                new SqlParameter("@VStatus",SqlDbType.VarChar),
                new SqlParameter("@VSOTime",SqlDbType.VarChar),
                new SqlParameter("@BATime",SqlDbType.VarChar),
                new SqlParameter("@EATime",SqlDbType.VarChar),
                new SqlParameter("@AMaxValue",SqlDbType.VarChar),
                new SqlParameter("@AMaxTime",SqlDbType.VarChar),
                new SqlParameter("@AMinValue",SqlDbType.VarChar),
                new SqlParameter("@AMinTime",SqlDbType.VarChar),
                new SqlParameter("@AAvgValue",SqlDbType.VarChar),
                new SqlParameter("@AlarmStatus",SqlDbType.VarChar),
                new SqlParameter("@AlarmID",SqlDbType.VarChar),
                new SqlParameter("@BCTime",SqlDbType.VarChar),
                new SqlParameter("@ECTime",SqlDbType.VarChar),
                new SqlParameter("@CMaxValue",SqlDbType.VarChar),
                new SqlParameter("@CMaxTime",SqlDbType.VarChar),
                new SqlParameter("@CMinValue",SqlDbType.VarChar),
                new SqlParameter("@CMinTime",SqlDbType.VarChar),
                new SqlParameter("@CAvgValue",SqlDbType.VarChar),
                new SqlParameter("@CutStatus",SqlDbType.VarChar),
                new SqlParameter("@CutID",SqlDbType.VarChar),
                new SqlParameter("@StaMaxValue",SqlDbType.VarChar),
                new SqlParameter("@StaMinValue",SqlDbType.VarChar),
                new SqlParameter("@StaBeginTime",SqlDbType.VarChar),
                new SqlParameter("@StaEndTime",SqlDbType.VarChar),
                new SqlParameter("@MaxValue",SqlDbType.VarChar),
                new SqlParameter("@MaxVPosition",SqlDbType.VarChar),
                new SqlParameter("@MinValue",SqlDbType.VarChar),
                new SqlParameter("@MinVPosition",SqlDbType.VarChar),
                new SqlParameter("@AvgValue",SqlDbType.VarChar),
                new SqlParameter("@DataFlag",SqlDbType.VarChar),
                new SqlParameter("@LastUpdateTime",SqlDbType.VarChar),
                new SqlParameter("@Row_GUID",SqlDbType.VarChar)
            };
            parms[0].Value = realData.UniqueID;
                parms[1].Value = realData.Value;
                parms[2].Value = realData.VTime;
                parms[3].Value = realData.VStatus;
                parms[4].Value = realData.VSOTime;
                parms[5].Value = realData.BATime;
                parms[6].Value = realData.EATime;
                parms[7].Value = realData.AMaxValue;
                parms[8].Value = realData.AMaxTime;
                parms[9].Value = realData.AMinValue;
                parms[10].Value = realData.AMinTime;
                parms[11].Value = realData.AAvgValue;
                parms[12].Value = realData.AlarmStatus;
                parms[13].Value = realData.AlarmID;
                parms[14].Value = realData.BCTime;
                parms[15].Value = realData.ECTime;
                parms[16].Value = realData.CMaxValue;
                parms[17].Value = realData.CMaxTime;
                parms[18].Value = realData.CMinValue;
                parms[19].Value = realData.CMinTime;
                parms[20].Value = realData.CAvgValue;
                parms[21].Value = realData.CutStatus;
                parms[22].Value = realData.CutID;
                parms[23].Value = realData.StaMaxValue;
                parms[24].Value = realData.StaMinValue;
                parms[25].Value = realData.StaBeginTime;
                parms[26].Value = realData.StaEndTime;
                parms[27].Value = realData.MaxValue;
                parms[28].Value = realData.MaxVPosition;
                parms[29].Value = realData.MinValue;
                parms[30].Value = realData.MinVPosition;
                parms[31].Value = realData.AvgValue;
                parms[32].Value = realData.DataFlag;
                parms[33].Value = realData.LastUpdateTime;
                parms[34].Value = realData.Row_GUID;
            return parms;
        }
    }
}
