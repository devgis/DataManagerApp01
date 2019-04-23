using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.DeviceStatus
{
    public partial class AddEdit : Form
    {
        private string editGuid = string.Empty;
        public AddEdit(string id="")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(id))
            {
                editGuid = id;
                DataManager.Entities.DeviceStatus model = DeviceStatusBll.Get(id);
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
            if (string.IsNullOrEmpty(tbStatID.Text.Trim()))
            {
                MessageHelper.ShowError("编码不能为空！");
                tbStatID.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(tbStatID.Text);
                }
                catch
                {
                    MessageHelper.ShowError("编码必须为整数！");
                    tbStatID.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(tbStatName.Text.Trim()))
            {
                MessageHelper.ShowError("名称不能为空！");
                tbStatName.Focus();
                return false;
            }
            return true;
        }

        private bool Save(DataManager.Entities.DeviceStatus model)
        {
            if (string.IsNullOrEmpty(editGuid))
            {
                //添加
                return DeviceStatusBll.Add(model);
            }
            else
            {
                //编辑
                return DeviceStatusBll.Edit(model);
            }
            return false;
        }

        private DataManager.Entities.DeviceStatus Get()
        {
            DataManager.Entities.DeviceStatus model = new Entities.DeviceStatus();
            if (string.IsNullOrEmpty(editGuid))
            {
                model.Row_GUID = EntityHelper.GetID();
            }
            else
            {
                model.Row_GUID = editGuid;
            }
            model.StatID= Convert.ToInt32(tbStatID.Text);
            model.StatName= tbStatName.Text;
            model.Describe= tbDescribe.Text;
            if (cbIsSys.Checked)
            {
                model.IsSys = 1;
            }
            else
            {
                model.IsSys = 0;
            }
            if (cbIsCut.Checked)
            {
                model.IsCut = 1;
            }
            else
            {
                model.IsCut = 0;
            }
            if(cbIsShowImage.Checked)
            {
                model.IsShowImage = 1;
            }
            else
            {
                model.IsShowImage = 0;
            }
            model.ImageUrl = tbImageUrl.Text;
            try
            {
                model.OrderNum = Convert.ToInt32(tbOrderNum.Text);
            }
            catch
            { }
           
            return model;
        }

        private void Load(DataManager.Entities.DeviceStatus model)
        {
            if (model != null)
            {
                //加载数据
                tbStatID.Text = model.StatID.ToString();
                tbStatName.Text = model.StatName;
                tbDescribe.Text = model.Describe;
                cbIsSys.Checked = (model.IsSys == 1);
                cbIsCut.Checked = (model.IsCut == 1);
                cbIsShowImage.Checked = (model.IsShowImage == 1);
                tbImageUrl.Text= model.ImageUrl;
                tbOrderNum.Text = model.OrderNum.ToString();
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
            if(!bOKClose)
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
