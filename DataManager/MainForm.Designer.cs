namespace DataManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btAddress = new System.Windows.Forms.Button();
            this.btDeviceInfo = new System.Windows.Forms.Button();
            this.btDeviceStatus = new System.Windows.Forms.Button();
            this.btDeviceType = new System.Windows.Forms.Button();
            this.btRealData = new System.Windows.Forms.Button();
            this.btStaOneMinute = new System.Windows.Forms.Button();
            this.btAnalogRunRecord = new System.Windows.Forms.Button();
            this.btSwitchStatusRecord = new System.Windows.Forms.Button();
            this.btTriggerRelations = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btDeviceInfo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btDeviceStatus, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btDeviceType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btRealData, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btStaOneMinute, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btAnalogRunRecord, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btSwitchStatusRecord, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btTriggerRelations, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btAddress
            // 
            this.btAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAddress.Location = new System.Drawing.Point(148, 57);
            this.btAddress.Name = "btAddress";
            this.btAddress.Size = new System.Drawing.Size(194, 44);
            this.btAddress.TabIndex = 0;
            this.btAddress.Text = "地址信息";
            this.btAddress.UseVisualStyleBackColor = true;
            this.btAddress.Click += new System.EventHandler(this.btAddress_Click);
            // 
            // btDeviceInfo
            // 
            this.btDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDeviceInfo.Location = new System.Drawing.Point(148, 107);
            this.btDeviceInfo.Name = "btDeviceInfo";
            this.btDeviceInfo.Size = new System.Drawing.Size(194, 44);
            this.btDeviceInfo.TabIndex = 1;
            this.btDeviceInfo.Text = "设备信息";
            this.btDeviceInfo.UseVisualStyleBackColor = true;
            this.btDeviceInfo.Click += new System.EventHandler(this.btDeviceInfo_Click);
            // 
            // btDeviceStatus
            // 
            this.btDeviceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDeviceStatus.Location = new System.Drawing.Point(148, 157);
            this.btDeviceStatus.Name = "btDeviceStatus";
            this.btDeviceStatus.Size = new System.Drawing.Size(194, 44);
            this.btDeviceStatus.TabIndex = 2;
            this.btDeviceStatus.Text = "设备状态";
            this.btDeviceStatus.UseVisualStyleBackColor = true;
            this.btDeviceStatus.Click += new System.EventHandler(this.btDeviceStatus_Click);
            // 
            // btDeviceType
            // 
            this.btDeviceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDeviceType.Location = new System.Drawing.Point(148, 207);
            this.btDeviceType.Name = "btDeviceType";
            this.btDeviceType.Size = new System.Drawing.Size(194, 44);
            this.btDeviceType.TabIndex = 3;
            this.btDeviceType.Text = "设备分类";
            this.btDeviceType.UseVisualStyleBackColor = true;
            this.btDeviceType.Click += new System.EventHandler(this.btDeviceType_Click);
            // 
            // btRealData
            // 
            this.btRealData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRealData.Location = new System.Drawing.Point(148, 257);
            this.btRealData.Name = "btRealData";
            this.btRealData.Size = new System.Drawing.Size(194, 44);
            this.btRealData.TabIndex = 4;
            this.btRealData.Text = "实时数据";
            this.btRealData.UseVisualStyleBackColor = true;
            this.btRealData.Click += new System.EventHandler(this.btRealData_Click);
            // 
            // btStaOneMinute
            // 
            this.btStaOneMinute.Location = new System.Drawing.Point(348, 57);
            this.btStaOneMinute.Name = "btStaOneMinute";
            this.btStaOneMinute.Size = new System.Drawing.Size(194, 44);
            this.btStaOneMinute.TabIndex = 5;
            this.btStaOneMinute.Text = "StaOneMinute";
            this.btStaOneMinute.UseVisualStyleBackColor = true;
            this.btStaOneMinute.Click += new System.EventHandler(this.btStaOneMinute_Click);
            // 
            // btAnalogRunRecord
            // 
            this.btAnalogRunRecord.Location = new System.Drawing.Point(348, 107);
            this.btAnalogRunRecord.Name = "btAnalogRunRecord";
            this.btAnalogRunRecord.Size = new System.Drawing.Size(194, 44);
            this.btAnalogRunRecord.TabIndex = 6;
            this.btAnalogRunRecord.Text = "AnalogRunRecord";
            this.btAnalogRunRecord.UseVisualStyleBackColor = true;
            this.btAnalogRunRecord.Click += new System.EventHandler(this.btAnalogRunRecord_Click);
            // 
            // btSwitchStatusRecord
            // 
            this.btSwitchStatusRecord.Location = new System.Drawing.Point(348, 157);
            this.btSwitchStatusRecord.Name = "btSwitchStatusRecord";
            this.btSwitchStatusRecord.Size = new System.Drawing.Size(194, 44);
            this.btSwitchStatusRecord.TabIndex = 7;
            this.btSwitchStatusRecord.Text = "SwitchStatusRecord";
            this.btSwitchStatusRecord.UseVisualStyleBackColor = true;
            this.btSwitchStatusRecord.Click += new System.EventHandler(this.btSwitchStatusRecord_Click);
            // 
            // btTriggerRelations
            // 
            this.btTriggerRelations.Location = new System.Drawing.Point(348, 207);
            this.btTriggerRelations.Name = "btTriggerRelations";
            this.btTriggerRelations.Size = new System.Drawing.Size(194, 44);
            this.btTriggerRelations.TabIndex = 8;
            this.btTriggerRelations.Text = "TriggerRelations";
            this.btTriggerRelations.UseVisualStyleBackColor = true;
            this.btTriggerRelations.Click += new System.EventHandler(this.btTriggerRelations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主程序";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btAddress;
        private System.Windows.Forms.Button btDeviceInfo;
        private System.Windows.Forms.Button btDeviceStatus;
        private System.Windows.Forms.Button btDeviceType;
        private System.Windows.Forms.Button btRealData;
        private System.Windows.Forms.Button btStaOneMinute;
        private System.Windows.Forms.Button btAnalogRunRecord;
        private System.Windows.Forms.Button btSwitchStatusRecord;
        private System.Windows.Forms.Button btTriggerRelations;
    }
}

