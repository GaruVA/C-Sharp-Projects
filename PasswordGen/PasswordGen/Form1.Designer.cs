namespace PasswordGen
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
            this.trbLength = new System.Windows.Forms.TrackBar();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbLength)).BeginInit();
            this.SuspendLayout();
            // 
            // trbLength
            // 
            this.trbLength.Location = new System.Drawing.Point(12, 131);
            this.trbLength.Maximum = 20;
            this.trbLength.Minimum = 8;
            this.trbLength.Name = "trbLength";
            this.trbLength.Size = new System.Drawing.Size(565, 45);
            this.trbLength.TabIndex = 0;
            this.trbLength.Value = 8;
            this.trbLength.ValueChanged += new System.EventHandler(this.trbLength_ValueChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblPassword.Location = new System.Drawing.Point(12, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(565, 68);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "L~tIUwthb.C\\5[Y£5q5S";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblLength
            // 
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLength.Location = new System.Drawing.Point(12, 86);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(565, 42);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Password Length: 8";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Location = new System.Drawing.Point(205, 178);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(179, 31);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.trbLength);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.trbLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbLength;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

