using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S_Park_simulator
{
    public class ApplyInfo
    {
        private int hID;
        public int HID
        {
            get { return hID; }
            set { hID = value; }
        }

        private string carNum;
        public string CarNum
        {
            get { return carNum; }
            set { carNum = value; }
        }

        private int parkID;
        public int ParkID
        {
            get { return parkID; }
            set { parkID = value; }
        }

        private string parkPosintion;
        public string ParkPosintion
        {
            get { return parkPosintion; }
            set { parkPosintion = value; }
        }

        private bool state;
        public bool State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
