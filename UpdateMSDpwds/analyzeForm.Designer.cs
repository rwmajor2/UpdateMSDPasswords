﻿namespace UpdateMSDpwds
{
    partial class analyzeForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAnalyzeMSD = new System.Windows.Forms.Button();
            this.txtMSD = new System.Windows.Forms.TextBox();
            this.btnSelMSDFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelSDEFile = new System.Windows.Forms.Button();
            this.txtSDE = new System.Windows.Forms.TextBox();
            this.btnAnalyzeSDE = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(290, 274);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnAnalyzeMSD
            // 
            this.btnAnalyzeMSD.Location = new System.Drawing.Point(114, 61);
            this.btnAnalyzeMSD.Name = "btnAnalyzeMSD";
            this.btnAnalyzeMSD.Size = new System.Drawing.Size(69, 24);
            this.btnAnalyzeMSD.TabIndex = 1;
            this.btnAnalyzeMSD.Text = "Analyze";
            this.btnAnalyzeMSD.UseVisualStyleBackColor = true;
            this.btnAnalyzeMSD.Click += new System.EventHandler(this.btnAnalyzeMSD_Click);
            // 
            // txtMSD
            // 
            this.txtMSD.Location = new System.Drawing.Point(13, 35);
            this.txtMSD.Name = "txtMSD";
            this.txtMSD.Size = new System.Drawing.Size(284, 20);
            this.txtMSD.TabIndex = 2;
            // 
            // btnSelMSDFile
            // 
            this.btnSelMSDFile.Location = new System.Drawing.Point(264, 13);
            this.btnSelMSDFile.Name = "btnSelMSDFile";
            this.btnSelMSDFile.Size = new System.Drawing.Size(33, 19);
            this.btnSelMSDFile.TabIndex = 3;
            this.btnSelMSDFile.Text = "...";
            this.btnSelMSDFile.UseVisualStyleBackColor = true;
            this.btnSelMSDFile.Click += new System.EventHandler(this.btnSelSDEFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select MSD file to Analyze:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select .sde File for Updated Connection Info:";
            // 
            // btnSelSDEFile
            // 
            this.btnSelSDEFile.Location = new System.Drawing.Point(565, 13);
            this.btnSelSDEFile.Name = "btnSelSDEFile";
            this.btnSelSDEFile.Size = new System.Drawing.Size(33, 19);
            this.btnSelSDEFile.TabIndex = 8;
            this.btnSelSDEFile.Text = "...";
            this.btnSelSDEFile.UseVisualStyleBackColor = true;
            this.btnSelSDEFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSDE
            // 
            this.txtSDE.Location = new System.Drawing.Point(314, 35);
            this.txtSDE.Name = "txtSDE";
            this.txtSDE.Size = new System.Drawing.Size(284, 20);
            this.txtSDE.TabIndex = 7;
            // 
            // btnAnalyzeSDE
            // 
            this.btnAnalyzeSDE.Location = new System.Drawing.Point(415, 61);
            this.btnAnalyzeSDE.Name = "btnAnalyzeSDE";
            this.btnAnalyzeSDE.Size = new System.Drawing.Size(69, 24);
            this.btnAnalyzeSDE.TabIndex = 6;
            this.btnAnalyzeSDE.Text = "Analyze";
            this.btnAnalyzeSDE.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(310, 96);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(290, 274);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // analyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelSDEFile);
            this.Controls.Add(this.txtSDE);
            this.Controls.Add(this.btnAnalyzeSDE);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelMSDFile);
            this.Controls.Add(this.txtMSD);
            this.Controls.Add(this.btnAnalyzeMSD);
            this.Controls.Add(this.richTextBox1);
            this.Name = "analyzeForm";
            this.Text = "Update MSD Database Passwords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAnalyzeMSD;
        private System.Windows.Forms.TextBox txtMSD;
        private System.Windows.Forms.Button btnSelMSDFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelSDEFile;
        private System.Windows.Forms.TextBox txtSDE;
        private System.Windows.Forms.Button btnAnalyzeSDE;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}