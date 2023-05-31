
namespace WindowsFormsApp2
{
    partial class AccountSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.ChngPass = new System.Windows.Forms.Button();
            this.UserCash = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnPic = new System.Windows.Forms.PictureBox();
            this.EixtPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EixtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(424, 57);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(92, 36);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Name";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.BackColor = System.Drawing.Color.Transparent;
            this.UserPassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.Location = new System.Drawing.Point(424, 122);
            this.UserPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(140, 36);
            this.UserPassword.TabIndex = 3;
            this.UserPassword.Text = "Password";
            // 
            // ChngPass
            // 
            this.ChngPass.BackColor = System.Drawing.Color.FloralWhite;
            this.ChngPass.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChngPass.Location = new System.Drawing.Point(242, 373);
            this.ChngPass.Margin = new System.Windows.Forms.Padding(4);
            this.ChngPass.Name = "ChngPass";
            this.ChngPass.Size = new System.Drawing.Size(252, 71);
            this.ChngPass.TabIndex = 5;
            this.ChngPass.Text = "Change Password";
            this.ChngPass.UseVisualStyleBackColor = false;
            this.ChngPass.Click += new System.EventHandler(this.ChngPass_Click);
            // 
            // UserCash
            // 
            this.UserCash.AutoSize = true;
            this.UserCash.BackColor = System.Drawing.Color.Transparent;
            this.UserCash.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCash.Location = new System.Drawing.Point(424, 189);
            this.UserCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserCash.Name = "UserCash";
            this.UserCash.Size = new System.Drawing.Size(79, 36);
            this.UserCash.TabIndex = 7;
            this.UserCash.Text = "Cash";
            this.UserCash.Click += new System.EventHandler(this.UserCash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cash :";
            // 
            // ReturnPic
            // 
            this.ReturnPic.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnPic.BackgroundImage")));
            this.ReturnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnPic.Location = new System.Drawing.Point(0, 2);
            this.ReturnPic.Name = "ReturnPic";
            this.ReturnPic.Size = new System.Drawing.Size(46, 44);
            this.ReturnPic.TabIndex = 18;
            this.ReturnPic.TabStop = false;
            this.ReturnPic.Click += new System.EventHandler(this.ReturnPic_Click);
            // 
            // EixtPic
            // 
            this.EixtPic.BackColor = System.Drawing.Color.Transparent;
            this.EixtPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EixtPic.BackgroundImage")));
            this.EixtPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EixtPic.Location = new System.Drawing.Point(659, 2);
            this.EixtPic.Name = "EixtPic";
            this.EixtPic.Size = new System.Drawing.Size(46, 44);
            this.EixtPic.TabIndex = 19;
            this.EixtPic.TabStop = false;
            this.EixtPic.Click += new System.EventHandler(this.EixtPic_Click);
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 482);
            this.ControlBox = false;
            this.Controls.Add(this.EixtPic);
            this.Controls.Add(this.ReturnPic);
            this.Controls.Add(this.UserCash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChngPass);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountSettings";
            this.Load += new System.EventHandler(this.AccountSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EixtPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Button ChngPass;
        private System.Windows.Forms.Label UserCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ReturnPic;
        private System.Windows.Forms.PictureBox EixtPic;
    }
}