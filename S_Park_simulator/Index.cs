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

        private void BtnIn_Click(object sender, EventArgs e)
        {
            string CarNum = this.txbCarNum.Text.Trim();
            foreach (ApplyInfo app in list)
            {
                if (app.CarNum==this.txbCarNum.Text)
                {
                    //当活跃订单中存在该车辆
                    new DAL.DAL().OrderPark(app.HID.ToString());

                }
                
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            list = new DAL.DAL().GetAllInfo(this.txbParkID.Text);


        }

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

        private void TxbCarNum_TextChanged(object sender, EventArgs e)
        {
            this.txbCarNum2.Text = this.txbCarNum.Text;
        }
    }
}
