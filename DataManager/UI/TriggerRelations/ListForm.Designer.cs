namespace DataManager.UI.TriggerRelations
{
    partial class ListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAddrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDataFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRow_GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 750);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CAddrName,
            this.CUniqueID,
            this.CFBID,
            this.CSEID,
            this.CDataFlag,
            this.CRow_GUID});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 30);
            this.dgvList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1067, 720);
            this.dgvList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 30);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbDate, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btAdd, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btSearch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btEdit, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btDelete, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbWord, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 30);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(200, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdd.Location = new System.Drawing.Point(481, 1);
            this.btAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(78, 28);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSearch
            // 
            this.btSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSearch.Location = new System.Drawing.Point(401, 1);
            this.btSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(78, 28);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "查询";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btEdit
            // 
            this.btEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEdit.Location = new System.Drawing.Point(561, 1);
            this.btEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(78, 28);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "编辑";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDelete.Location = new System.Drawing.Point(641, 1);
            this.btDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(78, 28);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "删除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbWord
            // 
            this.tbWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWord.Location = new System.Drawing.Point(67, 4);
            this.tbWord.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(133, 23);
            this.tbWord.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDate.Location = new System.Drawing.Point(267, 4);
            this.tbDate.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tbDate.MaxLength = 6;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(133, 23);
            this.tbDate.TabIndex = 13;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "ID";
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Visible = false;
            // 
            // CAddrName
            // 
            this.CAddrName.DataPropertyName = "AddrName";
            this.CAddrName.HeaderText = "地址";
            this.CAddrName.Name = "CAddrName";
            this.CAddrName.ReadOnly = true;
            // 
            // CUniqueID
            // 
            this.CUniqueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUniqueID.DataPropertyName = "UniqueID";
            this.CUniqueID.HeaderText = "编码";
            this.CUniqueID.Name = "CUniqueID";
            this.CUniqueID.ReadOnly = true;
            // 
            // CFBID
            // 
            this.CFBID.DataPropertyName = "FBID";
            this.CFBID.HeaderText = "FBID";
            this.CFBID.Name = "CFBID";
            this.CFBID.ReadOnly = true;
            // 
            // CSEID
            // 
            this.CSEID.DataPropertyName = "SEID";
            this.CSEID.HeaderText = "SEID";
            this.CSEID.Name = "CSEID";
            this.CSEID.ReadOnly = true;
            // 
            // CDataFlag
            // 
            this.CDataFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDataFlag.DataPropertyName = "DataFlag";
            this.CDataFlag.HeaderText = "DataFlag";
            this.CDataFlag.Name = "CDataFlag";
            this.CDataFlag.ReadOnly = true;
            // 
            // CRow_GUID
            // 
            this.CRow_GUID.DataPropertyName = "Row_GUID";
            this.CRow_GUID.HeaderText = "CRow_GUID";
            this.CRow_GUID.Name = "CRow_GUID";
            this.CRow_GUID.ReadOnly = true;
            this.CRow_GUID.Visible = false;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "列表";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDataFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRow_GUID;
    }
}