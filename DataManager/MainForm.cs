using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btAddress_Click(object sender, EventArgs e)
        {
            DataManager.UI.Address.ListForm listForm = new DataManager.UI.Address.ListForm();
            listForm.ShowDialog();
        }

        private void btDeviceInfo_Click(object sender, EventArgs e)
        {
            DataManager.UI.DeviceInfo.ListForm listForm = new DataManager.UI.DeviceInfo.ListForm();
            listForm.ShowDialog();
        }

        private void btDeviceStatus_Click(object sender, EventArgs e)
        {
            DataManager.UI.DeviceStatus.ListForm listForm = new DataManager.UI.DeviceStatus.ListForm();
            listForm.ShowDialog();
        }

        private void btDeviceType_Click(object sender, EventArgs e)
        {
            DataManager.UI.DeviceType.ListForm listForm = new DataManager.UI.DeviceType.ListForm();
            listForm.ShowDialog();
        }

        private void btRealData_Click(object sender, EventArgs e)
        {
            DataManager.UI.RealData.ListForm listForm = new DataManager.UI.RealData.ListForm();
            listForm.ShowDialog();
        }

        private void btStaOneMinute_Click(object sender, EventArgs e)
        {
            DataManager.UI.StaOneMinute.ListForm listForm = new DataManager.UI.StaOneMinute.ListForm();
            listForm.ShowDialog();
        }

        private void btAnalogRunRecord_Click(object sender, EventArgs e)
        {
            DataManager.UI.AnalogRunRecord.ListForm listForm = new DataManager.UI.AnalogRunRecord.ListForm();
            listForm.ShowDialog();
        }

        private void btSwitchStatusRecord_Click(object sender, EventArgs e)
        {
            DataManager.UI.SwitchStatusRecord.ListForm listForm = new DataManager.UI.SwitchStatusRecord.ListForm();
            listForm.ShowDialog();
        }

        private void btTriggerRelations_Click(object sender, EventArgs e)
        {
            DataManager.UI.TriggerRelations.ListForm listForm = new DataManager.UI.TriggerRelations.ListForm();
            listForm.ShowDialog();
        }
    }
}
