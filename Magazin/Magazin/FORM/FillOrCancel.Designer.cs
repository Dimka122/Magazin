namespace Magazin
{
    partial class Form1
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
            this.DataGridWiev = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWiev)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridWiev
            // 
            this.DataGridWiev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridWiev.Location = new System.Drawing.Point(13, 26);
            this.DataGridWiev.Name = "DataGridWiev";
            this.DataGridWiev.ReadOnly = true;
            this.DataGridWiev.RowHeadersVisible = false;
            this.DataGridWiev.Size = new System.Drawing.Size(521, 217);
            this.DataGridWiev.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::Magazin.Properties.Resources.pngwing_com__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(546, 300);
            this.Controls.Add(this.DataGridWiev);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Wellcome";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWiev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.DataGridView DataGridWiev;
        
    }
}