
namespace WindowsFormsApp2
{
    partial class debosit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(debosit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DepositeBtn = new System.Windows.Forms.Button();
            this.EixtPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EixtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(117, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "enter the amount to deposit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 141);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 35);
            this.textBox1.TabIndex = 11;
            // 
            // DepositeBtn
            // 
            this.DepositeBtn.BackColor = System.Drawing.Color.White;
            this.DepositeBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.DepositeBtn.ForeColor = System.Drawing.Color.Navy;
            this.DepositeBtn.Location = new System.Drawing.Point(212, 206);
            this.DepositeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DepositeBtn.Name = "DepositeBtn";
            this.DepositeBtn.Size = new System.Drawing.Size(135, 52);
            this.DepositeBtn.TabIndex = 12;
            this.DepositeBtn.Text = "ADD";
            this.DepositeBtn.UseVisualStyleBackColor = false;
            this.DepositeBtn.Click += new System.EventHandler(this.DepositeBtn_Click);
            // 
            // EixtPic
            // 
            this.EixtPic.BackColor = System.Drawing.Color.Transparent;
            this.EixtPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EixtPic.BackgroundImage")));
            this.EixtPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EixtPic.Location = new System.Drawing.Point(498, -1);
            this.EixtPic.Name = "EixtPic";
            this.EixtPic.Size = new System.Drawing.Size(46, 44);
            this.EixtPic.TabIndex = 18;
            this.EixtPic.TabStop = false;
            this.EixtPic.Click += new System.EventHandler(this.EixtPic_Click);
            // 
            // debosit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 332);
            this.ControlBox = false;
            this.Controls.Add(this.EixtPic);
            this.Controls.Add(this.DepositeBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "debosit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deposit";
            this.Load += new System.EventHandler(this.debosit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EixtPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DepositeBtn;
        private System.Windows.Forms.PictureBox EixtPic;
    }
}