namespace SeComTool
{
    partial class Form1
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
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblByteCount = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtByteCount = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblPreambles = new System.Windows.Forms.Label();
            this.lblCheckSum = new System.Windows.Forms.Label();
            this.numUDPreambles = new System.Windows.Forms.NumericUpDown();
            this.txtCheckSum = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelegramPreview = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFloat1 = new System.Windows.Forms.TextBox();
            this.txtHex1 = new System.Windows.Forms.TextBox();
            this.ckBoxFloat2 = new System.Windows.Forms.CheckBox();
            this.txtFloat2 = new System.Windows.Forms.TextBox();
            this.txtHex2 = new System.Windows.Forms.TextBox();
            this.ckBoxFloat3 = new System.Windows.Forms.CheckBox();
            this.ckBoxFloat4 = new System.Windows.Forms.CheckBox();
            this.txtFloat3 = new System.Windows.Forms.TextBox();
            this.txtFloat4 = new System.Windows.Forms.TextBox();
            this.txtHex3 = new System.Windows.Forms.TextBox();
            this.txtHex4 = new System.Windows.Forms.TextBox();
            this.ckBoxFloat1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHex5 = new System.Windows.Forms.TextBox();
            this.txtFloat5 = new System.Windows.Forms.TextBox();
            this.ckBoxHex2 = new System.Windows.Forms.CheckBox();
            this.txtHex6 = new System.Windows.Forms.TextBox();
            this.txtFloat6 = new System.Windows.Forms.TextBox();
            this.ckBoxHex3 = new System.Windows.Forms.CheckBox();
            this.ckBoxHex4 = new System.Windows.Forms.CheckBox();
            this.txtHex7 = new System.Windows.Forms.TextBox();
            this.txtHex8 = new System.Windows.Forms.TextBox();
            this.txtFloat7 = new System.Windows.Forms.TextBox();
            this.txtFloat8 = new System.Windows.Forms.TextBox();
            this.ckBoxHex1 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtobjHex1 = new System.Windows.Forms.TextBox();
            this.txtobjDec1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtobjHex2 = new System.Windows.Forms.TextBox();
            this.txtobjDec2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPreambles)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Location = new System.Drawing.Point(3, 26);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(47, 13);
            this.lblDelimiter.TabIndex = 0;
            this.lblDelimiter.Text = "Delimiter";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 52);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.93764F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.06236F));
            this.tableLayoutPanel1.Controls.Add(this.lblCommand, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDelimiter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblByteCount, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblData, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDelimiter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCommand, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtByteCount, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtData, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPreambles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCheckSum, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.numUDPreambles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCheckSum, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerate, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnPreview, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 209);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(3, 78);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(54, 13);
            this.lblCommand.TabIndex = 3;
            this.lblCommand.Text = "Command";
            // 
            // lblByteCount
            // 
            this.lblByteCount.AutoSize = true;
            this.lblByteCount.Location = new System.Drawing.Point(3, 104);
            this.lblByteCount.Name = "lblByteCount";
            this.lblByteCount.Size = new System.Drawing.Size(59, 13);
            this.lblByteCount.TabIndex = 2;
            this.lblByteCount.Text = "Byte Count";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 130);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(80, 29);
            this.txtDelimiter.MaxLength = 2;
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(328, 20);
            this.txtDelimiter.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAddress.Location = new System.Drawing.Point(80, 55);
            this.txtAddress.MaxLength = 14;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(328, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(80, 81);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(328, 20);
            this.txtCommand.TabIndex = 6;
            // 
            // txtByteCount
            // 
            this.txtByteCount.Location = new System.Drawing.Point(80, 107);
            this.txtByteCount.Name = "txtByteCount";
            this.txtByteCount.Size = new System.Drawing.Size(328, 20);
            this.txtByteCount.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(80, 133);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(328, 20);
            this.txtData.TabIndex = 8;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            // 
            // lblPreambles
            // 
            this.lblPreambles.AutoSize = true;
            this.lblPreambles.Location = new System.Drawing.Point(3, 0);
            this.lblPreambles.Name = "lblPreambles";
            this.lblPreambles.Size = new System.Drawing.Size(56, 13);
            this.lblPreambles.TabIndex = 9;
            this.lblPreambles.Text = "Preambles";
            // 
            // lblCheckSum
            // 
            this.lblCheckSum.AutoSize = true;
            this.lblCheckSum.Location = new System.Drawing.Point(3, 156);
            this.lblCheckSum.Name = "lblCheckSum";
            this.lblCheckSum.Size = new System.Drawing.Size(59, 13);
            this.lblCheckSum.TabIndex = 10;
            this.lblCheckSum.Text = "CheckSum";
            // 
            // numUDPreambles
            // 
            this.numUDPreambles.Location = new System.Drawing.Point(80, 3);
            this.numUDPreambles.Name = "numUDPreambles";
            this.numUDPreambles.Size = new System.Drawing.Size(65, 20);
            this.numUDPreambles.TabIndex = 11;
            // 
            // txtCheckSum
            // 
            this.txtCheckSum.Location = new System.Drawing.Point(80, 159);
            this.txtCheckSum.Name = "txtCheckSum";
            this.txtCheckSum.Size = new System.Drawing.Size(328, 20);
            this.txtCheckSum.TabIndex = 12;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(3, 185);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(71, 21);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(80, 185);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(121, 21);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Data Builder for TCA";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 227);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(411, 212);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelegramPreview);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telegram Preview:";
            // 
            // txtTelegramPreview
            // 
            this.txtTelegramPreview.Location = new System.Drawing.Point(6, 19);
            this.txtTelegramPreview.Multiline = true;
            this.txtTelegramPreview.Name = "txtTelegramPreview";
            this.txtTelegramPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTelegramPreview.Size = new System.Drawing.Size(396, 181);
            this.txtTelegramPreview.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFloat1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHex1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ckBoxFloat2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtFloat2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtHex2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ckBoxFloat3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ckBoxFloat4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtFloat3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtFloat4, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtHex3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtHex4, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.ckBoxFloat1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 115);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Float";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Swap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hex";
            // 
            // txtFloat1
            // 
            this.txtFloat1.Location = new System.Drawing.Point(53, 16);
            this.txtFloat1.Name = "txtFloat1";
            this.txtFloat1.Size = new System.Drawing.Size(100, 20);
            this.txtFloat1.TabIndex = 4;
            this.txtFloat1.TextChanged += new System.EventHandler(this.txtFloat1_TextChanged);
            this.txtFloat1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1_KeyPress);
            // 
            // txtHex1
            // 
            this.txtHex1.Location = new System.Drawing.Point(159, 16);
            this.txtHex1.Name = "txtHex1";
            this.txtHex1.Size = new System.Drawing.Size(103, 20);
            this.txtHex1.TabIndex = 5;
            // 
            // ckBoxFloat2
            // 
            this.ckBoxFloat2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxFloat2.AutoSize = true;
            this.ckBoxFloat2.Location = new System.Drawing.Point(17, 44);
            this.ckBoxFloat2.Name = "ckBoxFloat2";
            this.ckBoxFloat2.Size = new System.Drawing.Size(15, 14);
            this.ckBoxFloat2.TabIndex = 6;
            this.ckBoxFloat2.UseVisualStyleBackColor = true;
            // 
            // txtFloat2
            // 
            this.txtFloat2.Location = new System.Drawing.Point(53, 42);
            this.txtFloat2.Name = "txtFloat2";
            this.txtFloat2.Size = new System.Drawing.Size(100, 20);
            this.txtFloat2.TabIndex = 7;
            this.txtFloat2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat2_KeyPress);
            // 
            // txtHex2
            // 
            this.txtHex2.Location = new System.Drawing.Point(159, 42);
            this.txtHex2.Name = "txtHex2";
            this.txtHex2.Size = new System.Drawing.Size(103, 20);
            this.txtHex2.TabIndex = 8;
            // 
            // ckBoxFloat3
            // 
            this.ckBoxFloat3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxFloat3.AutoSize = true;
            this.ckBoxFloat3.Location = new System.Drawing.Point(17, 68);
            this.ckBoxFloat3.Name = "ckBoxFloat3";
            this.ckBoxFloat3.Size = new System.Drawing.Size(15, 14);
            this.ckBoxFloat3.TabIndex = 9;
            this.ckBoxFloat3.UseVisualStyleBackColor = true;
            // 
            // ckBoxFloat4
            // 
            this.ckBoxFloat4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxFloat4.AutoSize = true;
            this.ckBoxFloat4.Location = new System.Drawing.Point(17, 94);
            this.ckBoxFloat4.Name = "ckBoxFloat4";
            this.ckBoxFloat4.Size = new System.Drawing.Size(15, 14);
            this.ckBoxFloat4.TabIndex = 10;
            this.ckBoxFloat4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ckBoxFloat4.UseVisualStyleBackColor = true;
            // 
            // txtFloat3
            // 
            this.txtFloat3.Location = new System.Drawing.Point(53, 66);
            this.txtFloat3.Name = "txtFloat3";
            this.txtFloat3.Size = new System.Drawing.Size(100, 20);
            this.txtFloat3.TabIndex = 11;
            this.txtFloat3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat3_KeyPress);
            // 
            // txtFloat4
            // 
            this.txtFloat4.Location = new System.Drawing.Point(53, 91);
            this.txtFloat4.Name = "txtFloat4";
            this.txtFloat4.Size = new System.Drawing.Size(100, 20);
            this.txtFloat4.TabIndex = 12;
            this.txtFloat4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat4_KeyPress);
            // 
            // txtHex3
            // 
            this.txtHex3.Location = new System.Drawing.Point(159, 66);
            this.txtHex3.Name = "txtHex3";
            this.txtHex3.Size = new System.Drawing.Size(103, 20);
            this.txtHex3.TabIndex = 13;
            // 
            // txtHex4
            // 
            this.txtHex4.Location = new System.Drawing.Point(159, 91);
            this.txtHex4.Name = "txtHex4";
            this.txtHex4.Size = new System.Drawing.Size(103, 20);
            this.txtHex4.TabIndex = 14;
            // 
            // ckBoxFloat1
            // 
            this.ckBoxFloat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxFloat1.AutoSize = true;
            this.ckBoxFloat1.Location = new System.Drawing.Point(17, 19);
            this.ckBoxFloat1.Name = "ckBoxFloat1";
            this.ckBoxFloat1.Size = new System.Drawing.Size(15, 14);
            this.ckBoxFloat1.TabIndex = 0;
            this.ckBoxFloat1.UseVisualStyleBackColor = true;
            this.ckBoxFloat1.CheckedChanged += new System.EventHandler(this.ckBoxFloat1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(429, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Float To Hex";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(635, 416);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(429, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 138);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hex To Float";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtHex5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtFloat5, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.ckBoxHex2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtHex6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtFloat6, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.ckBoxHex3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.ckBoxHex4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtHex7, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtHex8, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtFloat7, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtFloat8, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.ckBoxHex1, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 15);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(274, 117);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Swap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Float";
            // 
            // txtHex5
            // 
            this.txtHex5.Location = new System.Drawing.Point(53, 16);
            this.txtHex5.MaxLength = 11;
            this.txtHex5.Name = "txtHex5";
            this.txtHex5.Size = new System.Drawing.Size(100, 20);
            this.txtHex5.TabIndex = 4;
            this.txtHex5.TextChanged += new System.EventHandler(this.txtHex5_TextChanged);
            this.txtHex5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex5_KeyPress);
            // 
            // txtFloat5
            // 
            this.txtFloat5.Location = new System.Drawing.Point(159, 16);
            this.txtFloat5.Name = "txtFloat5";
            this.txtFloat5.Size = new System.Drawing.Size(103, 20);
            this.txtFloat5.TabIndex = 5;
            // 
            // ckBoxHex2
            // 
            this.ckBoxHex2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxHex2.AutoSize = true;
            this.ckBoxHex2.Location = new System.Drawing.Point(17, 44);
            this.ckBoxHex2.Name = "ckBoxHex2";
            this.ckBoxHex2.Size = new System.Drawing.Size(15, 14);
            this.ckBoxHex2.TabIndex = 6;
            this.ckBoxHex2.UseVisualStyleBackColor = true;
            this.ckBoxHex2.CheckedChanged += new System.EventHandler(this.ckBoxHex2_CheckedChanged);
            // 
            // txtHex6
            // 
            this.txtHex6.Location = new System.Drawing.Point(53, 42);
            this.txtHex6.MaxLength = 11;
            this.txtHex6.Name = "txtHex6";
            this.txtHex6.Size = new System.Drawing.Size(100, 20);
            this.txtHex6.TabIndex = 7;
            this.txtHex6.TextChanged += new System.EventHandler(this.txtHex6_TextChanged);
            this.txtHex6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex6_KeyPress);
            // 
            // txtFloat6
            // 
            this.txtFloat6.Location = new System.Drawing.Point(159, 42);
            this.txtFloat6.Name = "txtFloat6";
            this.txtFloat6.Size = new System.Drawing.Size(103, 20);
            this.txtFloat6.TabIndex = 8;
            // 
            // ckBoxHex3
            // 
            this.ckBoxHex3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxHex3.AutoSize = true;
            this.ckBoxHex3.Location = new System.Drawing.Point(17, 68);
            this.ckBoxHex3.Name = "ckBoxHex3";
            this.ckBoxHex3.Size = new System.Drawing.Size(15, 14);
            this.ckBoxHex3.TabIndex = 9;
            this.ckBoxHex3.UseVisualStyleBackColor = true;
            this.ckBoxHex3.CheckedChanged += new System.EventHandler(this.ckBoxHex3_CheckedChanged);
            // 
            // ckBoxHex4
            // 
            this.ckBoxHex4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxHex4.AutoSize = true;
            this.ckBoxHex4.Location = new System.Drawing.Point(17, 95);
            this.ckBoxHex4.Name = "ckBoxHex4";
            this.ckBoxHex4.Size = new System.Drawing.Size(15, 14);
            this.ckBoxHex4.TabIndex = 10;
            this.ckBoxHex4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ckBoxHex4.UseVisualStyleBackColor = true;
            this.ckBoxHex4.CheckedChanged += new System.EventHandler(this.ckBoxHex4_CheckedChanged);
            // 
            // txtHex7
            // 
            this.txtHex7.Location = new System.Drawing.Point(53, 66);
            this.txtHex7.MaxLength = 11;
            this.txtHex7.Name = "txtHex7";
            this.txtHex7.Size = new System.Drawing.Size(100, 20);
            this.txtHex7.TabIndex = 11;
            this.txtHex7.TextChanged += new System.EventHandler(this.txtHex7_TextChanged);
            this.txtHex7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex7_KeyPress);
            // 
            // txtHex8
            // 
            this.txtHex8.Location = new System.Drawing.Point(53, 91);
            this.txtHex8.MaxLength = 11;
            this.txtHex8.Name = "txtHex8";
            this.txtHex8.Size = new System.Drawing.Size(100, 20);
            this.txtHex8.TabIndex = 12;
            this.txtHex8.TextChanged += new System.EventHandler(this.txtHex8_TextChanged);
            this.txtHex8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex8_KeyPress);
            // 
            // txtFloat7
            // 
            this.txtFloat7.Location = new System.Drawing.Point(159, 66);
            this.txtFloat7.Name = "txtFloat7";
            this.txtFloat7.Size = new System.Drawing.Size(103, 20);
            this.txtFloat7.TabIndex = 13;
            // 
            // txtFloat8
            // 
            this.txtFloat8.Location = new System.Drawing.Point(159, 91);
            this.txtFloat8.Name = "txtFloat8";
            this.txtFloat8.Size = new System.Drawing.Size(103, 20);
            this.txtFloat8.TabIndex = 14;
            // 
            // ckBoxHex1
            // 
            this.ckBoxHex1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckBoxHex1.AutoSize = true;
            this.ckBoxHex1.Location = new System.Drawing.Point(17, 19);
            this.ckBoxHex1.Name = "ckBoxHex1";
            this.ckBoxHex1.Size = new System.Drawing.Size(15, 14);
            this.ckBoxHex1.TabIndex = 0;
            this.ckBoxHex1.UseVisualStyleBackColor = true;
            this.ckBoxHex1.CheckedChanged += new System.EventHandler(this.ckBoxHex1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Location = new System.Drawing.Point(429, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 113);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Object <-> Dec";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtobjHex1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtobjDec1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtobjHex2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtobjDec2, 1, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(268, 88);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtobjHex1
            // 
            this.txtobjHex1.Location = new System.Drawing.Point(137, 20);
            this.txtobjHex1.Name = "txtobjHex1";
            this.txtobjHex1.Size = new System.Drawing.Size(128, 20);
            this.txtobjHex1.TabIndex = 0;
            // 
            // txtobjDec1
            // 
            this.txtobjDec1.Location = new System.Drawing.Point(3, 20);
            this.txtobjDec1.Name = "txtobjDec1";
            this.txtobjDec1.Size = new System.Drawing.Size(128, 20);
            this.txtobjDec1.TabIndex = 1;
            this.txtobjDec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtobjDec1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Decimal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Hex";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hex";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Decimal";
            // 
            // txtobjHex2
            // 
            this.txtobjHex2.Location = new System.Drawing.Point(3, 63);
            this.txtobjHex2.MaxLength = 5;
            this.txtobjHex2.Name = "txtobjHex2";
            this.txtobjHex2.Size = new System.Drawing.Size(128, 20);
            this.txtobjHex2.TabIndex = 6;
            this.txtobjHex2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtobjHex2_KeyPress);
            // 
            // txtobjDec2
            // 
            this.txtobjDec2.Location = new System.Drawing.Point(137, 63);
            this.txtobjDec2.Name = "txtobjDec2";
            this.txtobjDec2.Size = new System.Drawing.Size(128, 20);
            this.txtobjDec2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "GDC: Local: 0x1D, Global: 0x21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 451);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "SeCom Tool";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPreambles)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblByteCount;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtByteCount;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblPreambles;
        private System.Windows.Forms.Label lblCheckSum;
        private System.Windows.Forms.NumericUpDown numUDPreambles;
        private System.Windows.Forms.TextBox txtCheckSum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelegramPreview;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckBoxFloat1;
        private System.Windows.Forms.TextBox txtHex1;
        private System.Windows.Forms.CheckBox ckBoxFloat2;
        private System.Windows.Forms.TextBox txtHex2;
        private System.Windows.Forms.CheckBox ckBoxFloat3;
        private System.Windows.Forms.CheckBox ckBoxFloat4;
        private System.Windows.Forms.TextBox txtHex3;
        private System.Windows.Forms.TextBox txtHex4;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFloat1;
        private System.Windows.Forms.TextBox txtFloat2;
        private System.Windows.Forms.TextBox txtFloat3;
        private System.Windows.Forms.TextBox txtFloat4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHex5;
        private System.Windows.Forms.TextBox txtFloat5;
        private System.Windows.Forms.CheckBox ckBoxHex2;
        private System.Windows.Forms.TextBox txtHex6;
        private System.Windows.Forms.TextBox txtFloat6;
        private System.Windows.Forms.CheckBox ckBoxHex3;
        private System.Windows.Forms.CheckBox ckBoxHex4;
        private System.Windows.Forms.TextBox txtHex7;
        private System.Windows.Forms.TextBox txtHex8;
        private System.Windows.Forms.TextBox txtFloat7;
        private System.Windows.Forms.TextBox txtFloat8;
        private System.Windows.Forms.CheckBox ckBoxHex1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtobjHex1;
        private System.Windows.Forms.TextBox txtobjDec1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtobjHex2;
        private System.Windows.Forms.TextBox txtobjDec2;
        private System.Windows.Forms.Label label11;
    }
}

