namespace ShopOfTanks
{
    partial class AddToolForm
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
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.AddToolBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoadPicBtn = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpisanieTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TankComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.MediumBlue;
            this.InfoPanel.Controls.Add(this.HelpBtn);
            this.InfoPanel.Controls.Add(this.AddToolBtn);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.PriceTB);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Controls.Add(this.LoadPicBtn);
            this.InfoPanel.Controls.Add(this.NameTB);
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.OpisanieTB);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.TankComboBox);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.PicBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1181, 521);
            this.InfoPanel.TabIndex = 0;
            // 
            // AddToolBtn
            // 
            this.AddToolBtn.Location = new System.Drawing.Point(882, 390);
            this.AddToolBtn.Name = "AddToolBtn";
            this.AddToolBtn.Size = new System.Drawing.Size(230, 44);
            this.AddToolBtn.TabIndex = 12;
            this.AddToolBtn.Text = "Добавить";
            this.AddToolBtn.UseVisualStyleBackColor = true;
            this.AddToolBtn.Click += new System.EventHandler(this.AddToolBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "введите цену(руб.)";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(8, 225);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(299, 30);
            this.PriceTB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(949, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "описание";
            // 
            // LoadPicBtn
            // 
            this.LoadPicBtn.BackColor = System.Drawing.Color.Snow;
            this.LoadPicBtn.Location = new System.Drawing.Point(434, 390);
            this.LoadPicBtn.Name = "LoadPicBtn";
            this.LoadPicBtn.Size = new System.Drawing.Size(249, 44);
            this.LoadPicBtn.TabIndex = 8;
            this.LoadPicBtn.Text = "Загрузить картинку";
            this.LoadPicBtn.UseVisualStyleBackColor = false;
            this.LoadPicBtn.Click += new System.EventHandler(this.LoadPicBtn_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(9, 151);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(298, 30);
            this.NameTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "введите название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumBlue;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "ДОБАВЛЕНИЕ ЗАПЧАСТИ:";
            // 
            // OpisanieTB
            // 
            this.OpisanieTB.Location = new System.Drawing.Point(814, 45);
            this.OpisanieTB.Multiline = true;
            this.OpisanieTB.Name = "OpisanieTB";
            this.OpisanieTB.Size = new System.Drawing.Size(355, 327);
            this.OpisanieTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "выберите товар";
            // 
            // TankComboBox
            // 
            this.TankComboBox.FormattingEnabled = true;
            this.TankComboBox.Location = new System.Drawing.Point(8, 73);
            this.TankComboBox.Name = "TankComboBox";
            this.TankComboBox.Size = new System.Drawing.Size(299, 33);
            this.TankComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "картинка";
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBox.Location = new System.Drawing.Point(371, 45);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(362, 327);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.Lime;
            this.ButtonPanel.Controls.Add(this.button2);
            this.ButtonPanel.Controls.Add(this.label4);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 440);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(1181, 137);
            this.ButtonPanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(895, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить запчасть";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "УДАЛЕНИЕ ЗАПЧАСТИ:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.Red;
            this.HelpBtn.Location = new System.Drawing.Point(1142, 0);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(39, 38);
            this.HelpBtn.TabIndex = 13;
            this.HelpBtn.Text = "?";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // AddToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 577);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.InfoPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddToolForm";
            this.Text = "Добавить/Удалить запчасть";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button LoadPicBtn;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OpisanieTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TankComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Button AddToolBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button HelpBtn;
    }
}