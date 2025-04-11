namespace ShopOfTanks
{
    partial class AusForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "ВОЙТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(12, 66);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(295, 34);
            this.LoginTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(13, 161);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(295, 34);
            this.PasswordTB.TabIndex = 2;
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginL.Location = new System.Drawing.Point(13, 22);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(82, 29);
            this.LoginL.TabIndex = 3;
            this.LoginL.Text = "Логин";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordL.Location = new System.Drawing.Point(13, 126);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(96, 29);
            this.PasswordL.TabIndex = 4;
            this.PasswordL.Text = "Пароль";
            // 
            // AusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 279);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.LoginL);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.button1);
            this.Name = "AusForm";
            this.Text = "AusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.Label PasswordL;
    }
}