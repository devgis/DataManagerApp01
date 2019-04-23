using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.Address
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
                DataManager.Entities.Address model = AddressBll.Get(id);
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
            if (string.IsNullOrEmpty(tbAddrCode.Text.Trim()))
            {
                MessageHelper.ShowError("编码不能为空！");
                tbAddrCode.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbAddrName.Text.Trim()))
            {
                MessageHelper.ShowError("名称不能为空！");
                tbAddrName.Focus();
                return false;
            }
            return true;
        }

        private bool Save(DataManager.Entities.Address model)
        {
            if (string.IsNullOrEmpty(editGuid))
            {
                //添加
                return AddressBll.Add(model);
            }
            else
            {
                //编辑
                return AddressBll.Edit(model);
            }
            return false;
        }

        private DataManager.Entities.Address Get()
        {
            DataManager.Entities.Address model = new Entities.Address();
            model.AddrCode= tbAddrCode.Text;
            model.AddrName= tbAddrName.Text;
            model.Describe= tbDescribe.Text;
            model.Initials= tbInitials.Text;
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
                model.MaxNum = Convert.ToInt32(tbMaxNum.Text);
            }
            catch
            { }
            try
            {
                model.OrderNum = Convert.ToInt32(tbOrderNum.Text);
            }
            catch
            { }
            model.TopoCode= tbTopoCode.Text;
            if (cbIsActual.Checked)
            {
                model.IsActual = 1;
            }
            else
            {
                model.IsActual = 0;
            }
            return model;
        }

        private void Load(DataManager.Entities.Address model)
        {
            if (model != null)
            {
                //加载数据
                tbAddrCode.Text = model.AddrCode;
                tbAddrName.Text = model.AddrName;
                tbDescribe.Text = model.Describe;
                tbInitials.Text = model.Initials;
                tbMaxNum.Text = model.MaxNum.ToString();
                tbOrderNum.Text = model.OrderNum.ToString();
                tbTopoCode.Text = model.TopoCode;
                cbIsActual.Checked = (model.IsActual == 1);
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
