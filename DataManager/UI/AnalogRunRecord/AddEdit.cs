using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.AnalogRunRecord
{
    public partial class AddEdit : Form
    {
        private string editGuid = string.Empty;
        private string DataString = string.Empty;
        public AddEdit(string dataString,string id = "")
        {
            InitializeComponent();
            DataString = dataString;
            if (!string.IsNullOrEmpty(id))
            {
                editGuid = id;
                DataManager.Entities.AnalogRunRecord model = AnalogRunRecordBll.Get(DataString,id);
                Load(model);
                this.Text = "编辑";
                btSave.Text = "保存";
                tbID.ReadOnly = true;
            }
            else
            {
                this.Text = "添加";
                btSave.Text = "添加";
            }
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(tbID.Text.Trim()))
            {
                MessageHelper.ShowError("编码不能为空！");
                tbID.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt64(tbID.Text);
                }
                catch
                {
                    MessageHelper.ShowError("编码必须为数字！");
                    tbID.Focus();
                    return false;
                }
            }
            
            if (string.IsNullOrEmpty(tbUniqueID.Text.Trim()))
            {
                MessageHelper.ShowError("设备编号不能为空！");
                tbUniqueID.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt64(tbUniqueID.Text);
                }
                catch
                {
                    MessageHelper.ShowError("设备编号必须为数字！");
                    tbUniqueID.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool Save(DataManager.Entities.AnalogRunRecord model)
        {
            if (string.IsNullOrEmpty(editGuid))
            {
                //添加
                return AnalogRunRecordBll.Add(DataString,model);
            }
            else
            {
                //编辑
                return AnalogRunRecordBll.Edit(DataString,model);
            }
        }

        private DataManager.Entities.AnalogRunRecord Get()
        {
            DataManager.Entities.AnalogRunRecord model = new Entities.AnalogRunRecord();
            try
            {
                model.UniqueID = Convert.ToInt64(tbUniqueID.Text);
            }
            catch
            { }
            try
            {
                model.ID = Convert.ToInt64(tbID.Text);
            }
            catch
            { }

            try
            {
                model.SValue = Convert.ToDouble(tbSValue.Text);
            }
            catch
            { }

            try
            {
                model.StatusID = Convert.ToInt32(tbStatusID.Text);
            }
            catch
            { }

            try
            {
                model.DataFlag = Convert.ToInt32(tbDataFlag.Text);
            }
            catch
            { }
            model.STime = dtpSTime.Value;
            return model;
        }

        private void Load(DataManager.Entities.AnalogRunRecord model)
        {
            if (model != null)
            {
                //加载数据
                tbUniqueID.Text = model.UniqueID.ToString();
                tbSValue.Text = model.SValue.ToString();
                tbID.Text = model.ID.ToString();
                tbStatusID.Text = model.StatusID.ToString();
                tbDataFlag.Text = model.DataFlag.ToString();
                try
                {
                    dtpSTime.Value = model.STime;
                    
                }
                catch
                { }
            }
        }

        bool bButtonClose = false;
        bool bOKClose = false;
        private void btCancle_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("确定取消并退出界面吗？"))
            {
                bButtonClose = true;
                this.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (Save(Get()))
                {
                    MessageHelper.ShowInfo("保存成功！");
                    bOKClose = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageHelper.ShowError("保存失败，请检查！");
                }
            }
        }

        private void AddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bOKClose)
            {
                if (!bButtonClose)
                {
                    if (!MessageHelper.ShowQuestion("确定取消并退出界面吗？"))
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

    }
}
