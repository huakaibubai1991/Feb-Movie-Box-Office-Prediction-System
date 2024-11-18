namespace datainput
{
    partial class FrmForecast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForecast));
            this.btnSearch = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtActor1Name000 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nScreenwriterPoint = new System.Windows.Forms.NumericUpDown();
            this.lb7 = new System.Windows.Forms.Label();
            this.txtScreenwriterName = new System.Windows.Forms.TextBox();
            this.nProducerPoint = new System.Windows.Forms.NumericUpDown();
            this.lb6 = new System.Windows.Forms.Label();
            this.txtProducerName = new System.Windows.Forms.TextBox();
            this.nDirectorPoint = new System.Windows.Forms.NumericUpDown();
            this.lb5 = new System.Windows.Forms.Label();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.nActress2Point = new System.Windows.Forms.NumericUpDown();
            this.lb4 = new System.Windows.Forms.Label();
            this.txtActress2Name = new System.Windows.Forms.TextBox();
            this.nActress1Point = new System.Windows.Forms.NumericUpDown();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtActress1Name = new System.Windows.Forms.TextBox();
            this.nActor2Point = new System.Windows.Forms.NumericUpDown();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtActor2Name = new System.Windows.Forms.TextBox();
            this.nActor1Point = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScreenwriterPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nProducerPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDirectorPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActress2Point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActress1Point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActor2Point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActor1Point)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(194, 313);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 39);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "预测";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Enabled = false;
            this.lb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb1.Location = new System.Drawing.Point(15, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(41, 12);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "男一：";
            // 
            // txtActor1Name000
            // 
            this.txtActor1Name000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtActor1Name000.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtActor1Name000.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtActor1Name000.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtActor1Name000.Location = new System.Drawing.Point(57, 19);
            this.txtActor1Name000.Name = "txtActor1Name000";
            this.txtActor1Name000.Size = new System.Drawing.Size(100, 21);
            this.txtActor1Name000.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nScreenwriterPoint);
            this.groupBox1.Controls.Add(this.lb7);
            this.groupBox1.Controls.Add(this.txtScreenwriterName);
            this.groupBox1.Controls.Add(this.nProducerPoint);
            this.groupBox1.Controls.Add(this.lb6);
            this.groupBox1.Controls.Add(this.txtProducerName);
            this.groupBox1.Controls.Add(this.nDirectorPoint);
            this.groupBox1.Controls.Add(this.lb5);
            this.groupBox1.Controls.Add(this.txtDirectorName);
            this.groupBox1.Controls.Add(this.nActress2Point);
            this.groupBox1.Controls.Add(this.lb4);
            this.groupBox1.Controls.Add(this.txtActress2Name);
            this.groupBox1.Controls.Add(this.nActress1Point);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.txtActress1Name);
            this.groupBox1.Controls.Add(this.nActor2Point);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.txtActor2Name);
            this.groupBox1.Controls.Add(this.nActor1Point);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.txtActor1Name000);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 392);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // nScreenwriterPoint
            // 
            this.nScreenwriterPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nScreenwriterPoint.DecimalPlaces = 2;
            this.nScreenwriterPoint.Enabled = false;
            this.nScreenwriterPoint.Location = new System.Drawing.Point(172, 155);
            this.nScreenwriterPoint.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nScreenwriterPoint.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nScreenwriterPoint.Name = "nScreenwriterPoint";
            this.nScreenwriterPoint.Size = new System.Drawing.Size(100, 21);
            this.nScreenwriterPoint.TabIndex = 19;
            // 
            // lb7
            // 
            this.lb7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb7.AutoSize = true;
            this.lb7.BackColor = System.Drawing.Color.Transparent;
            this.lb7.Enabled = false;
            this.lb7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb7.Location = new System.Drawing.Point(15, 184);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(41, 12);
            this.lb7.TabIndex = 12;
            this.lb7.Text = "制片：";
            // 
            // txtScreenwriterName
            // 
            this.txtScreenwriterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtScreenwriterName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtScreenwriterName.Location = new System.Drawing.Point(57, 155);
            this.txtScreenwriterName.Name = "txtScreenwriterName";
            this.txtScreenwriterName.Size = new System.Drawing.Size(100, 21);
            this.txtScreenwriterName.TabIndex = 11;
            // 
            // nProducerPoint
            // 
            this.nProducerPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nProducerPoint.DecimalPlaces = 2;
            this.nProducerPoint.Enabled = false;
            this.nProducerPoint.Location = new System.Drawing.Point(172, 182);
            this.nProducerPoint.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nProducerPoint.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nProducerPoint.Name = "nProducerPoint";
            this.nProducerPoint.Size = new System.Drawing.Size(100, 21);
            this.nProducerPoint.TabIndex = 20;
            // 
            // lb6
            // 
            this.lb6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb6.AutoSize = true;
            this.lb6.BackColor = System.Drawing.Color.Transparent;
            this.lb6.Enabled = false;
            this.lb6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb6.Location = new System.Drawing.Point(15, 157);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(41, 12);
            this.lb6.TabIndex = 10;
            this.lb6.Text = "编剧：";
            // 
            // txtProducerName
            // 
            this.txtProducerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProducerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtProducerName.Location = new System.Drawing.Point(57, 181);
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.Size = new System.Drawing.Size(100, 21);
            this.txtProducerName.TabIndex = 13;
            // 
            // nDirectorPoint
            // 
            this.nDirectorPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nDirectorPoint.DecimalPlaces = 2;
            this.nDirectorPoint.Enabled = false;
            this.nDirectorPoint.Location = new System.Drawing.Point(172, 128);
            this.nDirectorPoint.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nDirectorPoint.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nDirectorPoint.Name = "nDirectorPoint";
            this.nDirectorPoint.Size = new System.Drawing.Size(100, 21);
            this.nDirectorPoint.TabIndex = 18;
            // 
            // lb5
            // 
            this.lb5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.Color.Transparent;
            this.lb5.Enabled = false;
            this.lb5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb5.Location = new System.Drawing.Point(15, 130);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(41, 12);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "导演：";
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDirectorName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDirectorName.Location = new System.Drawing.Point(57, 127);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(100, 21);
            this.txtDirectorName.TabIndex = 9;
            // 
            // nActress2Point
            // 
            this.nActress2Point.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nActress2Point.DecimalPlaces = 2;
            this.nActress2Point.Enabled = false;
            this.nActress2Point.Location = new System.Drawing.Point(172, 101);
            this.nActress2Point.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nActress2Point.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nActress2Point.Name = "nActress2Point";
            this.nActress2Point.Size = new System.Drawing.Size(100, 21);
            this.nActress2Point.TabIndex = 17;
            // 
            // lb4
            // 
            this.lb4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.Color.Transparent;
            this.lb4.Enabled = false;
            this.lb4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb4.Location = new System.Drawing.Point(15, 103);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(41, 12);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "女二：";
            // 
            // txtActress2Name
            // 
            this.txtActress2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtActress2Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtActress2Name.Location = new System.Drawing.Point(57, 100);
            this.txtActress2Name.Name = "txtActress2Name";
            this.txtActress2Name.Size = new System.Drawing.Size(100, 21);
            this.txtActress2Name.TabIndex = 7;
            // 
            // nActress1Point
            // 
            this.nActress1Point.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nActress1Point.DecimalPlaces = 2;
            this.nActress1Point.Enabled = false;
            this.nActress1Point.Location = new System.Drawing.Point(172, 74);
            this.nActress1Point.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nActress1Point.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nActress1Point.Name = "nActress1Point";
            this.nActress1Point.Size = new System.Drawing.Size(100, 21);
            this.nActress1Point.TabIndex = 16;
            // 
            // lb3
            // 
            this.lb3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Enabled = false;
            this.lb3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb3.Location = new System.Drawing.Point(15, 76);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(41, 12);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "女一：";
            // 
            // txtActress1Name
            // 
            this.txtActress1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtActress1Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtActress1Name.Location = new System.Drawing.Point(57, 73);
            this.txtActress1Name.Name = "txtActress1Name";
            this.txtActress1Name.Size = new System.Drawing.Size(100, 21);
            this.txtActress1Name.TabIndex = 5;
            // 
            // nActor2Point
            // 
            this.nActor2Point.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nActor2Point.DecimalPlaces = 2;
            this.nActor2Point.Enabled = false;
            this.nActor2Point.Location = new System.Drawing.Point(172, 47);
            this.nActor2Point.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nActor2Point.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nActor2Point.Name = "nActor2Point";
            this.nActor2Point.Size = new System.Drawing.Size(100, 21);
            this.nActor2Point.TabIndex = 15;
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Enabled = false;
            this.lb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb2.Location = new System.Drawing.Point(15, 49);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(41, 12);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "男二：";
            // 
            // txtActor2Name
            // 
            this.txtActor2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtActor2Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtActor2Name.Location = new System.Drawing.Point(57, 46);
            this.txtActor2Name.Name = "txtActor2Name";
            this.txtActor2Name.Size = new System.Drawing.Size(100, 21);
            this.txtActor2Name.TabIndex = 3;
            // 
            // nActor1Point
            // 
            this.nActor1Point.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nActor1Point.DecimalPlaces = 2;
            this.nActor1Point.Enabled = false;
            this.nActor1Point.Location = new System.Drawing.Point(172, 20);
            this.nActor1Point.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nActor1Point.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nActor1Point.Name = "nActor1Point";
            this.nActor1Point.Size = new System.Drawing.Size(100, 21);
            this.nActor1Point.TabIndex = 14;
            this.nActor1Point.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nActor1Point_KeyDown);
            // 
            // FrmForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 416);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmForecast";
            this.Text = "Feb电影票房预测系统";
            this.Load += new System.EventHandler(this.FrmForecast_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmForecast_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScreenwriterPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nProducerPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDirectorPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActress2Point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActress1Point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActor2Point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActor1Point)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtActor1Name000;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nActor1Point;
        private System.Windows.Forms.NumericUpDown nActor2Point;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtActor2Name;
        private System.Windows.Forms.NumericUpDown nDirectorPoint;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.NumericUpDown nActress2Point;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txtActress2Name;
        private System.Windows.Forms.NumericUpDown nActress1Point;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txtActress1Name;
        private System.Windows.Forms.NumericUpDown nScreenwriterPoint;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.TextBox txtScreenwriterName;
        private System.Windows.Forms.NumericUpDown nProducerPoint;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.TextBox txtProducerName;
    }
}