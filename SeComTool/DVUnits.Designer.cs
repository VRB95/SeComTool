namespace SeComTool
{
    partial class DVUnits
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
            this.unitsDataGridView = new System.Windows.Forms.DataGridView();
            this.unitsSearchtxt = new System.Windows.Forms.TextBox();
            this.unitsSearchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // unitsDataGridView
            // 
            this.unitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unitsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.unitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitsDataGridView.Location = new System.Drawing.Point(12, 37);
            this.unitsDataGridView.Name = "unitsDataGridView";
            this.unitsDataGridView.Size = new System.Drawing.Size(470, 354);
            this.unitsDataGridView.TabIndex = 0;
            // 
            // unitsSearchtxt
            // 
            this.unitsSearchtxt.Location = new System.Drawing.Point(320, 9);
            this.unitsSearchtxt.Name = "unitsSearchtxt";
            this.unitsSearchtxt.Size = new System.Drawing.Size(100, 20);
            this.unitsSearchtxt.TabIndex = 1;
            // 
            // unitsSearchbtn
            // 
            this.unitsSearchbtn.Location = new System.Drawing.Point(426, 7);
            this.unitsSearchbtn.Name = "unitsSearchbtn";
            this.unitsSearchbtn.Size = new System.Drawing.Size(56, 23);
            this.unitsSearchbtn.TabIndex = 3;
            this.unitsSearchbtn.Text = "Search";
            this.unitsSearchbtn.UseVisualStyleBackColor = true;
            this.unitsSearchbtn.Click += new System.EventHandler(this.unitsSearchbtn_Click);
            // 
            // DVUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 403);
            this.Controls.Add(this.unitsSearchbtn);
            this.Controls.Add(this.unitsSearchtxt);
            this.Controls.Add(this.unitsDataGridView);
            this.Name = "DVUnits";
            this.Text = "DVUnits";
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView unitsDataGridView;
        private System.Windows.Forms.TextBox unitsSearchtxt;
        private System.Windows.Forms.Button unitsSearchbtn;
    }
}