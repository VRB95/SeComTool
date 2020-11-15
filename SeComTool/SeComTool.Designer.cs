namespace SeComTool
{
    partial class SeComTool
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
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelegramPreview = new System.Windows.Forms.TextBox();
            this.txtFloat1 = new System.Windows.Forms.TextBox();
            this.txtHexHART1 = new System.Windows.Forms.TextBox();
            this.txtFloat2 = new System.Windows.Forms.TextBox();
            this.txtHexHART2 = new System.Windows.Forms.TextBox();
            this.txtFloat3 = new System.Windows.Forms.TextBox();
            this.txtFloat4 = new System.Windows.Forms.TextBox();
            this.txtHexHART3 = new System.Windows.Forms.TextBox();
            this.txtHexHART4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHexGDC1 = new System.Windows.Forms.TextBox();
            this.txtHexGDC2 = new System.Windows.Forms.TextBox();
            this.txtHexGDC3 = new System.Windows.Forms.TextBox();
            this.txtHexGDC4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtobjHART1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtobjGDC1 = new System.Windows.Forms.TextBox();
            this.txtobjDec1 = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_classObj = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUnitClassHEX = new System.Windows.Forms.TextBox();
            this.txtUnitCodeHEX = new System.Windows.Forms.TextBox();
            this.comboBox_Class = new System.Windows.Forms.ComboBox();
            this.comboBox_Unit = new System.Windows.Forms.ComboBox();
            this.txtUnitClass = new System.Windows.Forms.TextBox();
            this.txtUnitCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_180DD_DataLength = new System.Windows.Forms.TextBox();
            this.txt_180DD_SubNum = new System.Windows.Forms.TextBox();
            this.btn_180DD_Generate = new System.Windows.Forms.Button();
            this.checkBox_180DD_AutoLength = new System.Windows.Forms.CheckBox();
            this.txt_180DD_Data = new System.Windows.Forms.TextBox();
            this.txt_180DD_ObjNum = new System.Windows.Forms.TextBox();
            this.txt_180DD_Fixed_2 = new System.Windows.Forms.TextBox();
            this.txt_180DD_Fixed_1 = new System.Windows.Forms.TextBox();
            this.txt_180DD_Transaction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clearTelegramPreview = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPreambles)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 186);
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
            this.txtDelimiter.Location = new System.Drawing.Point(77, 29);
            this.txtDelimiter.MaxLength = 2;
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(311, 20);
            this.txtDelimiter.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAddress.Location = new System.Drawing.Point(77, 55);
            this.txtAddress.MaxLength = 14;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(311, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(77, 81);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(311, 20);
            this.txtCommand.TabIndex = 6;
            // 
            // txtByteCount
            // 
            this.txtByteCount.Location = new System.Drawing.Point(77, 107);
            this.txtByteCount.Name = "txtByteCount";
            this.txtByteCount.Size = new System.Drawing.Size(311, 20);
            this.txtByteCount.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(77, 133);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(311, 20);
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
            this.numUDPreambles.Location = new System.Drawing.Point(77, 3);
            this.numUDPreambles.Name = "numUDPreambles";
            this.numUDPreambles.Size = new System.Drawing.Size(65, 20);
            this.numUDPreambles.TabIndex = 11;
            // 
            // txtCheckSum
            // 
            this.txtCheckSum.Location = new System.Drawing.Point(77, 159);
            this.txtCheckSum.Name = "txtCheckSum";
            this.txtCheckSum.Size = new System.Drawing.Size(311, 20);
            this.txtCheckSum.TabIndex = 12;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(23, 244);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(71, 21);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 272);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 192);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelegramPreview);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 189);
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
            this.txtTelegramPreview.Size = new System.Drawing.Size(396, 164);
            this.txtTelegramPreview.TabIndex = 0;
            // 
            // txtFloat1
            // 
            this.txtFloat1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFloat1.Location = new System.Drawing.Point(9, 32);
            this.txtFloat1.Name = "txtFloat1";
            this.txtFloat1.Size = new System.Drawing.Size(130, 20);
            this.txtFloat1.TabIndex = 4;
            this.txtFloat1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1_KeyPress);
            this.txtFloat1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFloat1_KeyUp);
            // 
            // txtHexHART1
            // 
            this.txtHexHART1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHexHART1.Location = new System.Drawing.Point(145, 32);
            this.txtHexHART1.Name = "txtHexHART1";
            this.txtHexHART1.Size = new System.Drawing.Size(130, 20);
            this.txtHexHART1.TabIndex = 5;
            this.txtHexHART1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexHART1_KeyUp);
            this.txtHexHART1.Leave += new System.EventHandler(this.txtHexHART1_Leave);
            // 
            // txtFloat2
            // 
            this.txtFloat2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFloat2.Location = new System.Drawing.Point(9, 58);
            this.txtFloat2.Name = "txtFloat2";
            this.txtFloat2.Size = new System.Drawing.Size(130, 20);
            this.txtFloat2.TabIndex = 7;
            this.txtFloat2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat2_KeyPress);
            this.txtFloat2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFloat2_KeyUp);
            // 
            // txtHexHART2
            // 
            this.txtHexHART2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHexHART2.Location = new System.Drawing.Point(145, 58);
            this.txtHexHART2.Name = "txtHexHART2";
            this.txtHexHART2.Size = new System.Drawing.Size(130, 20);
            this.txtHexHART2.TabIndex = 8;
            this.txtHexHART2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexHART2_KeyUp);
            this.txtHexHART2.Leave += new System.EventHandler(this.txtHexHART2_Leave);
            // 
            // txtFloat3
            // 
            this.txtFloat3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFloat3.Location = new System.Drawing.Point(9, 82);
            this.txtFloat3.Name = "txtFloat3";
            this.txtFloat3.Size = new System.Drawing.Size(130, 20);
            this.txtFloat3.TabIndex = 11;
            this.txtFloat3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat3_KeyPress);
            this.txtFloat3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFloat3_KeyUp);
            // 
            // txtFloat4
            // 
            this.txtFloat4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFloat4.Location = new System.Drawing.Point(9, 107);
            this.txtFloat4.Name = "txtFloat4";
            this.txtFloat4.Size = new System.Drawing.Size(130, 20);
            this.txtFloat4.TabIndex = 12;
            this.txtFloat4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat4_KeyPress);
            this.txtFloat4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFloat4_KeyUp);
            // 
            // txtHexHART3
            // 
            this.txtHexHART3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHexHART3.Location = new System.Drawing.Point(145, 82);
            this.txtHexHART3.Name = "txtHexHART3";
            this.txtHexHART3.Size = new System.Drawing.Size(130, 20);
            this.txtHexHART3.TabIndex = 13;
            this.txtHexHART3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexHART3_KeyUp);
            this.txtHexHART3.Leave += new System.EventHandler(this.txtHexHART3_Leave);
            // 
            // txtHexHART4
            // 
            this.txtHexHART4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHexHART4.Location = new System.Drawing.Point(145, 107);
            this.txtHexHART4.Name = "txtHexHART4";
            this.txtHexHART4.Size = new System.Drawing.Size(130, 20);
            this.txtHexHART4.TabIndex = 14;
            this.txtHexHART4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexHART4_KeyUp);
            this.txtHexHART4.Leave += new System.EventHandler(this.txtHexHART4_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Little Endian (GDC)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Big Endian (HART)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 16);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Float";
            // 
            // txtHexGDC1
            // 
            this.txtHexGDC1.Location = new System.Drawing.Point(281, 32);
            this.txtHexGDC1.Name = "txtHexGDC1";
            this.txtHexGDC1.Size = new System.Drawing.Size(130, 20);
            this.txtHexGDC1.TabIndex = 18;
            // 
            // txtHexGDC2
            // 
            this.txtHexGDC2.Location = new System.Drawing.Point(281, 58);
            this.txtHexGDC2.Name = "txtHexGDC2";
            this.txtHexGDC2.Size = new System.Drawing.Size(130, 20);
            this.txtHexGDC2.TabIndex = 19;
            // 
            // txtHexGDC3
            // 
            this.txtHexGDC3.Location = new System.Drawing.Point(281, 82);
            this.txtHexGDC3.Name = "txtHexGDC3";
            this.txtHexGDC3.Size = new System.Drawing.Size(130, 20);
            this.txtHexGDC3.TabIndex = 20;
            // 
            // txtHexGDC4
            // 
            this.txtHexGDC4.Location = new System.Drawing.Point(281, 107);
            this.txtHexGDC4.Name = "txtHexGDC4";
            this.txtHexGDC4.Size = new System.Drawing.Size(130, 20);
            this.txtHexGDC4.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFloat1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHexHART1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtFloat2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHexHART2);
            this.groupBox2.Controls.Add(this.txtHexGDC1);
            this.groupBox2.Controls.Add(this.txtFloat3);
            this.groupBox2.Controls.Add(this.txtHexGDC4);
            this.groupBox2.Controls.Add(this.txtFloat4);
            this.groupBox2.Controls.Add(this.txtHexGDC3);
            this.groupBox2.Controls.Add(this.txtHexHART3);
            this.groupBox2.Controls.Add(this.txtHexGDC2);
            this.groupBox2.Controls.Add(this.txtHexHART4);
            this.groupBox2.Location = new System.Drawing.Point(429, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Float <-> Hex";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtobjHART1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtobjGDC1);
            this.groupBox4.Controls.Add(this.txtobjDec1);
            this.groupBox4.Location = new System.Drawing.Point(429, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 70);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Object (Dec) <-> Hex";
            // 
            // txtobjHART1
            // 
            this.txtobjHART1.Location = new System.Drawing.Point(145, 40);
            this.txtobjHART1.Name = "txtobjHART1";
            this.txtobjHART1.Size = new System.Drawing.Size(130, 20);
            this.txtobjHART1.TabIndex = 4;
            this.txtobjHART1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtobjHART1_KeyUp);
            this.txtobjHART1.Leave += new System.EventHandler(this.txtobjHART1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Little Endian (GDC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Big Endian (HART)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Decimal";
            // 
            // txtobjGDC1
            // 
            this.txtobjGDC1.Location = new System.Drawing.Point(281, 40);
            this.txtobjGDC1.Name = "txtobjGDC1";
            this.txtobjGDC1.Size = new System.Drawing.Size(130, 20);
            this.txtobjGDC1.TabIndex = 0;
            // 
            // txtobjDec1
            // 
            this.txtobjDec1.Location = new System.Drawing.Point(9, 40);
            this.txtobjDec1.Name = "txtobjDec1";
            this.txtobjDec1.Size = new System.Drawing.Size(130, 20);
            this.txtobjDec1.TabIndex = 1;
            this.txtobjDec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtobjDec1_KeyPress);
            this.txtobjDec1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtobjDec1_KeyUp);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(100, 244);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(121, 21);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Data Builder for TCA";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txt_classObj);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtUnitClassHEX);
            this.groupBox5.Controls.Add(this.txtUnitCodeHEX);
            this.groupBox5.Controls.Add(this.comboBox_Class);
            this.groupBox5.Controls.Add(this.comboBox_Unit);
            this.groupBox5.Controls.Add(this.txtUnitClass);
            this.groupBox5.Controls.Add(this.txtUnitCode);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(429, 342);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(421, 122);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Units Code <-> Class Code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(345, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "GDC Obj.";
            // 
            // txt_classObj
            // 
            this.txt_classObj.Location = new System.Drawing.Point(344, 93);
            this.txt_classObj.Name = "txt_classObj";
            this.txt_classObj.Size = new System.Drawing.Size(67, 20);
            this.txt_classObj.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Code HEX:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(351, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Code HEX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Class Selection:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Unit Selection:";
            // 
            // txtUnitClassHEX
            // 
            this.txtUnitClassHEX.Location = new System.Drawing.Point(281, 93);
            this.txtUnitClassHEX.Name = "txtUnitClassHEX";
            this.txtUnitClassHEX.Size = new System.Drawing.Size(57, 20);
            this.txtUnitClassHEX.TabIndex = 4;
            this.txtUnitClassHEX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnitClassHEX_KeyUp);
            // 
            // txtUnitCodeHEX
            // 
            this.txtUnitCodeHEX.Location = new System.Drawing.Point(354, 44);
            this.txtUnitCodeHEX.Name = "txtUnitCodeHEX";
            this.txtUnitCodeHEX.Size = new System.Drawing.Size(57, 20);
            this.txtUnitCodeHEX.TabIndex = 4;
            this.txtUnitCodeHEX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnitCodeHEX_KeyUp);
            // 
            // comboBox_Class
            // 
            this.comboBox_Class.FormattingEnabled = true;
            this.comboBox_Class.Location = new System.Drawing.Point(75, 92);
            this.comboBox_Class.Name = "comboBox_Class";
            this.comboBox_Class.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Class.TabIndex = 3;
            this.comboBox_Class.SelectedIndexChanged += new System.EventHandler(this.comboBox_Class_SelectedIndexChanged);
            // 
            // comboBox_Unit
            // 
            this.comboBox_Unit.FormattingEnabled = true;
            this.comboBox_Unit.Location = new System.Drawing.Point(75, 44);
            this.comboBox_Unit.Name = "comboBox_Unit";
            this.comboBox_Unit.Size = new System.Drawing.Size(273, 21);
            this.comboBox_Unit.TabIndex = 3;
            this.comboBox_Unit.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Unit_SelectionChangeCommitted);
            // 
            // txtUnitClass
            // 
            this.txtUnitClass.Location = new System.Drawing.Point(9, 92);
            this.txtUnitClass.Name = "txtUnitClass";
            this.txtUnitClass.Size = new System.Drawing.Size(60, 20);
            this.txtUnitClass.TabIndex = 2;
            this.txtUnitClass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnitClass_KeyUp);
            // 
            // txtUnitCode
            // 
            this.txtUnitCode.Location = new System.Drawing.Point(9, 45);
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.Size = new System.Drawing.Size(60, 20);
            this.txtUnitCode.TabIndex = 2;
            this.txtUnitCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnitCode_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Class Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Unit Code";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel1);
            this.groupBox6.Location = new System.Drawing.Point(15, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(405, 211);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Telegram Assembler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_180DD_DataLength);
            this.groupBox3.Controls.Add(this.txt_180DD_SubNum);
            this.groupBox3.Controls.Add(this.btn_180DD_Generate);
            this.groupBox3.Controls.Add(this.checkBox_180DD_AutoLength);
            this.groupBox3.Controls.Add(this.txt_180DD_Data);
            this.groupBox3.Controls.Add(this.txt_180DD_ObjNum);
            this.groupBox3.Controls.Add(this.txt_180DD_Fixed_2);
            this.groupBox3.Controls.Add(this.txt_180DD_Fixed_1);
            this.groupBox3.Controls.Add(this.txt_180DD_Transaction);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(429, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 92);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command 181 - DD";
            // 
            // txt_180DD_DataLength
            // 
            this.txt_180DD_DataLength.Location = new System.Drawing.Point(263, 32);
            this.txt_180DD_DataLength.Name = "txt_180DD_DataLength";
            this.txt_180DD_DataLength.Size = new System.Drawing.Size(55, 20);
            this.txt_180DD_DataLength.TabIndex = 11;
            this.txt_180DD_DataLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_180DD_SubNum
            // 
            this.txt_180DD_SubNum.Location = new System.Drawing.Point(202, 32);
            this.txt_180DD_SubNum.Name = "txt_180DD_SubNum";
            this.txt_180DD_SubNum.Size = new System.Drawing.Size(55, 20);
            this.txt_180DD_SubNum.TabIndex = 10;
            this.txt_180DD_SubNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_180DD_Generate
            // 
            this.btn_180DD_Generate.Location = new System.Drawing.Point(331, 58);
            this.btn_180DD_Generate.Name = "btn_180DD_Generate";
            this.btn_180DD_Generate.Size = new System.Drawing.Size(80, 23);
            this.btn_180DD_Generate.TabIndex = 9;
            this.btn_180DD_Generate.Text = "Generate";
            this.btn_180DD_Generate.UseVisualStyleBackColor = true;
            this.btn_180DD_Generate.Click += new System.EventHandler(this.btn_180DD_Generate_Click);
            // 
            // checkBox_180DD_AutoLength
            // 
            this.checkBox_180DD_AutoLength.AutoSize = true;
            this.checkBox_180DD_AutoLength.Location = new System.Drawing.Point(331, 34);
            this.checkBox_180DD_AutoLength.Name = "checkBox_180DD_AutoLength";
            this.checkBox_180DD_AutoLength.Size = new System.Drawing.Size(84, 17);
            this.checkBox_180DD_AutoLength.TabIndex = 8;
            this.checkBox_180DD_AutoLength.Text = "Auto Length";
            this.checkBox_180DD_AutoLength.UseVisualStyleBackColor = true;
            // 
            // txt_180DD_Data
            // 
            this.txt_180DD_Data.Location = new System.Drawing.Point(9, 58);
            this.txt_180DD_Data.Name = "txt_180DD_Data";
            this.txt_180DD_Data.Size = new System.Drawing.Size(309, 20);
            this.txt_180DD_Data.TabIndex = 7;
            this.txt_180DD_Data.TextChanged += new System.EventHandler(this.txt_180DD_Data_TextChanged);
            this.txt_180DD_Data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_180DD_Data_KeyPress);
            this.txt_180DD_Data.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_180DD_Data_KeyUp);
            // 
            // txt_180DD_ObjNum
            // 
            this.txt_180DD_ObjNum.Location = new System.Drawing.Point(114, 32);
            this.txt_180DD_ObjNum.Name = "txt_180DD_ObjNum";
            this.txt_180DD_ObjNum.Size = new System.Drawing.Size(82, 20);
            this.txt_180DD_ObjNum.TabIndex = 4;
            this.txt_180DD_ObjNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_180DD_Fixed_2
            // 
            this.txt_180DD_Fixed_2.Location = new System.Drawing.Point(79, 32);
            this.txt_180DD_Fixed_2.Name = "txt_180DD_Fixed_2";
            this.txt_180DD_Fixed_2.Size = new System.Drawing.Size(29, 20);
            this.txt_180DD_Fixed_2.TabIndex = 3;
            // 
            // txt_180DD_Fixed_1
            // 
            this.txt_180DD_Fixed_1.Location = new System.Drawing.Point(44, 32);
            this.txt_180DD_Fixed_1.Name = "txt_180DD_Fixed_1";
            this.txt_180DD_Fixed_1.Size = new System.Drawing.Size(29, 20);
            this.txt_180DD_Fixed_1.TabIndex = 2;
            // 
            // txt_180DD_Transaction
            // 
            this.txt_180DD_Transaction.Location = new System.Drawing.Point(9, 32);
            this.txt_180DD_Transaction.Name = "txt_180DD_Transaction";
            this.txt_180DD_Transaction.Size = new System.Drawing.Size(29, 20);
            this.txt_180DD_Transaction.TabIndex = 1;
            this.txt_180DD_Transaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Transaction -> Fixed Data -> Obj. Num. -> Sub. Num. -> Data Length -> Data";
            // 
            // btn_clearTelegramPreview
            // 
            this.btn_clearTelegramPreview.Location = new System.Drawing.Point(363, 244);
            this.btn_clearTelegramPreview.Name = "btn_clearTelegramPreview";
            this.btn_clearTelegramPreview.Size = new System.Drawing.Size(51, 23);
            this.btn_clearTelegramPreview.TabIndex = 24;
            this.btn_clearTelegramPreview.Text = "Clear";
            this.btn_clearTelegramPreview.UseVisualStyleBackColor = true;
            this.btn_clearTelegramPreview.Click += new System.EventHandler(this.btn_clearTelegramPreview_Click);
            // 
            // SeComTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 476);
            this.Controls.Add(this.btn_clearTelegramPreview);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnPreview);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SeComTool";
            this.Text = "SeCom Tool";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPreambles)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelegramPreview;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHexHART1;
        private System.Windows.Forms.TextBox txtHexHART2;
        private System.Windows.Forms.TextBox txtHexHART3;
        private System.Windows.Forms.TextBox txtHexHART4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFloat1;
        private System.Windows.Forms.TextBox txtFloat2;
        private System.Windows.Forms.TextBox txtFloat3;
        private System.Windows.Forms.TextBox txtFloat4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtobjHART1;
        private System.Windows.Forms.TextBox txtobjGDC1;
        private System.Windows.Forms.TextBox txtobjDec1;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtByteCount;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.NumericUpDown numUDPreambles;
        private System.Windows.Forms.TextBox txtCheckSum;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblByteCount;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPreambles;
        private System.Windows.Forms.Label lblCheckSum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHexGDC1;
        private System.Windows.Forms.TextBox txtHexGDC2;
        private System.Windows.Forms.TextBox txtHexGDC3;
        private System.Windows.Forms.TextBox txtHexGDC4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtUnitClassHEX;
        private System.Windows.Forms.TextBox txtUnitCodeHEX;
        private System.Windows.Forms.ComboBox comboBox_Class;
        private System.Windows.Forms.ComboBox comboBox_Unit;
        private System.Windows.Forms.TextBox txtUnitClass;
        private System.Windows.Forms.TextBox txtUnitCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_classObj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_180DD_DataLength;
        private System.Windows.Forms.TextBox txt_180DD_SubNum;
        private System.Windows.Forms.Button btn_180DD_Generate;
        private System.Windows.Forms.CheckBox checkBox_180DD_AutoLength;
        private System.Windows.Forms.TextBox txt_180DD_Data;
        private System.Windows.Forms.TextBox txt_180DD_ObjNum;
        private System.Windows.Forms.TextBox txt_180DD_Fixed_2;
        private System.Windows.Forms.TextBox txt_180DD_Fixed_1;
        private System.Windows.Forms.TextBox txt_180DD_Transaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clearTelegramPreview;
    }
}

