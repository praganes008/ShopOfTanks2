namespace ShopOfTanks
{
    partial class SelectedForm
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
            this.TotalPriceLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalPriceLBL
            // 
            this.TotalPriceLBL.AutoSize = true;
            this.TotalPriceLBL.Location = new System.Drawing.Point(600, 50);
            this.TotalPriceLBL.Name = "TotalPriceLBL";
            this.TotalPriceLBL.Size = new System.Drawing.Size(280, 25);
            this.TotalPriceLBL.TabIndex = 0;
            this.TotalPriceLBL.Text = "Общая стоимость корзины: ";
            // 
            // SelectedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1198, 599);
            this.Controls.Add(this.TotalPriceLBL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectedForm";
            this.Text = "SelectedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalPriceLBL;
    }
}