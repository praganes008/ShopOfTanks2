namespace ShopOfTanks
{
    partial class ProductForm
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
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.MassaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.OpistextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSelectedButton = new System.Windows.Forms.Button();
            this.PartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(37, 32);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(64, 25);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "label1";
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Location = new System.Drawing.Point(12, 82);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(421, 420);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPictureBox.TabIndex = 1;
            this.ProductPictureBox.TabStop = false;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(42, 530);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(64, 25);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "label1";
            // 
            // MassaLabel
            // 
            this.MassaLabel.AutoSize = true;
            this.MassaLabel.Location = new System.Drawing.Point(42, 565);
            this.MassaLabel.Name = "MassaLabel";
            this.MassaLabel.Size = new System.Drawing.Size(64, 25);
            this.MassaLabel.TabIndex = 3;
            this.MassaLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "тонн(ы)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(42, 601);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(64, 25);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "label2";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(42, 635);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(64, 25);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "label2";
            // 
            // OpistextBox
            // 
            this.OpistextBox.Location = new System.Drawing.Point(475, 82);
            this.OpistextBox.Multiline = true;
            this.OpistextBox.Name = "OpistextBox";
            this.OpistextBox.ReadOnly = true;
            this.OpistextBox.Size = new System.Drawing.Size(358, 485);
            this.OpistextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Информация";
            // 
            // AddSelectedButton
            // 
            this.AddSelectedButton.BackColor = System.Drawing.Color.Gold;
            this.AddSelectedButton.Location = new System.Drawing.Point(475, 601);
            this.AddSelectedButton.Name = "AddSelectedButton";
            this.AddSelectedButton.Size = new System.Drawing.Size(358, 59);
            this.AddSelectedButton.TabIndex = 9;
            this.AddSelectedButton.Text = "Добавить в избранное";
            this.AddSelectedButton.UseVisualStyleBackColor = false;
            this.AddSelectedButton.Click += new System.EventHandler(this.AddSelectedButton_Click);
            // 
            // PartBtn
            // 
            this.PartBtn.Location = new System.Drawing.Point(300, 13);
            this.PartBtn.Name = "PartBtn";
            this.PartBtn.Size = new System.Drawing.Size(281, 44);
            this.PartBtn.TabIndex = 10;
            this.PartBtn.Text = "запчасти";
            this.PartBtn.UseVisualStyleBackColor = true;
            this.PartBtn.Click += new System.EventHandler(this.PartBtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 703);
            this.Controls.Add(this.PartBtn);
            this.Controls.Add(this.AddSelectedButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpistextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MassaLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.ProductLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label MassaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox OpistextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddSelectedButton;
        private System.Windows.Forms.Button PartBtn;
    }
}