namespace Magazin.Model
{
    partial class UserControlic
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
            this.CustomerName = new System.Windows.Forms.Label();
            this.YTDOrders = new System.Windows.Forms.Label();
            this.YTDSales = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CustomerName.Location = new System.Drawing.Point(13, 15);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 23);
            this.CustomerName.TabIndex = 2;
            this.CustomerName.Text = "label1";
            // 
            // YTDOrders
            // 
            this.YTDOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.YTDOrders.Location = new System.Drawing.Point(13, 48);
            this.YTDOrders.Name = "YTDOrders";
            this.YTDOrders.Size = new System.Drawing.Size(100, 23);
            this.YTDOrders.TabIndex = 3;
            this.YTDOrders.Text = "label1";
            // 
            // YTDSales
            // 
            this.YTDSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.YTDSales.Location = new System.Drawing.Point(13, 84);
            this.YTDSales.Name = "YTDSales";
            this.YTDSales.Size = new System.Drawing.Size(100, 23);
            this.YTDSales.TabIndex = 4;
            this.YTDSales.Text = "label1";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(23, 126);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(35, 13);
            this.Id.TabIndex = 5;
            this.Id.Text = "label1";
            // 
            // UserControlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Magazin.Properties.Resources.pngwing_com__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.Id);
            this.Controls.Add(this.YTDSales);
            this.Controls.Add(this.YTDOrders);
            this.Controls.Add(this.CustomerName);
            this.DoubleBuffered = true;
            this.Name = "UserControlic";
            this.Size = new System.Drawing.Size(126, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label YTDOrders;
        private System.Windows.Forms.Label YTDSales;
        private System.Windows.Forms.Label Id;
    }
}