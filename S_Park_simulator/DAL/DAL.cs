using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DBUtility;

namespace S_Park_simulator.DAL
{
    public class DAL
    {
        /// <summary>
        /// 获取所有活跃订单
        /// </summary>
        /// <returns></returns>
        public List<ApplyInfo> GetAllInfo(string pid)
        {
            string sqltxt = "Select * From ApplyInfo Where ParkID=@ParkID and State=False";
            SqlParameter para=new SqlParameter("@ParkID",pid);
            List<ApplyInfo> list = new List<ApplyInfo>();
            ApplyInfo apply;
            SqlDataReader reader = SqlHelper.ExecuteReader(
                SqlHelper.ConnectionString,
                CommandType.Text,
                sqltxt,
                para);
            while (reader.Read())
            {
                apply=new ApplyInfo();
                apply.CarNum = reader["CarNum"].ToString();
                apply.HID = (int)reader["HID"];
                apply.ParkID = (int)reader["ParkID"];
                apply.ParkPosintion = reader["ParkPosintion"].ToString();
                apply.State = (bool)reader["State"];
                list.Add(apply);
            }

            return list;
        }

        /// <summary>
        /// 停车场是否存在
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public bool ParkIsTrue(string pid)
        {
            string sqltxt = "Select Count(*) From PartInfo Where ParkID=@ParkID";
            SqlParameter para=new SqlParameter("@ParkID",pid);
            int i = (int)SqlHelper.ExecuteScalar(
                SqlHelper.ConnectionString,
                CommandType.Text,
                sqltxt,
                para);
            if (i==1)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 订阅车位
        /// </summary>
        /// <param name="hid"></param>
        /// <returns></returns>
        public bool OrderPark(string hid)
        {
            string sqltxt = "Update ApplyInfo Set State=0,ParkPosintion=@ParkPosintion Where HID=@HID";
            SqlParameter[] paras=new SqlParameter[2];
            paras[0]=new SqlParameter("@HID",hid);
            paras[1]=new SqlParameter("@ParkPosintion",new Random().Next(0,250).ToString());
            int i = SqlHelper.ExecuteNonQuery(
                SqlHelper.ConnectionString2,
                CommandType.Text,
                sqltxt,
                paras);
            if (i!=1)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 通过车牌号获取订单号
        /// </summary>
        /// <param name="carNum"></param>
        /// <returns></returns>
        public int GetIdByCarNum(string carNum)
        {
            string sqltxt = "Select HID From ApplyInfo Where CarNum=" + carNum;
            int i = (int)SqlHelper.ExecuteScalar(
                SqlHelper.ConnectionString2,
                CommandType.Text,
                sqltxt);
            return i;
        }

        public bool FinishOrder(DateTime dt)
        {
            SqlParameter para=new SqlParameter("@EndTime",dt);
            string sqltxt= "Update History Set EndTime=@EndTime Where HID="
        }
    }
}
