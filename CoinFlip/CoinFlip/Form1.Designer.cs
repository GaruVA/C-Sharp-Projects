namespace CoinFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picCoinFlip = new System.Windows.Forms.PictureBox();
            this.btnCoinFlip = new System.Windows.Forms.Button();
            this.lblCoinFlip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCoinFlip)).BeginInit();
            this.SuspendLayout();
            // 
            // picCoinFlip
            // 
            this.picCoinFlip.Image = ((System.Drawing.Image)(resources.GetObject("picCoinFlip.Image")));
            this.picCoinFlip.Location = new System.Drawing.Point(170, 12);
            this.picCoinFlip.Name = "picCoinFlip";
            this.picCoinFlip.Size = new System.Drawing.Size(197, 204);
            this.picCoinFlip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoinFlip.TabIndex = 0;
            this.picCoinFlip.TabStop = false;
            // 
            // btnCoinFlip
            // 
            this.btnCoinFlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnCoinFlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoinFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCoinFlip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnCoinFlip.Location = new System.Drawing.Point(-1, 265);
            this.btnCoinFlip.Name = "btnCoinFlip";
            this.btnCoinFlip.Size = new System.Drawing.Size(540, 68);
            this.btnCoinFlip.TabIndex = 1;
            this.btnCoinFlip.Text = "FLIP";
            this.btnCoinFlip.UseVisualStyleBackColor = false;
            this.btnCoinFlip.Click += new System.EventHandler(this.btnCoinFlip_Click);
            // 
            // lblCoinFlip
            // 
            this.lblCoinFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCoinFlip.ForeColor = System.Drawing.Color.White;
            this.lblCoinFlip.Location = new System.Drawing.Point(12, 219);
            this.lblCoinFlip.Name = "lblCoinFlip";
            this.lblCoinFlip.Size = new System.Drawing.Size(514, 34);
            this.lblCoinFlip.TabIndex = 2;
            this.lblCoinFlip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(538, 332);
            this.Controls.Add(this.lblCoinFlip);
            this.Controls.Add(this.btnCoinFlip);
            this.Controls.Add(this.picCoinFlip);
            this.MaximumSize = new System.Drawing.Size(554, 371);
            this.MinimumSize = new System.Drawing.Size(554, 371);
            this.Name = "Form1";
            this.Text = "Coin Flip";
            ((System.ComponentModel.ISupportInitialize)(this.picCoinFlip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCoinFlip;
        private System.Windows.Forms.Button btnCoinFlip;
        private System.Windows.Forms.Label lblCoinFlip;
    }
}

