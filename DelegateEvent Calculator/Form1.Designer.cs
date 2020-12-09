
namespace DelegateEvent_Calculator
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
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.lstboxHasil = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.lstboxHasil);
            this.grpbox.Location = new System.Drawing.Point(12, 12);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(526, 489);
            this.grpbox.TabIndex = 0;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Hasil";
            // 
            // lstboxHasil
            // 
            this.lstboxHasil.FormattingEnabled = true;
            this.lstboxHasil.ItemHeight = 16;
            this.lstboxHasil.Location = new System.Drawing.Point(19, 37);
            this.lstboxHasil.Name = "lstboxHasil";
            this.lstboxHasil.Size = new System.Drawing.Size(484, 420);
            this.lstboxHasil.TabIndex = 0;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(12, 507);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(526, 32);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 551);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.grpbox);
            this.Name = "Form1";
            this.Text = "Hasil Perhitungan";
            this.grpbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.ListBox lstboxHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}

