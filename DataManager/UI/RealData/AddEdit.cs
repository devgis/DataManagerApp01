using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.RealData
{
    public partial class AddEdit : Form
    {
        private string editGuid = string.Empty;
        public AddEdit(string id = "")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(id))
            {
                editGuid = id;
                DataManager.Entities.RealData model = RealDataBll.Get(id);
                Load(model);
                this.Text = "编辑";
                btSave.Text = "保存";
            }
            else
            {
                this.Text = "添加";
                btSave.Text = "添加";
            }
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(tbUniqueID.Text.Trim()))
            {
                MessageHelper.ShowError("编码不能为空！");
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
                    MessageHelper.ShowError("编码必须为数字！");
                    tbUniqueID.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool Save(DataManager.Entities.RealData model)
        {
            if (string.IsNullOrEmpty(editGuid))
            {
                //添加
                return RealDataBll.Add(model);
            }
            else
            {
                //编辑
                return RealDataBll.Edit(model);
            }
            return false;
        }

        private DataManager.Entities.RealData Get()
        {
            DataManager.Entities.RealData model = new Entities.RealData();
            if (string.IsNullOrEmpty(editGuid))
            {
                model.Row_GUID = EntityHelper.GetID();
            }
            else
            {
                model.Row_GUID = editGuid;
            }
            try
            {
                model.AAvgValue = Convert.ToDouble(tbAAvgValue.Text);
            }
            catch
            { }
            try
            {
                model.AlarmID = Convert.ToInt64(tbAlarmID.Text);
            }
            catch
            {
            }
            try
            {
                model.Value = Convert.ToInt64(tbValue.Text);
            }
            catch
            {
            }
            try
            {
                model.AlarmStatus = Convert.ToInt32(tbAlarmStatus.Text);
            }
            catch
            {
            }
            try
            {
                model.AMaxValue = Convert.ToDouble(tbAMaxValue.Text);
            }
            catch
            {
            }
            try
            {
                model.AMinValue = Convert.ToDouble(tbAMinValue.Text);
            }
            catch
            {
            }
            try
            {
                model.AvgValue = Convert.ToDouble(tbAvgValue.Text);
            }
            catch
            {
            }
            try
            {
                model.CAvgValue = Convert.ToDouble(tbCAvgValue.Text);
            }
            catch
            {
            }
            try
            {
                model.CMaxValue = Convert.ToDouble(tbCMaxValue.Text);
            }
            catch
            {
            }
            try
            {
                model.CMinValue = Convert.ToDouble(tbCMinValue.Text);
            }
            catch
            {
            }
            try
            {
                model.CutID = Convert.ToInt64(tbCutID.Text);
            }
            catch
            {
            }
            try
            {
                model.CutStatus = Convert.ToInt32(tbCutStatus.Text);
            }
            catch
            {
            }
            try
            {
                model.MaxValue = Convert.ToDouble(tbMaxValue.Text);
            }
            catch
            {
            }
            try
            {
                model.MaxVPosition = Convert.ToDouble(tbMaxVPosition.Text);
            }
            catch
            {
            }
            try
            {
                model.MinValue = Convert.ToDouble(tbMinValue.Text);
            }
            catch
            {
            }
            try
            {
                model.MinVPosition = Convert.ToDouble(tbMinVPosition.Text);
            }
            catch
            {
            }
            try
            {
                model.StaMaxValue = Convert.ToDouble(tbStaMaxValue.Text);
            }
            catch
            {
            }
            try
            {
                model.StaMinValue = Convert.ToDouble(tbStaMinValue.Text);
            }
            catch
            {
            }
            try
            {
                model.UniqueID = Convert.ToInt64(tbUniqueID.Text);
            }
            catch
            {
            }
            try
            {
                model.Value = Convert.ToDecimal(tbValue.Text);
            }
            catch
            {
            }
            try
            {
                model.VStatus = Convert.ToInt32(tbVStatus.Text);
            }
            catch
            {
            }
            return model;
        }

        private void Load(DataManager.Entities.RealData model)
        {
            if (model != null)
            {
                //加载数据
                tbAAvgValue.Text = model.AAvgValue.ToString();
                tbValue.Text = model.Value.ToString();
                tbAlarmID.Text = model.AlarmID.ToString();
                tbAlarmStatus.Text = model.AlarmStatus.ToString();
                tbAMaxValue.Text = model.AMaxValue.ToString();
                tbAMinValue.Text = model.AMinValue.ToString();
                tbAvgValue.Text = model.AvgValue.ToString();
                tbCAvgValue.Text = model.CAvgValue.ToString();
                tbCMaxValue.Text = model.CMaxValue.ToString();
                tbCMinValue.Text = model.CMinValue.ToString();
                tbCutID.Text = model.CutID.ToString();
                tbCutStatus.Text = model.CutStatus.ToString();
                tbMaxValue.Text = model.MaxValue.ToString();
                tbMaxVPosition.Text = model.MaxVPosition.ToString();
                tbMinValue.Text = model.MinValue.ToString();
                tbMinVPosition.Text = model.MinVPosition.ToString();
                tbStaMaxValue.Text = model.StaMaxValue.ToString();
                tbStaMinValue.Text = model.StaMinValue.ToString();
                tbUniqueID.Text = model.UniqueID.ToString();
                tbValue.Text = model.Value.ToString();
                tbVStatus.Text = model.VStatus.ToString();
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
