
namespace WindowsFormsApp2
{
    partial class ChangePasswordcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordcs));
            this.ChngePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EixtPic = new System.Windows.Forms.PictureBox();
            this.ReturnPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EixtPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ChngePassword
            // 
            this.ChngePassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChngePassword.Location = new System.Drawing.Point(453, 90);
            this.ChngePassword.Margin = new System.Windows.Forms.Padding(4);
            this.ChngePassword.Name = "ChngePassword";
            this.ChngePassword.PasswordChar = '*';
            this.ChngePassword.Size = new System.Drawing.Size(247, 32);
            this.ChngePassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // NewPassword
            // 
            this.NewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.Location = new System.Drawing.Point(453, 150);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '*';
            this.NewPassword.Size = new System.Drawing.Size(247, 32);
            this.NewPassword.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EixtPic
            // 
            this.EixtPic.BackColor = System.Drawing.Color.Transparent;
            this.EixtPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EixtPic.BackgroundImage")));
            this.EixtPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EixtPic.Location = new System.Drawing.Point(731, 0);
            this.EixtPic.Name = "EixtPic";
            this.EixtPic.Size = new System.Drawing.Size(46, 44);
            this.EixtPic.TabIndex = 17;
            this.EixtPic.TabStop = false;
            this.EixtPic.Click += new System.EventHandler(this.EixtPic_Click);
            // 
            // ReturnPic
            // 
            this.ReturnPic.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnPic.BackgroundImage")));
            this.ReturnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnPic.Location = new System.Drawing.Point(2, 0);
            this.ReturnPic.Name = "ReturnPic";
            this.ReturnPic.Size = new System.Drawing.Size(46, 44);
            this.ReturnPic.TabIndex = 18;
            this.ReturnPic.TabStop = false;
            this.ReturnPic.Click += new System.EventHandler(this.ReturnPic_Click);
            // 
            // ChangePasswordcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 385);
            this.Controls.Add(this.ReturnPic);
            this.Controls.Add(this.EixtPic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChngePassword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePasswordcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordcs";
            this.Load += new System.EventHandler(this.ChangePasswordcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EixtPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChngePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox EixtPic;
        private System.Windows.Forms.PictureBox ReturnPic;
    }
}