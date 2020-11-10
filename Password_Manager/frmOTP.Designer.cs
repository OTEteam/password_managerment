namespace Password_Manager
{
    partial class frmOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOTP));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOTP = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnConfirmOTP = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(171, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "OTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã OTP đã được gửi đến số điện thoại của bạn";
            // 
            // txtOTP
            // 
            this.txtOTP.AcceptsReturn = false;
            this.txtOTP.AcceptsTab = false;
            this.txtOTP.AnimationSpeed = 200;
            this.txtOTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOTP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOTP.BackColor = System.Drawing.Color.Transparent;
            this.txtOTP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtOTP.BackgroundImage")));
            this.txtOTP.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtOTP.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtOTP.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtOTP.BorderColorIdle = System.Drawing.Color.LightGreen;
            this.txtOTP.BorderRadius = 35;
            this.txtOTP.BorderThickness = 1;
            this.txtOTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.DefaultFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtOTP.DefaultText = "";
            this.txtOTP.FillColor = System.Drawing.Color.White;
            this.txtOTP.HideSelection = true;
            this.txtOTP.IconLeft = null;
            this.txtOTP.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.IconPadding = 10;
            this.txtOTP.IconRight = null;
            this.txtOTP.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.Lines = new string[0];
            this.txtOTP.Location = new System.Drawing.Point(80, 142);
            this.txtOTP.MaxLength = 32767;
            this.txtOTP.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtOTP.Modified = false;
            this.txtOTP.Multiline = false;
            this.txtOTP.Name = "txtOTP";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtOTP.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtOTP.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtOTP.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.LightGreen;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtOTP.OnIdleState = stateProperties8;
            this.txtOTP.Padding = new System.Windows.Forms.Padding(3);
            this.txtOTP.PasswordChar = '\0';
            this.txtOTP.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOTP.PlaceholderText = "Mật khẩu 1 lần dùng (6 số)";
            this.txtOTP.ReadOnly = false;
            this.txtOTP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOTP.SelectedText = "";
            this.txtOTP.SelectionLength = 0;
            this.txtOTP.SelectionStart = 0;
            this.txtOTP.ShortcutsEnabled = true;
            this.txtOTP.Size = new System.Drawing.Size(281, 43);
            this.txtOTP.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtOTP.TabIndex = 3;
            this.txtOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP.TextMarginBottom = 0;
            this.txtOTP.TextMarginLeft = 3;
            this.txtOTP.TextMarginTop = 0;
            this.txtOTP.TextPlaceholder = "Mật khẩu 1 lần dùng (6 số)";
            this.txtOTP.UseSystemPasswordChar = false;
            this.txtOTP.WordWrap = true;
            // 
            // btnConfirmOTP
            // 
            this.btnConfirmOTP.AllowAnimations = true;
            this.btnConfirmOTP.AllowMouseEffects = true;
            this.btnConfirmOTP.AllowToggling = false;
            this.btnConfirmOTP.AnimationSpeed = 200;
            this.btnConfirmOTP.AutoGenerateColors = false;
            this.btnConfirmOTP.AutoRoundBorders = false;
            this.btnConfirmOTP.AutoSizeLeftIcon = true;
            this.btnConfirmOTP.AutoSizeRightIcon = true;
            this.btnConfirmOTP.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmOTP.BackColor1 = System.Drawing.Color.LightGreen;
            this.btnConfirmOTP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmOTP.BackgroundImage")));
            this.btnConfirmOTP.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmOTP.ButtonText = "Xác Nhận";
            this.btnConfirmOTP.ButtonTextMarginLeft = 0;
            this.btnConfirmOTP.ColorContrastOnClick = 45;
            this.btnConfirmOTP.ColorContrastOnHover = 45;
            this.btnConfirmOTP.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnConfirmOTP.CustomizableEdges = borderEdges2;
            this.btnConfirmOTP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmOTP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmOTP.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmOTP.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmOTP.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmOTP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOTP.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmOTP.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmOTP.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmOTP.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirmOTP.IconMarginLeft = 11;
            this.btnConfirmOTP.IconPadding = 10;
            this.btnConfirmOTP.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmOTP.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmOTP.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirmOTP.IconSize = 25;
            this.btnConfirmOTP.IdleBorderColor = System.Drawing.Color.LightGreen;
            this.btnConfirmOTP.IdleBorderRadius = 35;
            this.btnConfirmOTP.IdleBorderThickness = 1;
            this.btnConfirmOTP.IdleFillColor = System.Drawing.Color.LightGreen;
            this.btnConfirmOTP.IdleIconLeftImage = null;
            this.btnConfirmOTP.IdleIconRightImage = null;
            this.btnConfirmOTP.IndicateFocus = false;
            this.btnConfirmOTP.Location = new System.Drawing.Point(138, 205);
            this.btnConfirmOTP.Name = "btnConfirmOTP";
            this.btnConfirmOTP.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmOTP.OnDisabledState.BorderRadius = 35;
            this.btnConfirmOTP.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmOTP.OnDisabledState.BorderThickness = 1;
            this.btnConfirmOTP.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmOTP.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmOTP.OnDisabledState.IconLeftImage = null;
            this.btnConfirmOTP.OnDisabledState.IconRightImage = null;
            this.btnConfirmOTP.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmOTP.onHoverState.BorderRadius = 35;
            this.btnConfirmOTP.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmOTP.onHoverState.BorderThickness = 1;
            this.btnConfirmOTP.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmOTP.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOTP.onHoverState.IconLeftImage = null;
            this.btnConfirmOTP.onHoverState.IconRightImage = null;
            this.btnConfirmOTP.OnIdleState.BorderColor = System.Drawing.Color.LightGreen;
            this.btnConfirmOTP.OnIdleState.BorderRadius = 35;
            this.btnConfirmOTP.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmOTP.OnIdleState.BorderThickness = 1;
            this.btnConfirmOTP.OnIdleState.FillColor = System.Drawing.Color.LightGreen;
            this.btnConfirmOTP.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmOTP.OnIdleState.IconLeftImage = null;
            this.btnConfirmOTP.OnIdleState.IconRightImage = null;
            this.btnConfirmOTP.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmOTP.OnPressedState.BorderRadius = 35;
            this.btnConfirmOTP.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmOTP.OnPressedState.BorderThickness = 1;
            this.btnConfirmOTP.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmOTP.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOTP.OnPressedState.IconLeftImage = null;
            this.btnConfirmOTP.OnPressedState.IconRightImage = null;
            this.btnConfirmOTP.Size = new System.Drawing.Size(150, 39);
            this.btnConfirmOTP.TabIndex = 4;
            this.btnConfirmOTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmOTP.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmOTP.TextMarginLeft = 0;
            this.btnConfirmOTP.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirmOTP.UseDefaultRadiusAndThickness = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 305);
            this.Controls.Add(this.btnConfirmOTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOTP";
            this.Text = "frmOTP";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txtOTP;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmOTP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}