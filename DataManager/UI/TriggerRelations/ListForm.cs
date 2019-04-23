using DataManager.Bll;
using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager.UI.TriggerRelations
{
    public partial class ListForm : Form
    {
        const int dataStringLength = 4;
        string dataString = "";
        public ListForm()
        {
            InitializeComponent();
            dgvList.AutoGenerateColumns = false;
            tbDate.Text = DateTime.Now.ToString("yyyy");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (tbDate.Text.Trim().Length != dataStringLength)
            {
                MessageHelper.ShowError("日期不正确！");
                return;
            }
            dataString = tbDate.Text;
            string where = string.Empty;
            if (!string.IsNullOrEmpty(tbWord.Text.Trim()))
            {
                where = string.Format("UniqueID like '%{0}%' or ID like '%{0}%'", tbWord.Text);
            }
            RefreshData(where);
        }

        private void RefreshData(string where ="")
        {
            dgvList.DataSource = TriggerRelationsBll.Query(dataString,where);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbDate.Text.Trim().Length != dataStringLength)
            {
                MessageHelper.ShowError("日期不正确！");
                return;
            }
            dataString = tbDate.Text;
            AddEdit frmAddEdit = new AddEdit(dataString);
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                btSearch.PerformClick();
            }
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            //RefreshData();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

            if (tbDate.Text.Trim().Length != dataStringLength)
            {
                MessageHelper.ShowError("日期不正确！");
                return;
            }
            dataString = tbDate.Text;
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageHelper.ShowError("请选中行进行编辑！");
            }
            else
            {
                string guid = dgvList.SelectedRows[0].Cells["CRow_GUID"].Value.ToString();
                AddEdit frmAddEdit = new AddEdit(dataString,guid);
                if (frmAddEdit.ShowDialog() == DialogResult.OK)
                {
                    btSearch.PerformClick();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbDate.Text.Trim().Length != dataStringLength)
            {
                MessageHelper.ShowError("日期不正确！");
                return;
            }
            dataString = tbDate.Text;
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageHelper.ShowError("请选中行进行编辑！");
            }
            else
            {
                string guid = dgvList.SelectedRows[0].Cells["CRow_GUID"].Value.ToString();
                if (TriggerRelationsBll.Delete(dataString,guid))
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
