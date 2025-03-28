namespace ShopOfTanks
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AusPanel = new System.Windows.Forms.Panel();
            this.MainSelectbutton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AusButton = new System.Windows.Forms.Button();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MonyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.HideButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTankContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AusPanel.SuspendLayout();
            this.FiltrPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AusPanel
            // 
            this.AusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AusPanel.Controls.Add(this.MainSelectbutton);
            this.AusPanel.Controls.Add(this.RegButton);
            this.AusPanel.Controls.Add(this.NameLabel);
            this.AusPanel.Controls.Add(this.AusButton);
            this.AusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AusPanel.Location = new System.Drawing.Point(0, 0);
            this.AusPanel.Name = "AusPanel";
            this.AusPanel.Size = new System.Drawing.Size(1446, 67);
            this.AusPanel.TabIndex = 0;
            // 
            // MainSelectbutton
            // 
            this.MainSelectbutton.Location = new System.Drawing.Point(1071, 12);
            this.MainSelectbutton.Name = "MainSelectbutton";
            this.MainSelectbutton.Size = new System.Drawing.Size(208, 44);
            this.MainSelectbutton.TabIndex = 3;
            this.MainSelectbutton.Text = "избранное";
            this.MainSelectbutton.UseVisualStyleBackColor = true;
            this.MainSelectbutton.Click += new System.EventHandler(this.MainSelectbutton_Click);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(466, 9);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(251, 40);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(193, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "label1";
            // 
            // AusButton
            // 
            this.AusButton.Location = new System.Drawing.Point(12, 9);
            this.AusButton.Name = "AusButton";
            this.AusButton.Size = new System.Drawing.Size(150, 40);
            this.AusButton.TabIndex = 0;
            this.AusButton.Text = "Войти";
            this.AusButton.UseVisualStyleBackColor = true;
            this.AusButton.Click += new System.EventHandler(this.AusButton_Click);
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FiltrPanel.Controls.Add(this.label5);
            this.FiltrPanel.Controls.Add(this.mTextBox);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.MonyTextBox);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.CountryComboBox);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.SearchButton);
            this.FiltrPanel.Controls.Add(this.CategoryComboBox1);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.NameTextBox);
            this.FiltrPanel.Controls.Add(this.HideButton);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 67);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1446, 131);
            this.FiltrPanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(800, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Масса";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(891, 95);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(220, 30);
            this.mTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена(до)";
            // 
            // MonyTextBox
            // 
            this.MonyTextBox.Location = new System.Drawing.Point(170, 100);
            this.MonyTextBox.Name = "MonyTextBox";
            this.MonyTextBox.Size = new System.Drawing.Size(220, 30);
            this.MonyTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Страна";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Items.AddRange(new object[] {
            "",
            "Франция",
            "Германия",
            "Италия",
            "США",
            "СССР",
            "Великобритания",
            "Китай",
            "Шведция",
            "Польша"});
            this.CountryComboBox.Location = new System.Drawing.Point(544, 97);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(220, 33);
            this.CountryComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Категория";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(954, 57);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(108, 36);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CategoryComboBox1
            // 
            this.CategoryComboBox1.FormattingEnabled = true;
            this.CategoryComboBox1.Items.AddRange(new object[] {
            "",
            "тяжёлый танк",
            "средний танк",
            "лёгкий танк",
            "ПТ-САУ"});
            this.CategoryComboBox1.Location = new System.Drawing.Point(544, 57);
            this.CategoryComboBox1.Name = "CategoryComboBox1";
            this.CategoryComboBox1.Size = new System.Drawing.Size(220, 33);
            this.CategoryComboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(170, 60);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(220, 30);
            this.NameTextBox.TabIndex = 1;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(0, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(150, 40);
            this.HideButton.TabIndex = 0;
            this.HideButton.Text = "скрыть";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.Blue;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 198);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1446, 543);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Resize += new System.EventHandler(this.MainPanel_Resize);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTankContextMenu,
            this.DeleteTankToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 52);
            // 
            // AddTankContextMenu
            // 
            this.AddTankContextMenu.Name = "AddTankContextMenu";
            this.AddTankContextMenu.Size = new System.Drawing.Size(187, 24);
            this.AddTankContextMenu.Text = "добавить товар";
            this.AddTankContextMenu.Click += new System.EventHandler(this.AddTankContextMenu_Click);
            // 
            // DeleteTankToolStripMenuItem
            // 
            this.DeleteTankToolStripMenuItem.Name = "DeleteTankToolStripMenuItem";
            this.DeleteTankToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.DeleteTankToolStripMenuItem.Text = "Удалить танк";
            this.DeleteTankToolStripMenuItem.Click += new System.EventHandler(this.DeleteTankToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1446, 741);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.AusPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AusPanel.ResumeLayout(false);
            this.AusPanel.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AusPanel;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AusButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox CategoryComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MonyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddTankContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteTankToolStripMenuItem;
        private System.Windows.Forms.Button MainSelectbutton;
    }
}

