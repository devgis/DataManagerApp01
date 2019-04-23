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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            dgvList.AutoGenerateColumns = false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string where = string.Empty;
            if (!string.IsNullOrEmpty(tbWord.Text.Trim()))
            {
                where = string.Format("TypeID like '%{0}%' or TypeName like '%{0}%' or ShowName like '%{0}%' or Describe like '%{0}%'", tbWord.Text);
            }
            RefreshData(where);
        }

        private void RefreshData(string where ="")
        {
            dgvList.DataSource = DeviceTypeBll.Query(where);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddEdit frmAddEdit = new AddEdit();
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                btSearch.PerformClick();
            }
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageHelper.ShowError("请选中行进行编辑！");
            }
            else
            {
                string guid = dgvList.SelectedRows[0].Cells["CRow_GUID"].Value.ToString();
                AddEdit frmAddEdit = new AddEdit(guid);
                if (frmAddEdit.ShowDialog() == DialogResult.OK)
                {
                    btSearch.PerformClick();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageHelper.ShowError("请选中行进行编辑！");
            }
            else
            {
                string guid = dgvList.SelectedRows[0].Cells["CRow_GUID"].Value.ToString();
                if (DeviceTypeBll.Delete(guid))
                {
                    btSearch.PerformClick();
                    MessageHelper.ShowInfo("删除成功！");
                }
                else
                {
                    MessageHelper.ShowError("删除失败！");
                }
            }
        }
    }
}
