using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.DeviceInfo
{
    public partial class AddEdit : Form
    {
        private string editGuid = string.Empty;
        public AddEdit(string id="")
        {
            InitializeComponent();

            cbAddrID.DataSource = AddressBll.Query();
            cbAddrID.DisplayMember = "AddrName";
            cbAddrID.ValueMember = "AddrID";

            cbTypeID.DataSource = DeviceTypeBll.Query();
            cbTypeID.DisplayMember = "ShowName";
            cbTypeID.ValueMember = "TypeID";

            if (!string.IsNullOrEmpty(id))
            {
                editGuid = id;
                DataManager.Entities.DeviceInfo model = DeviceInfoBll.Get(id);
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
            if (string.IsNullOrEmpty(tbDevLabel.Text.Trim()))
            {
                MessageHelper.ShowError("标签不能为空！");
                tbDevLabel.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbUniqueID.Text.Trim()))
            {
                MessageHelper.ShowError("唯一码不能为空！");
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
                    MessageHelper.ShowError("唯一码必须为数字！");
                    tbUniqueID.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(tbRegisterNum.Text.Trim()))
            {
                MessageHelper.ShowError("注册号不能为空！");
                tbRegisterNum.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbTypeID.Text.Trim()))
            {
                MessageHelper.ShowError("请选择设备类别！");
                cbTypeID.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbAddrID.Text.Trim()))
            {
                MessageHelper.ShowError("请选择地址！");
                cbAddrID.Focus();
                return false;
            }
            return true;
        }

        private bool Save(DataManager.Entities.DeviceInfo model)
        {
            if (string.IsNullOrEmpty(editGuid))
            {
                //添加
                return DeviceInfoBll.Add(model);
            }
            else
            {
                //编辑
                return DeviceInfoBll.Edit(model);
            }
            return false;
        }

        private DataManager.Entities.DeviceInfo Get()
        {
            DataManager.Entities.DeviceInfo model = new Entities.DeviceInfo();
            model.DevLabel= tbDevLabel.Text;
            model.UniqueID= Convert.ToInt64(tbUniqueID.Text);
            //model= tbDescribe.Text;
            model.RegisterNum= Convert.ToInt32(tbRegisterNum.Text);
            model.TypeID = Convert.ToInt32(cbTypeID.SelectedValue);
            model.AddrID = Convert.ToInt64(cbAddrID.SelectedValue);
            model.CutArea = string.Empty;
            model.SpecialDes = string.Empty;
            if (string.IsNullOrEmpty(editGuid))
            {
                model.Row_GUID = EntityHelper.GetID();
            }
            else
            {
                model.Row_GUID = editGuid;
            }
            return model;
        }

        private void Load(DataManager.Entities.DeviceInfo model)
        {
            if (model != null)
            {
                //加载数据
                tbDevLabel.Text = model.DevLabel;
                tbUniqueID.Text = model.UniqueID.ToString();
                //tbDescribe.Text = model.Describe;
                tbRegisterNum.Text = model.RegisterNum.ToString();

                cbTypeID.SelectedValue= model.TypeID;
                cbAddrID.SelectedValue = model.AddrID;
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
