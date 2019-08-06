using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using S_Park_simulator.DAL;

namespace S_Park_simulator
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        public List<ApplyInfo> list;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            list = new DAL.DAL().GetAllInfo(this.txbParkID.Text);
            foreach (ApplyInfo apply in list)
            {
                if (apply.State == 0)
                {
                    new DAL.DAL().OrderPark(apply.HID.ToString());
                }
            }

            this.dgvCarNum.DataSource = list;
        }

        #region 出入车库

        private void BtnIn_Click(object sender, EventArgs e)
        {
            string CarNum = this.txbCarNum.Text.Trim();
            foreach (ApplyInfo app in list)
            {
                if (app.CarNum == this.txbCarNum.Text && app.State == 1)
                {
                    //当活跃订单中存在该车辆 更改HIS中的State和StartTime
                    if (new DAL.DAL().ConfirmStatTime(app.HID.ToString()))
                    {
                        MessageBox.Show("开始时间保存错误！");
                        return;
                    }

                    MessageBox.Show(app.CarNum + "入库成功！\n时间" + DateTime.Now.ToString());
                }

            }
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            string carnum = this.txbCarNum2.Text;
            DAL.DAL dal=new DAL.DAL();
            foreach (ApplyInfo app in list)
            {
                if (app.CarNum == this.txbCarNum.Text && app.State == 1)
                {
                    //当活跃订单中存在该车辆 更改HIS中的State和StartTime
                    if (dal.ConfirmEndTime(app.HID.ToString()))
                    {
                        MessageBox.Show("结束时间保存错误！");
                        return;
                    }

                    MessageBox.Show(app.CarNum + "出库成功！\n时间" + DateTime.Now.ToString());
                    //删除活跃订单
                    if (dal.DeleteApply(app.HID.ToString()))
                    {
                        //删除活跃订单失败
                        MessageBox.Show("删除活跃订单失败！");
                        return;
                    }
                }

            }
        }

        #endregion

        #region 开关

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //1、判断车库ID是否存在
            if (new DAL.DAL().ParkIsTrue(this.txbParkID.Text))
            {
                MessageBox.Show("不存在该车库！");
                return;
            }

            this.txbParkID.ReadOnly = true;
            this.timer1.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.txbParkID.ReadOnly = false;
        }

        #endregion


        private void TxbCarNum_TextChanged(object sender, EventArgs e)
        {
            this.txbCarNum2.Text = this.txbCarNum.Text;
        }


    }
}
