namespace DDSViewer
{
    partial class batchConvert
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
            this.btnSrc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDst = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nRecursionDepth = new System.Windows.Forms.NumericUpDown();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbExt = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.txtDst = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nRecursionDepth)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(21, 39);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(75, 23);
            this.btnSrc.TabIndex = 0;
            this.btnSrc.Text = "Browse";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Folder";
            // 
            // btnDst
            // 
            this.btnDst.Location = new System.Drawing.Point(21, 81);
            this.btnDst.Name = "btnDst";
            this.btnDst.Size = new System.Drawing.Size(75, 23);
            this.btnDst.TabIndex = 3;
            this.btnDst.Text = "Browse";
            this.btnDst.UseVisualStyleBackColor = true;
            this.btnDst.Click += new System.EventHandler(this.btnDst_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recursion Depth";
            // 
            // nRecursionDepth
            // 
            this.nRecursionDepth.Location = new System.Drawing.Point(116, 107);
            this.nRecursionDepth.Name = "nRecursionDepth";
            this.nRecursionDepth.Size = new System.Drawing.Size(120, 20);
            this.nRecursionDepth.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(186, 187);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(105, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.txtDst);
            this.grpOptions.Controls.Add(this.txtSrc);
            this.grpOptions.Controls.Add(this.cmbExt);
            this.grpOptions.Controls.Add(this.label4);
            this.grpOptions.Controls.Add(this.btnSrc);
            this.grpOptions.Controls.Add(this.label1);
            this.grpOptions.Controls.Add(this.nRecursionDepth);
            this.grpOptions.Controls.Add(this.btnDst);
            this.grpOptions.Controls.Add(this.label3);
            this.grpOptions.Controls.Add(this.label2);
            this.grpOptions.Location = new System.Drawing.Point(12, 12);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(249, 169);
            this.grpOptions.TabIndex = 11;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Destination Type";
            // 
            // cmbExt
            // 
            this.cmbExt.FormattingEnabled = true;
            this.cmbExt.Location = new System.Drawing.Point(116, 137);
            this.cmbExt.Name = "cmbExt";
            this.cmbExt.Size = new System.Drawing.Size(121, 21);
            this.cmbExt.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 213);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "mainStatusStrip";
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(100, 16);
            this.mainProgressBar.Step = 1;
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.mainProgressBar.Visible = false;
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(116, 39);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.ReadOnly = true;
            this.txtSrc.Size = new System.Drawing.Size(121, 20);
            this.txtSrc.TabIndex = 13;
            this.txtSrc.Text = "[No Directory Selected]";
            // 
            // txtDst
            // 
            this.txtDst.Location = new System.Drawing.Point(116, 81);
            this.txtDst.Name = "txtDst";
            this.txtDst.ReadOnly = true;
            this.txtDst.Size = new System.Drawing.Size(120, 20);
            this.txtDst.TabIndex = 14;
            this.txtDst.Text = "[No Directory Selected]";
            // 
            // batchConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "batchConvert";
            this.Text = "Batch Convert";
            this.Load += new System.EventHandler(this.batchConvert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nRecursionDepth)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nRecursionDepth;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        private System.Windows.Forms.ComboBox cmbExt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar mainProgressBar;
        private System.Windows.Forms.TextBox txtDst;
        private System.Windows.Forms.TextBox txtSrc;
    }
}