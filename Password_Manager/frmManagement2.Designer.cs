namespace Password_Manager
{
    partial class frmManagement2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagement2));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.txtFindAccount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.picCopyRight = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnInstruction = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnChangeMasterKey = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCreateAccount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.dgvPasswordManager = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkPassword = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.accountHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteVisible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordManager)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(193)))), ((int)(((byte)(149)))));
            this.sideMenu.Controls.Add(this.txtFindAccount);
            this.sideMenu.Controls.Add(this.lblCopyright);
            this.sideMenu.Controls.Add(this.picCopyRight);
            this.sideMenu.Controls.Add(this.pictureBox1);
            this.sideMenu.Controls.Add(this.logo);
            this.sideMenu.Controls.Add(this.btnLogout);
            this.sideMenu.Controls.Add(this.btnInstruction);
            this.sideMenu.Controls.Add(this.btnChangeMasterKey);
            this.sideMenu.Controls.Add(this.btnCreateAccount);
            this.logoTransition.SetDecoration(this.sideMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTransition.SetDecoration(this.sideMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(347, 676);
            this.sideMenu.TabIndex = 0;
            // 
            // txtFindAccount
            // 
            this.txtFindAccount.AcceptsReturn = false;
            this.txtFindAccount.AcceptsTab = false;
            this.txtFindAccount.AnimationSpeed = 200;
            this.txtFindAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFindAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFindAccount.BackColor = System.Drawing.Color.Transparent;
            this.txtFindAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFindAccount.BackgroundImage")));
            this.txtFindAccount.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFindAccount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFindAccount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFindAccount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFindAccount.BorderRadius = 35;
            this.txtFindAccount.BorderThickness = 1;
            this.txtFindAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFindAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelTransition.SetDecoration(this.txtFindAccount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.txtFindAccount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtFindAccount.DefaultFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAccount.DefaultText = "";
            this.txtFindAccount.FillColor = System.Drawing.Color.White;
            this.txtFindAccount.HideSelection = true;
            this.txtFindAccount.IconLeft = null;
            this.txtFindAccount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindAccount.IconPadding = 10;
            this.txtFindAccount.IconRight = null;
            this.txtFindAccount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindAccount.Lines = new string[0];
            this.txtFindAccount.Location = new System.Drawing.Point(16, 118);
            this.txtFindAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindAccount.MaxLength = 32767;
            this.txtFindAccount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFindAccount.Modified = false;
            this.txtFindAccount.Multiline = false;
            this.txtFindAccount.Name = "txtFindAccount";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindAccount.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFindAccount.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindAccount.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindAccount.OnIdleState = stateProperties4;
            this.txtFindAccount.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindAccount.PasswordChar = '\0';
            this.txtFindAccount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFindAccount.PlaceholderText = "Tìm kiếm tài khoản";
            this.txtFindAccount.ReadOnly = false;
            this.txtFindAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFindAccount.SelectedText = "";
            this.txtFindAccount.SelectionLength = 0;
            this.txtFindAccount.SelectionStart = 0;
            this.txtFindAccount.ShortcutsEnabled = true;
            this.txtFindAccount.Size = new System.Drawing.Size(319, 43);
            this.txtFindAccount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFindAccount.TabIndex = 8;
            this.txtFindAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFindAccount.TextMarginBottom = 0;
            this.txtFindAccount.TextMarginLeft = 3;
            this.txtFindAccount.TextMarginTop = 0;
            this.txtFindAccount.TextPlaceholder = "Tìm kiếm tài khoản";
            this.txtFindAccount.UseSystemPasswordChar = false;
            this.txtFindAccount.WordWrap = true;
            this.txtFindAccount.TextChanged += new System.EventHandler(this.txtFindAccount_TextChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.lblCopyright, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.lblCopyright, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblCopyright.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(61, 610);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(244, 23);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "Copyright by codezooteam";
            // 
            // picCopyRight
            // 
            this.picCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.picCopyRight, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.picCopyRight, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.picCopyRight.Image = ((System.Drawing.Image)(resources.GetObject("picCopyRight.Image")));
            this.picCopyRight.Location = new System.Drawing.Point(20, 607);
            this.picCopyRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCopyRight.Name = "picCopyRight";
            this.picCopyRight.Size = new System.Drawing.Size(41, 30);
            this.picCopyRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCopyRight.TabIndex = 6;
            this.picCopyRight.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.logo.AllowAnimations = true;
            this.logo.AllowMouseEffects = true;
            this.logo.AllowToggling = false;
            this.logo.AnimationSpeed = 200;
            this.logo.AutoGenerateColors = false;
            this.logo.AutoRoundBorders = false;
            this.logo.AutoSizeLeftIcon = true;
            this.logo.AutoSizeRightIcon = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackColor1 = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logo.ButtonText = "Password Manager";
            this.logo.ButtonTextMarginLeft = 0;
            this.logo.ColorContrastOnClick = 45;
            this.logo.ColorContrastOnHover = 45;
            this.logo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.logo.CustomizableEdges = borderEdges1;
            this.logoTransition.SetDecoration(this.logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTransition.SetDecoration(this.logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.logo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.logo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.logo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.logo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.logo.IconMarginLeft = 11;
            this.logo.IconPadding = 10;
            this.logo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.logo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.logo.IconSize = 25;
            this.logo.IdleBorderColor = System.Drawing.Color.Transparent;
            this.logo.IdleBorderRadius = 1;
            this.logo.IdleBorderThickness = 1;
            this.logo.IdleFillColor = System.Drawing.Color.Transparent;
            this.logo.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("logo.IdleIconLeftImage")));
            this.logo.IdleIconRightImage = null;
            this.logo.IndicateFocus = false;
            this.logo.Location = new System.Drawing.Point(4, 27);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.logo.OnDisabledState.BorderRadius = 1;
            this.logo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logo.OnDisabledState.BorderThickness = 1;
            this.logo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.logo.OnDisabledState.IconLeftImage = null;
            this.logo.OnDisabledState.IconRightImage = null;
            this.logo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.logo.onHoverState.BorderRadius = 1;
            this.logo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logo.onHoverState.BorderThickness = 1;
            this.logo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.logo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.logo.onHoverState.IconLeftImage = null;
            this.logo.onHoverState.IconRightImage = null;
            this.logo.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.logo.OnIdleState.BorderRadius = 1;
            this.logo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logo.OnIdleState.BorderThickness = 1;
            this.logo.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.logo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.logo.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("logo.OnIdleState.IconLeftImage")));
            this.logo.OnIdleState.IconRightImage = null;
            this.logo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.logo.OnPressedState.BorderRadius = 1;
            this.logo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logo.OnPressedState.BorderThickness = 1;
            this.logo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.logo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.logo.OnPressedState.IconLeftImage = null;
            this.logo.OnPressedState.IconRightImage = null;
            this.logo.Size = new System.Drawing.Size(228, 84);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.logo.TextMarginLeft = 0;
            this.logo.TextPadding = new System.Windows.Forms.Padding(0);
            this.logo.UseDefaultRadiusAndThickness = true;
            // 
            // btnLogout
            // 
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowMouseEffects = true;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AnimationSpeed = 200;
            this.btnLogout.AutoGenerateColors = false;
            this.btnLogout.AutoRoundBorders = false;
            this.btnLogout.AutoSizeLeftIcon = true;
            this.btnLogout.AutoSizeRightIcon = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColor1 = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.ButtonText = "Đăng Xuất";
            this.btnLogout.ButtonTextMarginLeft = 0;
            this.btnLogout.ColorContrastOnClick = 45;
            this.btnLogout.ColorContrastOnHover = 45;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnLogout.CustomizableEdges = borderEdges2;
            this.logoTransition.SetDecoration(this.btnLogout, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnLogout, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogout.IconMarginLeft = 11;
            this.btnLogout.IconPadding = 10;
            this.btnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogout.IconSize = 25;
            this.btnLogout.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.IdleBorderRadius = 35;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLogout.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.IdleIconLeftImage")));
            this.btnLogout.IdleIconRightImage = null;
            this.btnLogout.IndicateFocus = false;
            this.btnLogout.Location = new System.Drawing.Point(8, 384);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.OnDisabledState.BorderRadius = 35;
            this.btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnDisabledState.BorderThickness = 1;
            this.btnLogout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.OnDisabledState.IconLeftImage = null;
            this.btnLogout.OnDisabledState.IconRightImage = null;
            this.btnLogout.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLogout.onHoverState.BorderRadius = 35;
            this.btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.onHoverState.BorderThickness = 1;
            this.btnLogout.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLogout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.onHoverState.IconLeftImage = null;
            this.btnLogout.onHoverState.IconRightImage = null;
            this.btnLogout.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnIdleState.BorderRadius = 35;
            this.btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnIdleState.BorderThickness = 1;
            this.btnLogout.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnIdleState.IconLeftImage")));
            this.btnLogout.OnIdleState.IconRightImage = null;
            this.btnLogout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogout.OnPressedState.BorderRadius = 35;
            this.btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnPressedState.BorderThickness = 1;
            this.btnLogout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnPressedState.IconLeftImage = null;
            this.btnLogout.OnPressedState.IconRightImage = null;
            this.btnLogout.Size = new System.Drawing.Size(335, 63);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.TabStop = false;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.TextMarginLeft = 0;
            this.btnLogout.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogout.UseDefaultRadiusAndThickness = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInstruction
            // 
            this.btnInstruction.AllowAnimations = true;
            this.btnInstruction.AllowMouseEffects = true;
            this.btnInstruction.AllowToggling = false;
            this.btnInstruction.AnimationSpeed = 200;
            this.btnInstruction.AutoGenerateColors = false;
            this.btnInstruction.AutoRoundBorders = false;
            this.btnInstruction.AutoSizeLeftIcon = true;
            this.btnInstruction.AutoSizeRightIcon = true;
            this.btnInstruction.BackColor = System.Drawing.Color.Transparent;
            this.btnInstruction.BackColor1 = System.Drawing.Color.Transparent;
            this.btnInstruction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstruction.BackgroundImage")));
            this.btnInstruction.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstruction.ButtonText = "Hướng Dẫn";
            this.btnInstruction.ButtonTextMarginLeft = 0;
            this.btnInstruction.ColorContrastOnClick = 45;
            this.btnInstruction.ColorContrastOnHover = 45;
            this.btnInstruction.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnInstruction.CustomizableEdges = borderEdges3;
            this.logoTransition.SetDecoration(this.btnInstruction, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnInstruction, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnInstruction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInstruction.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInstruction.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInstruction.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInstruction.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnInstruction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInstruction.ForeColor = System.Drawing.Color.White;
            this.btnInstruction.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstruction.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInstruction.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnInstruction.IconMarginLeft = 11;
            this.btnInstruction.IconPadding = 10;
            this.btnInstruction.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInstruction.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInstruction.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInstruction.IconSize = 25;
            this.btnInstruction.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnInstruction.IdleBorderRadius = 35;
            this.btnInstruction.IdleBorderThickness = 1;
            this.btnInstruction.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnInstruction.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnInstruction.IdleIconLeftImage")));
            this.btnInstruction.IdleIconRightImage = null;
            this.btnInstruction.IndicateFocus = false;
            this.btnInstruction.Location = new System.Drawing.Point(4, 313);
            this.btnInstruction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInstruction.OnDisabledState.BorderRadius = 35;
            this.btnInstruction.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstruction.OnDisabledState.BorderThickness = 1;
            this.btnInstruction.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInstruction.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInstruction.OnDisabledState.IconLeftImage = null;
            this.btnInstruction.OnDisabledState.IconRightImage = null;
            this.btnInstruction.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnInstruction.onHoverState.BorderRadius = 35;
            this.btnInstruction.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstruction.onHoverState.BorderThickness = 1;
            this.btnInstruction.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnInstruction.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInstruction.onHoverState.IconLeftImage = null;
            this.btnInstruction.onHoverState.IconRightImage = null;
            this.btnInstruction.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnInstruction.OnIdleState.BorderRadius = 35;
            this.btnInstruction.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstruction.OnIdleState.BorderThickness = 1;
            this.btnInstruction.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnInstruction.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnInstruction.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnInstruction.OnIdleState.IconLeftImage")));
            this.btnInstruction.OnIdleState.IconRightImage = null;
            this.btnInstruction.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnInstruction.OnPressedState.BorderRadius = 35;
            this.btnInstruction.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInstruction.OnPressedState.BorderThickness = 1;
            this.btnInstruction.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnInstruction.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInstruction.OnPressedState.IconLeftImage = null;
            this.btnInstruction.OnPressedState.IconRightImage = null;
            this.btnInstruction.Size = new System.Drawing.Size(335, 63);
            this.btnInstruction.TabIndex = 2;
            this.btnInstruction.TabStop = false;
            this.btnInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInstruction.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInstruction.TextMarginLeft = 0;
            this.btnInstruction.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInstruction.UseDefaultRadiusAndThickness = true;
            // 
            // btnChangeMasterKey
            // 
            this.btnChangeMasterKey.AllowAnimations = true;
            this.btnChangeMasterKey.AllowMouseEffects = true;
            this.btnChangeMasterKey.AllowToggling = false;
            this.btnChangeMasterKey.AnimationSpeed = 200;
            this.btnChangeMasterKey.AutoGenerateColors = false;
            this.btnChangeMasterKey.AutoRoundBorders = false;
            this.btnChangeMasterKey.AutoSizeLeftIcon = true;
            this.btnChangeMasterKey.AutoSizeRightIcon = true;
            this.btnChangeMasterKey.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeMasterKey.BackColor1 = System.Drawing.Color.Transparent;
            this.btnChangeMasterKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeMasterKey.BackgroundImage")));
            this.btnChangeMasterKey.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeMasterKey.ButtonText = "Đổi MasterKey";
            this.btnChangeMasterKey.ButtonTextMarginLeft = 0;
            this.btnChangeMasterKey.ColorContrastOnClick = 45;
            this.btnChangeMasterKey.ColorContrastOnHover = 45;
            this.btnChangeMasterKey.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnChangeMasterKey.CustomizableEdges = borderEdges4;
            this.logoTransition.SetDecoration(this.btnChangeMasterKey, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnChangeMasterKey, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnChangeMasterKey.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChangeMasterKey.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChangeMasterKey.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChangeMasterKey.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChangeMasterKey.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnChangeMasterKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeMasterKey.ForeColor = System.Drawing.Color.White;
            this.btnChangeMasterKey.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeMasterKey.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeMasterKey.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnChangeMasterKey.IconMarginLeft = 11;
            this.btnChangeMasterKey.IconPadding = 10;
            this.btnChangeMasterKey.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeMasterKey.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeMasterKey.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnChangeMasterKey.IconSize = 25;
            this.btnChangeMasterKey.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnChangeMasterKey.IdleBorderRadius = 35;
            this.btnChangeMasterKey.IdleBorderThickness = 1;
            this.btnChangeMasterKey.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnChangeMasterKey.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnChangeMasterKey.IdleIconLeftImage")));
            this.btnChangeMasterKey.IdleIconRightImage = null;
            this.btnChangeMasterKey.IndicateFocus = false;
            this.btnChangeMasterKey.Location = new System.Drawing.Point(4, 240);
            this.btnChangeMasterKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeMasterKey.Name = "btnChangeMasterKey";
            this.btnChangeMasterKey.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChangeMasterKey.OnDisabledState.BorderRadius = 35;
            this.btnChangeMasterKey.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeMasterKey.OnDisabledState.BorderThickness = 1;
            this.btnChangeMasterKey.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChangeMasterKey.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChangeMasterKey.OnDisabledState.IconLeftImage = null;
            this.btnChangeMasterKey.OnDisabledState.IconRightImage = null;
            this.btnChangeMasterKey.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnChangeMasterKey.onHoverState.BorderRadius = 35;
            this.btnChangeMasterKey.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeMasterKey.onHoverState.BorderThickness = 1;
            this.btnChangeMasterKey.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnChangeMasterKey.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnChangeMasterKey.onHoverState.IconLeftImage = null;
            this.btnChangeMasterKey.onHoverState.IconRightImage = null;
            this.btnChangeMasterKey.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnChangeMasterKey.OnIdleState.BorderRadius = 35;
            this.btnChangeMasterKey.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeMasterKey.OnIdleState.BorderThickness = 1;
            this.btnChangeMasterKey.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnChangeMasterKey.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnChangeMasterKey.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnChangeMasterKey.OnIdleState.IconLeftImage")));
            this.btnChangeMasterKey.OnIdleState.IconRightImage = null;
            this.btnChangeMasterKey.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnChangeMasterKey.OnPressedState.BorderRadius = 35;
            this.btnChangeMasterKey.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeMasterKey.OnPressedState.BorderThickness = 1;
            this.btnChangeMasterKey.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnChangeMasterKey.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnChangeMasterKey.OnPressedState.IconLeftImage = null;
            this.btnChangeMasterKey.OnPressedState.IconRightImage = null;
            this.btnChangeMasterKey.Size = new System.Drawing.Size(335, 63);
            this.btnChangeMasterKey.TabIndex = 2;
            this.btnChangeMasterKey.TabStop = false;
            this.btnChangeMasterKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeMasterKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChangeMasterKey.TextMarginLeft = 0;
            this.btnChangeMasterKey.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnChangeMasterKey.UseDefaultRadiusAndThickness = true;
            this.btnChangeMasterKey.Click += new System.EventHandler(this.btnChangeMasterKey_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.AllowAnimations = true;
            this.btnCreateAccount.AllowMouseEffects = true;
            this.btnCreateAccount.AllowToggling = false;
            this.btnCreateAccount.AnimationSpeed = 200;
            this.btnCreateAccount.AutoGenerateColors = false;
            this.btnCreateAccount.AutoRoundBorders = false;
            this.btnCreateAccount.AutoSizeLeftIcon = true;
            this.btnCreateAccount.AutoSizeRightIcon = true;
            this.btnCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.BackColor1 = System.Drawing.Color.Transparent;
            this.btnCreateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.BackgroundImage")));
            this.btnCreateAccount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateAccount.ButtonText = "Tạo tài khoản";
            this.btnCreateAccount.ButtonTextMarginLeft = 0;
            this.btnCreateAccount.ColorContrastOnClick = 45;
            this.btnCreateAccount.ColorContrastOnHover = 45;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnCreateAccount.CustomizableEdges = borderEdges5;
            this.logoTransition.SetDecoration(this.btnCreateAccount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnCreateAccount, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnCreateAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateAccount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreateAccount.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreateAccount.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreateAccount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAccount.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateAccount.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCreateAccount.IconMarginLeft = 11;
            this.btnCreateAccount.IconPadding = 10;
            this.btnCreateAccount.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAccount.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateAccount.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCreateAccount.IconSize = 25;
            this.btnCreateAccount.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.IdleBorderRadius = 35;
            this.btnCreateAccount.IdleBorderThickness = 1;
            this.btnCreateAccount.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.IdleIconLeftImage")));
            this.btnCreateAccount.IdleIconRightImage = null;
            this.btnCreateAccount.IndicateFocus = false;
            this.btnCreateAccount.Location = new System.Drawing.Point(4, 169);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreateAccount.OnDisabledState.BorderRadius = 35;
            this.btnCreateAccount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateAccount.OnDisabledState.BorderThickness = 1;
            this.btnCreateAccount.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreateAccount.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreateAccount.OnDisabledState.IconLeftImage = null;
            this.btnCreateAccount.OnDisabledState.IconRightImage = null;
            this.btnCreateAccount.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCreateAccount.onHoverState.BorderRadius = 35;
            this.btnCreateAccount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateAccount.onHoverState.BorderThickness = 1;
            this.btnCreateAccount.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCreateAccount.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.onHoverState.IconLeftImage = null;
            this.btnCreateAccount.onHoverState.IconRightImage = null;
            this.btnCreateAccount.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.OnIdleState.BorderRadius = 35;
            this.btnCreateAccount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateAccount.OnIdleState.BorderThickness = 1;
            this.btnCreateAccount.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.OnIdleState.IconLeftImage")));
            this.btnCreateAccount.OnIdleState.IconRightImage = null;
            this.btnCreateAccount.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCreateAccount.OnPressedState.BorderRadius = 35;
            this.btnCreateAccount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateAccount.OnPressedState.BorderThickness = 1;
            this.btnCreateAccount.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCreateAccount.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.OnPressedState.IconLeftImage = null;
            this.btnCreateAccount.OnPressedState.IconRightImage = null;
            this.btnCreateAccount.Size = new System.Drawing.Size(335, 63);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.TabStop = false;
            this.btnCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateAccount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateAccount.TextMarginLeft = 0;
            this.btnCreateAccount.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCreateAccount.UseDefaultRadiusAndThickness = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // panelTransition
            // 
            this.panelTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Mosaic;
            this.panelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelTransition.DefaultAnimation = animation1;
            // 
            // dgvPasswordManager
            // 
            this.dgvPasswordManager.AllowCustomTheming = false;
            this.dgvPasswordManager.AllowUserToAddRows = false;
            this.dgvPasswordManager.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPasswordManager.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPasswordManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasswordManager.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPasswordManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPasswordManager.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPasswordManager.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPasswordManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPasswordManager.ColumnHeadersHeight = 40;
            this.dgvPasswordManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Website,
            this.Account,
            this.Password,
            this.chkPassword,
            this.Edit,
            this.accountHidden,
            this.passwordHidden,
            this.noteVisible});
            this.dgvPasswordManager.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvPasswordManager.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPasswordManager.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPasswordManager.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPasswordManager.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPasswordManager.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvPasswordManager.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPasswordManager.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvPasswordManager.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPasswordManager.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPasswordManager.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvPasswordManager.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPasswordManager.CurrentTheme.Name = null;
            this.dgvPasswordManager.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPasswordManager.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPasswordManager.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPasswordManager.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPasswordManager.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.logoTransition.SetDecoration(this.dgvPasswordManager, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTransition.SetDecoration(this.dgvPasswordManager, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPasswordManager.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPasswordManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPasswordManager.EnableHeadersVisualStyles = false;
            this.dgvPasswordManager.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPasswordManager.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvPasswordManager.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPasswordManager.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPasswordManager.Location = new System.Drawing.Point(347, 0);
            this.dgvPasswordManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPasswordManager.Name = "dgvPasswordManager";
            this.dgvPasswordManager.RowHeadersVisible = false;
            this.dgvPasswordManager.RowHeadersWidth = 62;
            this.dgvPasswordManager.RowTemplate.Height = 40;
            this.dgvPasswordManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasswordManager.Size = new System.Drawing.Size(1022, 676);
            this.dgvPasswordManager.TabIndex = 1;
            this.dgvPasswordManager.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvPasswordManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasswordManager_CellContentClick);
            this.dgvPasswordManager.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasswordManager_CellContentDoubleClick);
            this.dgvPasswordManager.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPasswordManager_CellFormatting);
            // 
            // Website
            // 
            this.Website.HeaderText = "Website";
            this.Website.MinimumWidth = 8;
            this.Website.Name = "Website";
            this.Website.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.HeaderText = "Tài khoản";
            this.Account.MinimumWidth = 8;
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Mật khẩu";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // chkPassword
            // 
            this.chkPassword.HeaderText = "Hiện mật khẩu";
            this.chkPassword.MinimumWidth = 8;
            this.chkPassword.Name = "chkPassword";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            // 
            // accountHidden
            // 
            this.accountHidden.HeaderText = "Hiển thị ID";
            this.accountHidden.MinimumWidth = 8;
            this.accountHidden.Name = "accountHidden";
            this.accountHidden.Visible = false;
            // 
            // passwordHidden
            // 
            this.passwordHidden.HeaderText = "Hiển thị mật khẩu";
            this.passwordHidden.MinimumWidth = 8;
            this.passwordHidden.Name = "passwordHidden";
            this.passwordHidden.Visible = false;
            // 
            // noteVisible
            // 
            this.noteVisible.HeaderText = "Ẩn ghi chú";
            this.noteVisible.MinimumWidth = 8;
            this.noteVisible.Name = "noteVisible";
            this.noteVisible.Visible = false;
            // 
            // logoTransition
            // 
            this.logoTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logoTransition.DefaultAnimation = animation2;
            // 
            // frmManagement2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1369, 676);
            this.Controls.Add(this.dgvPasswordManager);
            this.Controls.Add(this.sideMenu);
            this.logoTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManagement2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagement2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagement2_FormClosing);
            this.sideMenu.ResumeLayout(false);
            this.sideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.UI.WinForms.BunifuTransition logoTransition;
        private Bunifu.UI.WinForms.BunifuTransition panelTransition;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton logo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInstruction;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChangeMasterKey;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCreateAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPasswordManager;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private Bunifu.UI.WinForms.BunifuTextBox txtFindAccount;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox picCopyRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkPassword;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteVisible;
    }
}