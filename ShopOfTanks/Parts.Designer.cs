namespace ShopOfTanks
{
    partial class Parts
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
            this.NameTankslbl = new System.Windows.Forms.Label();
            this.PartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTankslbl
            // 
            this.NameTankslbl.AutoSize = true;
            this.NameTankslbl.Location = new System.Drawing.Point(10, 10);
            this.NameTankslbl.Name = "NameTankslbl";
            this.NameTankslbl.Size = new System.Drawing.Size(64, 25);
            this.NameTankslbl.TabIndex = 0;
            this.NameTankslbl.Text = "label1";
            // 
            // PartLabel
            // 
            this.PartLabel.AutoSize = true;
            this.PartLabel.Location = new System.Drawing.Point(10, 60);
            this.PartLabel.Name = "PartLabel";
            this.PartLabel.Size = new System.Drawing.Size(175, 25);
            this.PartLabel.TabIndex = 1;
            this.PartLabel.Text = "комплектующие:";
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 493);
            this.Controls.Add(this.PartLabel);
            this.Controls.Add(this.NameTankslbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Parts";
            this.Text = "Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameTankslbl;
        private System.Windows.Forms.Label PartLabel;
    }
}