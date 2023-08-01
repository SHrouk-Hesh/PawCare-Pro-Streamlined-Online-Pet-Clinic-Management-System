
namespace Bmd302Project
{
    partial class logIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIn));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.RoleCb = new System.Windows.Forms.ComboBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.LogBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 486);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bmd302Project.Properties.Resources.veterinarian1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(462, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "Login";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(414, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Bmd302Project.Properties.Resources.reject;
            this.pictureBox10.Location = new System.Drawing.Point(679, 13);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(53, 34);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 78;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // RoleCb
            // 
            this.RoleCb.FormattingEnabled = true;
            this.RoleCb.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Doctor"});
            this.RoleCb.Location = new System.Drawing.Point(419, 108);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.Size = new System.Drawing.Size(233, 24);
            this.RoleCb.TabIndex = 79;
            this.RoleCb.Text = "Role";
            this.RoleCb.SelectedIndexChanged += new System.EventHandler(this.RoleCb_SelectedIndexChanged);
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(418, 292);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(231, 22);
            this.PasswordTb.TabIndex = 81;
            this.PasswordTb.TextChanged += new System.EventHandler(this.PasswordTb_TextChanged);
            // 
            // LogBtn
            // 
            this.LogBtn.ActiveBorderThickness = 1;
            this.LogBtn.ActiveCornerRadius = 20;
            this.LogBtn.ActiveFillColor = System.Drawing.Color.Gold;
            this.LogBtn.ActiveForecolor = System.Drawing.Color.White;
            this.LogBtn.ActiveLineColor = System.Drawing.Color.Gold;
            this.LogBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.LogBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogBtn.BackgroundImage")));
            this.LogBtn.ButtonText = "Login";
            this.LogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.LogBtn.IdleBorderThickness = 1;
            this.LogBtn.IdleCornerRadius = 20;
            this.LogBtn.IdleFillColor = System.Drawing.Color.Salmon;
            this.LogBtn.IdleForecolor = System.Drawing.Color.White;
            this.LogBtn.IdleLineColor = System.Drawing.Color.Salmon;
            this.LogBtn.Location = new System.Drawing.Point(418, 367);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(193, 50);
            this.LogBtn.TabIndex = 17;
            this.LogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogBtn.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // UnameTb
            // 
            this.UnameTb.Location = new System.Drawing.Point(417, 200);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(233, 22);
            this.UnameTb.TabIndex = 80;
            this.UnameTb.TextChanged += new System.EventHandler(this.UnameTb_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Forte", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Firebrick;
            this.label15.Location = new System.Drawing.Point(34, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 27);
            this.label15.TabIndex = 72;
            this.label15.Text = "Vet For Every Pet";
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(746, 486);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.RoleCb);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "logIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logIn";
            this.Load += new System.EventHandler(this.logIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.ComboBox RoleCb;
        private Bunifu.Framework.UI.BunifuThinButton2 LogBtn;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.Label label15;
    }
}