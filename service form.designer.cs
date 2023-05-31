
namespace WindowsFormsApp2
{
    partial class service_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(service_form));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CustomerService = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EixtPic = new System.Windows.Forms.PictureBox();
            this.ReturnPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EixtPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Jokerman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(202, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose your service";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(206, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "DEBOSIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(206, 202);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(290, 48);
            this.button3.TabIndex = 12;
            this.button3.Text = "WITHDRAW";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(206, 267);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(290, 46);
            this.button4.TabIndex = 13;
            this.button4.Text = "Account Information";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomerService
            // 
            this.CustomerService.BackColor = System.Drawing.Color.White;
            this.CustomerService.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CustomerService.ForeColor = System.Drawing.Color.Navy;
            this.CustomerService.Location = new System.Drawing.Point(206, 329);
            this.CustomerService.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerService.Name = "CustomerService";
            this.CustomerService.Size = new System.Drawing.Size(290, 46);
            this.CustomerService.TabIndex = 14;
            this.CustomerService.Text = "Take ticket in customer Service queue";
            this.CustomerService.UseVisualStyleBackColor = false;
            this.CustomerService.Click += new System.EventHandler(this.CustomerService_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(164, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 379);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // EixtPic
            // 
            this.EixtPic.BackColor = System.Drawing.Color.Transparent;
            this.EixtPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EixtPic.BackgroundImage")));
            this.EixtPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EixtPic.Location = new System.Drawing.Point(675, 7);
            this.EixtPic.Name = "EixtPic";
            this.EixtPic.Size = new System.Drawing.Size(46, 44);
            this.EixtPic.TabIndex = 16;
            this.EixtPic.TabStop = false;
            this.EixtPic.Click += new System.EventHandler(this.EixtPic_Click);
            // 
            // ReturnPic
            // 
            this.ReturnPic.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnPic.BackgroundImage")));
            this.ReturnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnPic.Location = new System.Drawing.Point(2, 7);
            this.ReturnPic.Name = "ReturnPic";
            this.ReturnPic.Size = new System.Drawing.Size(46, 44);
            this.ReturnPic.TabIndex = 17;
            this.ReturnPic.TabStop = false;
            this.ReturnPic.Click += new System.EventHandler(this.ReturnPic_Click);
            // 
            // service_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 529);
            this.ControlBox = false;
            this.Controls.Add(this.ReturnPic);
            this.Controls.Add(this.EixtPic);
            this.Controls.Add(this.CustomerService);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "service_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "service_form";
            this.Load += new System.EventHandler(this.service_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EixtPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CustomerService;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox EixtPic;
        private System.Windows.Forms.PictureBox ReturnPic;
    }
}