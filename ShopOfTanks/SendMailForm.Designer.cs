﻿namespace ShopOfTanks
{
    partial class SendMailForm
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
            this.Sendbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdressTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sendbtn
            // 
            this.Sendbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sendbtn.Location = new System.Drawing.Point(0, 138);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(575, 49);
            this.Sendbtn.TabIndex = 0;
            this.Sendbtn.Text = "отправить";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Напишите почту получателя";
            // 
            // AdressTB
            // 
            this.AdressTB.Location = new System.Drawing.Point(18, 64);
            this.AdressTB.Name = "AdressTB";
            this.AdressTB.Size = new System.Drawing.Size(426, 30);
            this.AdressTB.TabIndex = 2;
            // 
            // SendMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 187);
            this.Controls.Add(this.AdressTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sendbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SendMailForm";
            this.Text = "SendMailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdressTB;
    }
}