using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.StaOneMinute
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
                DataManager.Entities.StaOneMinute model = StaOneMinuteBll.Get(DataString,id);
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

        private bool Save(DataManager.Entities.StaOneMinute model)
        {
            if (string.IsNullOrEmpty(editGuid))
            {
                //添加
                return StaOneMinuteBll.Add(DataString,model);
            }
            else
            {
                //编辑
                return StaOneMinuteBll.Edit(DataString,model);
            }
        }

        private DataManager.Entities.StaOneMinute Get()
        {
            DataManager.Entities.StaOneMinute model = new Entities.StaOneMinute();
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
                model.AvgValue = Convert.ToDouble(tbAvgValue.Text);
            }
            catch
            { }

            try
            {
                model.MaxValue = Convert.ToDouble(tbMaxValue.Text);
            }
            catch
            { }

            try
            {
                model.MinValue = Convert.ToDouble(tbMinValue.Text);
            }
            catch
            { }



            try
            {
                model.StatID = Convert.ToInt32(tbStatID.Text);
            }
            catch
            { }

            try
            {
                model.DataFlag = Convert.ToInt32(tbDataFlag.Text);
            }
            catch
            { }
            model.StaTime= dtpStaTime.Value;
            model.MaxVTime= dtpMaxVTime.Value;
            model.MinVTime= dtpMinVTime.Value;
            return model;
        }

        private void Load(DataManager.Entities.StaOneMinute model)
        {
            if (model != null)
            {
                //加载数据
                tbUniqueID.Text = model.UniqueID.ToString();
                tbAvgValue.Text = model.AvgValue.ToString();
                tbMaxValue.Text = model.MaxValue.ToString();
                tbMinValue.Text = model.MinValue.ToString();
                tbID.Text = model.ID.ToString();

                tbStatID.Text = model.StatID.ToString();
                tbDataFlag.Text = model.DataFlag.ToString();
                try
                {
                    dtpStaTime.Value = model.StaTime;
                    
                }
                catch
                { }

                try
                {
                    dtpMaxVTime.Value = model.MaxVTime;
                    
                }
                catch
                { }

                try
                {
                    dtpMinVTime.Value = model.MinVTime;
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
