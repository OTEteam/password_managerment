namespace Password_Manager
{
    partial class frmResister
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
            this.u = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.rp = new System.Windows.Forms.Label();
            this.ph = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.provider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.provider)).BeginInit();
            this.SuspendLayout();
            // 
            // u
            // 
            this.u.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.u.AutoSize = true;
            this.u.Location = new System.Drawing.Point(194, 101);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(83, 20);
            this.u.TabIndex = 0;
            this.u.Text = "Username";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(194, 141);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(78, 20);
            this.p.TabIndex = 1;
            this.p.Text = "Password";
            // 
            // rp
            // 
            this.rp.AutoSize = true;
            this.rp.Location = new System.Drawing.Point(194, 182);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(99, 20);
            this.rp.TabIndex = 2;
            this.rp.Text = "RePassword";
            // 
            // ph
            // 
            this.ph.AutoSize = true;
            this.ph.Location = new System.Drawing.Point(194, 224);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(115, 20);
            this.ph.TabIndex = 3;
            this.ph.Text = "Phone Number";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(312, 98);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(181, 26);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(312, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(312, 179);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(181, 26);
            this.txtRePassword.TabIndex = 6;
            this.txtRePassword.UseSystemPasswordChar = true;
            this.txtRePassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtRePassword_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(312, 221);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 26);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(198, 312);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(377, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Tôi đã đọc và đồng ý với các điều khoản được ghi";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(192, 274);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(151, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Điều khoản sử dụng";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(312, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // provider
            // 
            this.provider.ContainerControl = this;
            // 
            // frmResister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.rp);
            this.Controls.Add(this.p);
            this.Controls.Add(this.u);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmResister";
            this.Text = "frmResister";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmResister_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label u;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label rp;
        private System.Windows.Forms.Label ph;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider provider;
    }
}