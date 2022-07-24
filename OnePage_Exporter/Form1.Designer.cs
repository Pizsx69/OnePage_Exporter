namespace OnePage_Exporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.talloz = new System.Windows.Forms.Button();
            this.pagenumber = new System.Windows.Forms.TextBox();
            this.export_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pizsx69 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // talloz
            // 
            this.talloz.Location = new System.Drawing.Point(12, 29);
            this.talloz.Name = "talloz";
            this.talloz.Size = new System.Drawing.Size(119, 44);
            this.talloz.TabIndex = 0;
            this.talloz.Text = "Tallóz";
            this.talloz.UseVisualStyleBackColor = true;
            this.talloz.Click += new System.EventHandler(this.button1_Click);
            // 
            // pagenumber
            // 
            this.pagenumber.Location = new System.Drawing.Point(137, 40);
            this.pagenumber.Name = "pagenumber";
            this.pagenumber.Size = new System.Drawing.Size(45, 22);
            this.pagenumber.TabIndex = 1;
            this.pagenumber.Text = "1";
            this.pagenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // export_button
            // 
            this.export_button.Location = new System.Drawing.Point(188, 29);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(119, 44);
            this.export_button.TabIndex = 2;
            this.export_button.Text = "Export";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filename: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pizsx69
            // 
            this.pizsx69.AutoSize = true;
            this.pizsx69.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pizsx69.ForeColor = System.Drawing.Color.Gainsboro;
            this.pizsx69.Location = new System.Drawing.Point(222, 76);
            this.pizsx69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pizsx69.Name = "pizsx69";
            this.pizsx69.Size = new System.Drawing.Size(56, 16);
            this.pizsx69.TabIndex = 7;
            this.pizsx69.Text = "Pizs\\x69";
            this.pizsx69.Click += new System.EventHandler(this.pizsx69_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 97);
            this.Controls.Add(this.pizsx69);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.pagenumber);
            this.Controls.Add(this.talloz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "OnePage Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button talloz;
        private System.Windows.Forms.TextBox pagenumber;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label pizsx69;
    }
}

