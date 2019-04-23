using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.DeviceType
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
                DataManager.Entities.DeviceType model = DeviceTypeBll.Get(id);
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
            if (string.IsNullOrEmpty(tbTypeID.Text.Trim()))
            {
                MessageHelper.ShowError("编码不能为空！");
                tbTypeID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbTypeName.Text.Trim()))
            {
                MessageHelper.ShowError("名称不能为空！");
                tbTypeName.Focus();
                return false;
            }
            
            if (string.IsNullOrEmpty(tbShowName.Text.Trim()))
            {
                MessageHelper.ShowError("显示名称不能为空！");
                tbShowName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbRange.Text.Trim()))
            {
                MessageHelper.ShowError("范围不能为空！");
                tbRange.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbFormat.Text.Trim()))
            {
                MessageHelper.ShowError("格式不能为空！");
                tbFormat.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(tbFormat.Text);
                }
                catch
                {
                    MessageHelper.ShowError("格式必须为整数！");
                    tbFormat.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(tbDepthLevel.Text.Trim()))
            {
                MessageHelper.ShowError("深度不能为空！");
                tbDepthLevel.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(tbDepthLevel.Text);
                }
                catch
                {
                    MessageHelper.ShowError("深度必须为整数！");
                    tbDepthLevel.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool Save(DataManager.Entities.DeviceType model)
        {
            if (string.IsNullOrEmpty(editGuid))
            {
                //添加
                return DeviceTypeBll.Add(model);
            }
            else
            {
                //编辑
                return DeviceTypeBll.Edit(model);
            }
            return false;
        }

        private DataManager.Entities.DeviceType Get()
        {
            DataManager.Entities.DeviceType model = new Entities.DeviceType();
            model.TypeID= Convert.ToInt32( tbTypeID.Text);
            model.TypeName= tbTypeName.Text;
            model.Describe= tbDescribe.Text;
            model.ShowName= tbShowName.Text;
            model.Unit = tbUnit.Text;
            model.Range = tbRange.Text;
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
                model.Format = Convert.ToInt32(tbFormat.Text);
            }
            catch
            { }
            try
            {
                model.DepthLevel = Convert.ToInt32(tbDepthLevel.Text);
            }
            catch
            { }
            model.TopoCode = tbTopoCode.ToString();
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
            if (cbIsAnalog.Checked)
            {
                model.IsAnalog = 1;
            }
            else
            {
                model.IsAnalog = 0;
            }
            if (cbIsActual.Checked)
            {
                model.IsActual = 1;
            }
            else
            {
                model.IsActual = 0;
            }
            model.IconFile = tbIconFile.Text;
            return model;
        }

        private void Load(DataManager.Entities.DeviceType model)
        {
            if (model != null)
            {
                //加载数据
                tbTypeID.Text = model.TypeID.ToString();
                tbTypeName.Text = model.TypeName;
                tbDescribe.Text = model.Describe;
                tbShowName.Text = model.ShowName;
                tbUnit.Text = model.Unit;
                tbFormat.Text = model.Format.ToString();
                tbTopoCode.Text = model.TopoCode;
                cbIsAnalog.Checked = (model.IsAnalog == 1);
                cbIsActual.Checked = (model.IsActual == 1);
                cbIsSystem.Checked = (model.IsSystem == 1);
                tbDepthLevel.Text = model.DepthLevel.ToString();
                tbTopoCode.Text = model.TopoCode;
                tbOrderNum.Text = model.OrderNum.ToString();
                tbIconFile.Text = model.IconFile;
                tbRange.Text = model.Range;
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
