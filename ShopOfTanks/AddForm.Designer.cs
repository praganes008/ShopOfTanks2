namespace ShopOfTanks
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MassaTB = new System.Windows.Forms.TextBox();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadPicButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpisTB = new System.Windows.Forms.TextBox();
            this.HelpBtn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление нового товара в магазин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название танка";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(18, 128);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(267, 30);
            this.NameTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Страна произвидства танка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Масса танка(тонны)";
            // 
            // MassaTB
            // 
            this.MassaTB.Location = new System.Drawing.Point(23, 319);
            this.MassaTB.Name = "MassaTB";
            this.MassaTB.Size = new System.Drawing.Size(194, 30);
            this.MassaTB.TabIndex = 6;
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Items.AddRange(new object[] {
            "СССР",
            "Германия",
            "Италия",
            "Франция",
            "Китай",
            "США",
            "Польша",
            "Шведция",
            "Великобритания",
            "Япония",
            "Румыния",
            "Чехославакия"});
            this.CountryComboBox.Location = new System.Drawing.Point(18, 225);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(267, 33);
            this.CountryComboBox.TabIndex = 7;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "средний танк",
            "лёгкий танк",
            "тяжёлый танк",
            "ПТ-САУ"});
            this.TypeComboBox.Location = new System.Drawing.Point(23, 414);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(194, 33);
            this.TypeComboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тип танка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цена";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(28, 506);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(189, 30);
            this.PriceTB.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(-4, 571);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(1224, 46);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(380, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LoadPicButton
            // 
            this.LoadPicButton.Location = new System.Drawing.Point(380, 479);
            this.LoadPicButton.Name = "LoadPicButton";
            this.LoadPicButton.Size = new System.Drawing.Size(438, 57);
            this.LoadPicButton.TabIndex = 14;
            this.LoadPicButton.Text = "Загрузить картинку";
            this.LoadPicButton.UseVisualStyleBackColor = true;
            this.LoadPicButton.Click += new System.EventHandler(this.LoadPicButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpisTB
            // 
            this.OpisTB.Location = new System.Drawing.Point(845, 13);
            this.OpisTB.Multiline = true;
            this.OpisTB.Name = "OpisTB";
            this.OpisTB.Size = new System.Drawing.Size(407, 514);
            this.OpisTB.TabIndex = 15;
            // 
            // HelpBtn3
            // 
            this.HelpBtn3.BackColor = System.Drawing.Color.Red;
            this.HelpBtn3.Location = new System.Drawing.Point(1222, 571);
            this.HelpBtn3.Name = "HelpBtn3";
            this.HelpBtn3.Size = new System.Drawing.Size(40, 40);
            this.HelpBtn3.TabIndex = 16;
            this.HelpBtn3.Text = "?";
            this.HelpBtn3.UseVisualStyleBackColor = false;
            this.HelpBtn3.Click += new System.EventHandler(this.HelpBtn3_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 612);
            this.Controls.Add(this.HelpBtn3);
            this.Controls.Add(this.OpisTB);
            this.Controls.Add(this.LoadPicButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.CountryComboBox);
            this.Controls.Add(this.MassaTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MassaTB;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadPicButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox OpisTB;
        private System.Windows.Forms.Button HelpBtn3;
    }
}