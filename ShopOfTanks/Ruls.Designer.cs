namespace ShopOfTanks
{
    partial class Ruls
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
            this.rulTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rulTB
            // 
            this.rulTB.Enabled = false;
            this.rulTB.Location = new System.Drawing.Point(12, 12);
            this.rulTB.Multiline = true;
            this.rulTB.Name = "rulTB";
            this.rulTB.ReadOnly = true;
            this.rulTB.Size = new System.Drawing.Size(1230, 1587);
            this.rulTB.TabIndex = 0;
            // 
            // Ruls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1275, 632);
            this.Controls.Add(this.rulTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ruls";
            this.Text = "Ruls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rulTB;
    }
}