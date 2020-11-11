namespace Password_Manager
{
    partial class frmMaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOlderPsw = new System.Windows.Forms.TextBox();
            this.txtNewPsw = new System.Windows.Forms.TextBox();
            this.txtReNewPsw = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.provider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.provider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-enter New Password";
            // 
            // txtOlderPsw
            // 
            this.txtOlderPsw.Location = new System.Drawing.Point(203, 77);
            this.txtOlderPsw.Name = "txtOlderPsw";
            this.txtOlderPsw.Size = new System.Drawing.Size(200, 26);
            this.txtOlderPsw.TabIndex = 3;
            this.txtOlderPsw.UseSystemPasswordChar = true;
            this.txtOlderPsw.TextChanged += new System.EventHandler(this.txtOlderPsw_TextChanged);
            this.txtOlderPsw.Validating += new System.ComponentModel.CancelEventHandler(this.txtOlderPsw_Validating);
            // 
            // txtNewPsw
            // 
            this.txtNewPsw.Location = new System.Drawing.Point(203, 113);
            this.txtNewPsw.Name = "txtNewPsw";
            this.txtNewPsw.Size = new System.Drawing.Size(200, 26);
            this.txtNewPsw.TabIndex = 4;
            this.txtNewPsw.UseSystemPasswordChar = true;
            this.txtNewPsw.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPsw_Validating);
            // 
            // txtReNewPsw
            // 
            this.txtReNewPsw.Location = new System.Drawing.Point(203, 148);
            this.txtReNewPsw.Name = "txtReNewPsw";
            this.txtReNewPsw.Size = new System.Drawing.Size(200, 26);
            this.txtReNewPsw.TabIndex = 5;
            this.txtReNewPsw.UseSystemPasswordChar = true;
            this.txtReNewPsw.Validating += new System.ComponentModel.CancelEventHandler(this.txtReNewPsw_Validating);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(194, 205);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(99, 36);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(309, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // provider
            // 
            this.provider.ContainerControl = this;
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtReNewPsw);
            this.Controls.Add(this.txtNewPsw);
            this.Controls.Add(this.txtOlderPsw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMaster";
            this.Text = "frmMaster";
            ((System.ComponentModel.ISupportInitialize)(this.provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOlderPsw;
        private System.Windows.Forms.TextBox txtNewPsw;
        private System.Windows.Forms.TextBox txtReNewPsw;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider provider;
    }
}