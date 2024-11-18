namespace datainput
{
    partial class FrmPointSet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPointSet));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Check = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column_Id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Point2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPoint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAvgSelect = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.nAvgSelect = new System.Windows.Forms.NumericUpDown();
            this.lb4 = new System.Windows.Forms.Label();
            this.nAvg = new System.Windows.Forms.NumericUpDown();
            this.lb3 = new System.Windows.Forms.Label();
            this.nMin = new System.Windows.Forms.NumericUpDown();
            this.lb2 = new System.Windows.Forms.Label();
            this.nMax = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAvgSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMax)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Id,
            this.Column_Name,
            this.Column_Point,
            this.Column_Check});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(385, 193);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_Id
            // 
            this.Column_Id.DataPropertyName = "Id";
            this.Column_Id.HeaderText = "编号";
            this.Column_Id.Name = "Column_Id";
            this.Column_Id.ReadOnly = true;
            this.Column_Id.Width = 40;
            // 
            // Column_Name
            // 
            this.Column_Name.DataPropertyName = "Name";
            this.Column_Name.HeaderText = "姓名";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_Point
            // 
            this.Column_Point.DataPropertyName = "Point";
            this.Column_Point.HeaderText = "票房";
            this.Column_Point.Name = "Column_Point";
            this.Column_Point.ReadOnly = true;
            // 
            // Column_Check
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "选择";
            this.Column_Check.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_Check.HeaderText = "选择";
            this.Column_Check.Name = "Column_Check";
            this.Column_Check.ReadOnly = true;
            this.Column_Check.Text = "选择";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Id2,
            this.Column_Name2,
            this.Column_Point2,
            this.Column_Cancel});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.Location = new System.Drawing.Point(14, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(385, 193);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column_Id2
            // 
            this.Column_Id2.DataPropertyName = "Id";
            this.Column_Id2.HeaderText = "编号";
            this.Column_Id2.Name = "Column_Id2";
            this.Column_Id2.ReadOnly = true;
            this.Column_Id2.Width = 40;
            // 
            // Column_Name2
            // 
            this.Column_Name2.DataPropertyName = "Name";
            this.Column_Name2.HeaderText = "姓名";
            this.Column_Name2.Name = "Column_Name2";
            this.Column_Name2.ReadOnly = true;
            // 
            // Column_Point2
            // 
            this.Column_Point2.DataPropertyName = "Point";
            this.Column_Point2.HeaderText = "票房";
            this.Column_Point2.Name = "Column_Point2";
            this.Column_Point2.ReadOnly = true;
            // 
            // Column_Cancel
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "取消";
            this.Column_Cancel.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column_Cancel.HeaderText = "取消";
            this.Column_Cancel.Name = "Column_Cancel";
            this.Column_Cancel.ReadOnly = true;
            this.Column_Cancel.Text = "取消";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbPoint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAvgSelect);
            this.groupBox1.Controls.Add(this.btnAvg);
            this.groupBox1.Controls.Add(this.btnMin);
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.nAvgSelect);
            this.groupBox1.Controls.Add(this.lb4);
            this.groupBox1.Controls.Add(this.nAvg);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.nMin);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.nMax);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Location = new System.Drawing.Point(416, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbPoint
            // 
            this.lbPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPoint.AutoSize = true;
            this.lbPoint.BackColor = System.Drawing.Color.Transparent;
            this.lbPoint.Enabled = false;
            this.lbPoint.ForeColor = System.Drawing.Color.Red;
            this.lbPoint.Location = new System.Drawing.Point(90, 135);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(11, 12);
            this.lbPoint.TabIndex = 13;
            this.lbPoint.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "选中值：";
            // 
            // btnAvgSelect
            // 
            this.btnAvgSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvgSelect.Location = new System.Drawing.Point(197, 98);
            this.btnAvgSelect.Name = "btnAvgSelect";
            this.btnAvgSelect.Size = new System.Drawing.Size(75, 23);
            this.btnAvgSelect.TabIndex = 11;
            this.btnAvgSelect.Text = "设置";
            this.btnAvgSelect.UseVisualStyleBackColor = true;
            this.btnAvgSelect.Click += new System.EventHandler(this.btnAvgSelect_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvg.Location = new System.Drawing.Point(198, 71);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(75, 23);
            this.btnAvg.TabIndex = 8;
            this.btnAvg.Text = "设置";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Location = new System.Drawing.Point(198, 44);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "设置";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Location = new System.Drawing.Point(198, 20);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 23);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "设置";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // nAvgSelect
            // 
            this.nAvgSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nAvgSelect.DecimalPlaces = 2;
            this.nAvgSelect.Location = new System.Drawing.Point(92, 101);
            this.nAvgSelect.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nAvgSelect.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nAvgSelect.Name = "nAvgSelect";
            this.nAvgSelect.Size = new System.Drawing.Size(100, 21);
            this.nAvgSelect.TabIndex = 10;
            // 
            // lb4
            // 
            this.lb4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.Color.Transparent;
            this.lb4.Enabled = false;
            this.lb4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb4.Location = new System.Drawing.Point(15, 103);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(77, 12);
            this.lb4.TabIndex = 9;
            this.lb4.Text = "选中平均值：";
            // 
            // nAvg
            // 
            this.nAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nAvg.DecimalPlaces = 2;
            this.nAvg.Location = new System.Drawing.Point(92, 74);
            this.nAvg.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nAvg.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nAvg.Name = "nAvg";
            this.nAvg.Size = new System.Drawing.Size(100, 21);
            this.nAvg.TabIndex = 7;
            // 
            // lb3
            // 
            this.lb3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Enabled = false;
            this.lb3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb3.Location = new System.Drawing.Point(15, 76);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(53, 12);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "平均值：";
            // 
            // nMin
            // 
            this.nMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nMin.DecimalPlaces = 2;
            this.nMin.Location = new System.Drawing.Point(92, 47);
            this.nMin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nMin.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nMin.Name = "nMin";
            this.nMin.Size = new System.Drawing.Size(100, 21);
            this.nMin.TabIndex = 4;
            // 
            // lb2
            // 
            this.lb2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Enabled = false;
            this.lb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb2.Location = new System.Drawing.Point(15, 49);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 12);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "最小值：";
            // 
            // nMax
            // 
            this.nMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nMax.DecimalPlaces = 2;
            this.nMax.Location = new System.Drawing.Point(92, 20);
            this.nMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nMax.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nMax.Name = "nMax";
            this.nMax.Size = new System.Drawing.Size(100, 21);
            this.nMax.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(194, 146);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 39);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Enabled = false;
            this.lb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb1.Location = new System.Drawing.Point(15, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "最大值：";
            // 
            // FrmPointSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPointSet";
            this.Text = "电影票房预测系统";
            this.Load += new System.EventHandler(this.FrmPointSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAvgSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.NumericUpDown nAvgSelect;
        private System.Windows.Forms.NumericUpDown nAvg;
        private System.Windows.Forms.NumericUpDown nMin;
        private System.Windows.Forms.NumericUpDown nMax;
        private System.Windows.Forms.Button btnAvgSelect;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Point;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Point2;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Cancel;
    }
}