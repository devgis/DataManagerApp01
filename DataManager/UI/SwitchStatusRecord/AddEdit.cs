using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.SwitchStatusRecord
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
                DataManager.Entities.SwitchStatusRecord model = SwitchStatusRecordBll.Get(DataString,id);
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

        private bool Save(DataManager.Entities.SwitchStatusRecord model)
        {
            if (string.IsNullOrEmpty(editGuid))
            {
                //添加
                return SwitchStatusRecordBll.Add(DataString,model);
            }
            else
            {
                //编辑
                return SwitchStatusRecordBll.Edit(DataString,model);
            }
        }

        private DataManager.Entities.SwitchStatusRecord Get()
        {
            DataManager.Entities.SwitchStatusRecord model = new Entities.SwitchStatusRecord();

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
                model.CauseRecID = Convert.ToInt64(tbCauseRecID.Text);
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
            model.BTime= dtpBTime.Value;
            model.ETime= dtpETime.Value;
            return model;
        }

        private void Load(DataManager.Entities.SwitchStatusRecord model)
        {
            if (model != null)
            {
                //加载数据
                tbUniqueID.Text = model.UniqueID.ToString();
                tbCauseRecID.Text = model.CauseRecID.ToString();
                tbID.Text = model.ID.ToString();

                tbStatID.Text = model.StatID.ToString();
                tbDataFlag.Text = model.DataFlag.ToString();
                dtpBTime.Value= model.BTime;
                dtpETime.Value= model.ETime;
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
