namespace _7het
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFajl = new System.Windows.Forms.Label();
            this.numericUpDownZaroEv = new System.Windows.Forms.NumericUpDown();
            this.labelZaro = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZaroEv)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 78);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(999, 411);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(810, 30);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(100, 28);
            this.buttonBrowse.TabIndex = 12;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click_1);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(435, 30);
            this.textBoxFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(343, 22);
            this.textBoxFile.TabIndex = 11;
            // 
            // labelFajl
            // 
            this.labelFajl.AutoSize = true;
            this.labelFajl.Location = new System.Drawing.Point(332, 30);
            this.labelFajl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFajl.Name = "labelFajl";
            this.labelFajl.Size = new System.Drawing.Size(94, 17);
            this.labelFajl.TabIndex = 10;
            this.labelFajl.Text = "Népesség fájl";
            // 
            // numericUpDownZaroEv
            // 
            this.numericUpDownZaroEv.Location = new System.Drawing.Point(92, 27);
            this.numericUpDownZaroEv.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownZaroEv.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericUpDownZaroEv.Minimum = new decimal(new int[] {
            2006,
            0,
            0,
            0});
            this.numericUpDownZaroEv.Name = "numericUpDownZaroEv";
            this.numericUpDownZaroEv.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownZaroEv.TabIndex = 9;
            this.numericUpDownZaroEv.Value = new decimal(new int[] {
            2006,
            0,
            0,
            0});
            // 
            // labelZaro
            // 
            this.labelZaro.AutoSize = true;
            this.labelZaro.Location = new System.Drawing.Point(30, 30);
            this.labelZaro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZaro.Name = "labelZaro";
            this.labelZaro.Size = new System.Drawing.Size(53, 17);
            this.labelZaro.TabIndex = 8;
            this.labelZaro.Text = "Záróév";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(934, 30);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 28);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 538);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFajl);
            this.Controls.Add(this.numericUpDownZaroEv);
            this.Controls.Add(this.labelZaro);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZaroEv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFajl;
        private System.Windows.Forms.NumericUpDown numericUpDownZaroEv;
        private System.Windows.Forms.Label labelZaro;
        private System.Windows.Forms.Button buttonStart;
    }
}

