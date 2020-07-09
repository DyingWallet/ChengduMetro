namespace ChengduMetro3._0
{
    partial class Mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.chkDis = new System.Windows.Forms.CheckBox();
            this.grpPath = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbEnd = new System.Windows.Forms.ComboBox();
            this.cmbStart = new System.Windows.Forms.ComboBox();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.grpMode.SuspendLayout();
            this.grpPath.SuspendLayout();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.chkTime);
            this.grpMode.Controls.Add(this.chkDis);
            this.grpMode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpMode.Location = new System.Drawing.Point(12, 12);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(120, 80);
            this.grpMode.TabIndex = 0;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "选择模式";
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkTime.Location = new System.Drawing.Point(19, 50);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(84, 24);
            this.chkTime.TabIndex = 1;
            this.chkTime.Text = "时间最短";
            this.chkTime.UseVisualStyleBackColor = true;
            this.chkTime.CheckedChanged += new System.EventHandler(this.chkTime_CheckedChanged);
            // 
            // chkDis
            // 
            this.chkDis.AutoSize = true;
            this.chkDis.Checked = true;
            this.chkDis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDis.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkDis.Location = new System.Drawing.Point(19, 20);
            this.chkDis.Name = "chkDis";
            this.chkDis.Size = new System.Drawing.Size(84, 24);
            this.chkDis.TabIndex = 0;
            this.chkDis.Text = "路程最短";
            this.chkDis.UseVisualStyleBackColor = true;
            this.chkDis.CheckedChanged += new System.EventHandler(this.chkDis_CheckedChanged);
            // 
            // grpPath
            // 
            this.grpPath.Controls.Add(this.btnQuery);
            this.grpPath.Controls.Add(this.cmbEnd);
            this.grpPath.Controls.Add(this.cmbStart);
            this.grpPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpPath.Location = new System.Drawing.Point(138, 12);
            this.grpPath.Name = "grpPath";
            this.grpPath.Size = new System.Drawing.Size(382, 80);
            this.grpPath.TabIndex = 1;
            this.grpPath.TabStop = false;
            this.grpPath.Text = "     出发点                目的地";
            // 
            // btnQuery
            // 
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(290, 33);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbEnd
            // 
            this.cmbEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbEnd.FormattingEnabled = true;
            this.cmbEnd.Location = new System.Drawing.Point(166, 31);
            this.cmbEnd.Name = "cmbEnd";
            this.cmbEnd.Size = new System.Drawing.Size(121, 28);
            this.cmbEnd.TabIndex = 1;
            this.cmbEnd.SelectedIndexChanged += new System.EventHandler(this.cmbEnd_SelectedIndexChanged);
            // 
            // cmbStart
            // 
            this.cmbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.Location = new System.Drawing.Point(38, 31);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(121, 28);
            this.cmbStart.TabIndex = 0;
            this.cmbStart.SelectedIndexChanged += new System.EventHandler(this.cmbStart_SelectedIndexChanged);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.txtTime);
            this.grpResult.Controls.Add(this.txtDis);
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpResult.Location = new System.Drawing.Point(526, 12);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(490, 80);
            this.grpResult.TabIndex = 2;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "途经站点";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Location = new System.Drawing.Point(366, 50);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 23);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "预计耗时";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDis
            // 
            this.txtDis.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDis.Location = new System.Drawing.Point(366, 28);
            this.txtDis.Name = "txtDis";
            this.txtDis.ReadOnly = true;
            this.txtDis.Size = new System.Drawing.Size(100, 23);
            this.txtDis.TabIndex = 1;
            this.txtDis.Text = "预计里程";
            this.txtDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            this.txtResult.CausesValidation = false;
            this.txtResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(7, 28);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(337, 46);
            this.txtResult.TabIndex = 0;
            // 
            // picMap
            // 
            this.picMap.BackgroundImage = global::ChengduMetro3._0.Properties.Resources.成都地铁线路图1;
            this.picMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMap.Cursor = System.Windows.Forms.Cursors.No;
            this.picMap.Location = new System.Drawing.Point(13, 99);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(1003, 800);
            this.picMap.TabIndex = 3;
            this.picMap.TabStop = false;
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1034, 911);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpPath);
            this.Controls.Add(this.grpMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainfrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChengduMetroQuery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpPath.ResumeLayout(false);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.CheckBox chkDis;
        private System.Windows.Forms.GroupBox grpPath;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbEnd;
        private System.Windows.Forms.ComboBox cmbStart;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.PictureBox picMap;
    }
}

