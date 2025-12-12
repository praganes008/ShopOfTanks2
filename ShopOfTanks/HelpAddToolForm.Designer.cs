namespace ShopOfTanks
{
    partial class HelpAddToolForm
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
            this.HelpAddToolTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelpAddToolTB
            // 
            this.HelpAddToolTB.Location = new System.Drawing.Point(1, -1);
            this.HelpAddToolTB.Multiline = true;
            this.HelpAddToolTB.Name = "HelpAddToolTB";
            this.HelpAddToolTB.ReadOnly = true;
            this.HelpAddToolTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HelpAddToolTB.Size = new System.Drawing.Size(834, 563);
            this.HelpAddToolTB.TabIndex = 0;
            // 
            // HelpAddToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 563);
            this.Controls.Add(this.HelpAddToolTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HelpAddToolForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HelpAddToolForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HelpAddToolTB;
    }
}