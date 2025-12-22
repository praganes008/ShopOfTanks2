namespace ShopOfTanks
{
    partial class InfoBDForm
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
            this.InfoCB = new System.Windows.Forms.ComboBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // InfoCB
            // 
            this.InfoCB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.InfoCB.FormattingEnabled = true;
            this.InfoCB.Items.AddRange(new object[] {
            "",
            "Танки",
            "Комплектующие",
            "Пользователи"});
            this.InfoCB.Location = new System.Drawing.Point(203, 13);
            this.InfoCB.Name = "InfoCB";
            this.InfoCB.Size = new System.Drawing.Size(634, 33);
            this.InfoCB.TabIndex = 0;
            this.InfoCB.Text = "Выберете таблицу БД";
            this.InfoCB.SelectedIndexChanged += new System.EventHandler(this.InfoCB_SelectedIndexChanged);
            // 
            // InfoPanel
            // 
            this.InfoPanel.AutoScroll = true;
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(0, 52);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1025, 559);
            this.InfoPanel.TabIndex = 1;
            // 
            // InfoBDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 611);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.InfoCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InfoBDForm";
            this.Text = "Сводная информация по таблицам базы данных приложения";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox InfoCB;
        private System.Windows.Forms.Panel InfoPanel;
    }
}