namespace EduardApplication_v0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginSaverLb = new System.Windows.Forms.Label();
            this.PasswordSaverLb = new System.Windows.Forms.Label();
            this.AccountSaverBt = new System.Windows.Forms.Button();
            this.AccountLoginTb = new System.Windows.Forms.TextBox();
            this.AccountPasswordTb = new System.Windows.Forms.TextBox();
            this.GeneratedPasswordTb = new System.Windows.Forms.TextBox();
            this.PasswordGeneratorLb = new System.Windows.Forms.Label();
            this.CopySavedPasswordBt = new System.Windows.Forms.Button();
            this.GeneratePasswordBt = new System.Windows.Forms.Button();
            this.AccountsListbx = new System.Windows.Forms.ListBox();
            this.LoadAccountLb = new System.Windows.Forms.Label();
            this.AuthorizationLogInBt = new System.Windows.Forms.Button();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.AuthorizationLoginLb = new System.Windows.Forms.Label();
            this.AuthorizationPasswordLb = new System.Windows.Forms.Label();
            this.AuthorizationLoginTb = new System.Windows.Forms.TextBox();
            this.AuthorizationPasswordTb = new System.Windows.Forms.TextBox();
            this.AuthorizationGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthorizationNotificationLabel = new System.Windows.Forms.Label();
            this.AuthorizationRegisterBt = new System.Windows.Forms.Button();
            this.PasswordGeneratorGroupBox = new System.Windows.Forms.GroupBox();
            this.IsCopiedGeneratorLb = new System.Windows.Forms.Label();
            this.CopyGeneratedPasswordBt = new System.Windows.Forms.Button();
            this.NumberOfGeneratedSymbolsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.LengthPasswordLb = new System.Windows.Forms.Label();
            this.SaveLoadAndCopyGroupBox = new System.Windows.Forms.GroupBox();
            this.IsCopiedAccountPasswordLb = new System.Windows.Forms.Label();
            this.ShowAccountModeChkbx = new System.Windows.Forms.CheckBox();
            this.NameServiceLb = new System.Windows.Forms.Label();
            this.NameServiceTb = new System.Windows.Forms.TextBox();
            this.DeleteAccountBt = new System.Windows.Forms.Button();
            this.AuthorizationGroupBox.SuspendLayout();
            this.PasswordGeneratorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfGeneratedSymbolsNumUpDown)).BeginInit();
            this.SaveLoadAndCopyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginSaverLb
            // 
            this.LoginSaverLb.AutoSize = true;
            this.LoginSaverLb.Location = new System.Drawing.Point(11, 80);
            this.LoginSaverLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginSaverLb.Name = "LoginSaverLb";
            this.LoginSaverLb.Size = new System.Drawing.Size(115, 20);
            this.LoginSaverLb.TabIndex = 0;
            this.LoginSaverLb.Text = "Account login:";
            // 
            // PasswordSaverLb
            // 
            this.PasswordSaverLb.AutoSize = true;
            this.PasswordSaverLb.Location = new System.Drawing.Point(11, 119);
            this.PasswordSaverLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordSaverLb.Name = "PasswordSaverLb";
            this.PasswordSaverLb.Size = new System.Drawing.Size(152, 20);
            this.PasswordSaverLb.TabIndex = 1;
            this.PasswordSaverLb.Text = "Account password:";
            // 
            // AccountSaverBt
            // 
            this.AccountSaverBt.Location = new System.Drawing.Point(11, 168);
            this.AccountSaverBt.Margin = new System.Windows.Forms.Padding(2);
            this.AccountSaverBt.Name = "AccountSaverBt";
            this.AccountSaverBt.Size = new System.Drawing.Size(142, 31);
            this.AccountSaverBt.TabIndex = 2;
            this.AccountSaverBt.Text = "Save Account";
            this.AccountSaverBt.UseVisualStyleBackColor = true;
            this.AccountSaverBt.Click += new System.EventHandler(this.AccountSaverBt_Click);
            // 
            // AccountLoginTb
            // 
            this.AccountLoginTb.Location = new System.Drawing.Point(112, 77);
            this.AccountLoginTb.Margin = new System.Windows.Forms.Padding(2);
            this.AccountLoginTb.Name = "AccountLoginTb";
            this.AccountLoginTb.Size = new System.Drawing.Size(194, 26);
            this.AccountLoginTb.TabIndex = 3;
            this.AccountLoginTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountLoginTb_KeyPress);
            // 
            // AccountPasswordTb
            // 
            this.AccountPasswordTb.Location = new System.Drawing.Point(142, 116);
            this.AccountPasswordTb.Margin = new System.Windows.Forms.Padding(2);
            this.AccountPasswordTb.MaxLength = 32;
            this.AccountPasswordTb.Name = "AccountPasswordTb";
            this.AccountPasswordTb.PasswordChar = '*';
            this.AccountPasswordTb.Size = new System.Drawing.Size(164, 26);
            this.AccountPasswordTb.TabIndex = 4;
            this.AccountPasswordTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountPasswordTb_KeyPress);
            // 
            // GeneratedPasswordTb
            // 
            this.GeneratedPasswordTb.Location = new System.Drawing.Point(159, 32);
            this.GeneratedPasswordTb.Margin = new System.Windows.Forms.Padding(2);
            this.GeneratedPasswordTb.Name = "GeneratedPasswordTb";
            this.GeneratedPasswordTb.ReadOnly = true;
            this.GeneratedPasswordTb.Size = new System.Drawing.Size(170, 26);
            this.GeneratedPasswordTb.TabIndex = 5;
            // 
            // PasswordGeneratorLb
            // 
            this.PasswordGeneratorLb.AutoSize = true;
            this.PasswordGeneratorLb.Location = new System.Drawing.Point(10, 35);
            this.PasswordGeneratorLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordGeneratorLb.Name = "PasswordGeneratorLb";
            this.PasswordGeneratorLb.Size = new System.Drawing.Size(171, 20);
            this.PasswordGeneratorLb.TabIndex = 6;
            this.PasswordGeneratorLb.Text = "Generated Password:";
            // 
            // CopySavedPasswordBt
            // 
            this.CopySavedPasswordBt.Location = new System.Drawing.Point(160, 168);
            this.CopySavedPasswordBt.Margin = new System.Windows.Forms.Padding(2);
            this.CopySavedPasswordBt.Name = "CopySavedPasswordBt";
            this.CopySavedPasswordBt.Size = new System.Drawing.Size(146, 31);
            this.CopySavedPasswordBt.TabIndex = 7;
            this.CopySavedPasswordBt.Text = "Copy Password";
            this.CopySavedPasswordBt.UseVisualStyleBackColor = true;
            this.CopySavedPasswordBt.Click += new System.EventHandler(this.CopySavedPasswordBt_Click);
            // 
            // GeneratePasswordBt
            // 
            this.GeneratePasswordBt.Location = new System.Drawing.Point(340, 17);
            this.GeneratePasswordBt.Margin = new System.Windows.Forms.Padding(2);
            this.GeneratePasswordBt.Name = "GeneratePasswordBt";
            this.GeneratePasswordBt.Size = new System.Drawing.Size(84, 30);
            this.GeneratePasswordBt.TabIndex = 8;
            this.GeneratePasswordBt.Text = "Generate";
            this.GeneratePasswordBt.UseVisualStyleBackColor = true;
            this.GeneratePasswordBt.Click += new System.EventHandler(this.GeneratePasswordBt_Click);
            // 
            // AccountsListbx
            // 
            this.AccountsListbx.FormattingEnabled = true;
            this.AccountsListbx.ItemHeight = 20;
            this.AccountsListbx.Location = new System.Drawing.Point(371, 52);
            this.AccountsListbx.Margin = new System.Windows.Forms.Padding(2);
            this.AccountsListbx.Name = "AccountsListbx";
            this.AccountsListbx.ScrollAlwaysVisible = true;
            this.AccountsListbx.Size = new System.Drawing.Size(177, 104);
            this.AccountsListbx.TabIndex = 1;
            this.AccountsListbx.SelectedIndexChanged += new System.EventHandler(this.AccountsListbx_SelectedIndexChanged);
            // 
            // LoadAccountLb
            // 
            this.LoadAccountLb.AutoSize = true;
            this.LoadAccountLb.Location = new System.Drawing.Point(367, 21);
            this.LoadAccountLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoadAccountLb.Name = "LoadAccountLb";
            this.LoadAccountLb.Size = new System.Drawing.Size(137, 20);
            this.LoadAccountLb.TabIndex = 11;
            this.LoadAccountLb.Text = "Choose Account:";
            // 
            // AuthorizationLogInBt
            // 
            this.AuthorizationLogInBt.Location = new System.Drawing.Point(306, 51);
            this.AuthorizationLogInBt.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorizationLogInBt.Name = "AuthorizationLogInBt";
            this.AuthorizationLogInBt.Size = new System.Drawing.Size(77, 29);
            this.AuthorizationLogInBt.TabIndex = 12;
            this.AuthorizationLogInBt.Text = "Log In";
            this.AuthorizationLogInBt.UseVisualStyleBackColor = true;
            this.AuthorizationLogInBt.Click += new System.EventHandler(this.AuthorizationLogInBt_Click);
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Location = new System.Drawing.Point(10, 23);
            this.AuthorizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(226, 20);
            this.AuthorizationLabel.TabIndex = 13;
            this.AuthorizationLabel.Text = "Enter or create Your Account";
            // 
            // AuthorizationLoginLb
            // 
            this.AuthorizationLoginLb.AutoSize = true;
            this.AuthorizationLoginLb.Location = new System.Drawing.Point(7, 62);
            this.AuthorizationLoginLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorizationLoginLb.Name = "AuthorizationLoginLb";
            this.AuthorizationLoginLb.Size = new System.Drawing.Size(50, 20);
            this.AuthorizationLoginLb.TabIndex = 14;
            this.AuthorizationLoginLb.Text = "Login";
            // 
            // AuthorizationPasswordLb
            // 
            this.AuthorizationPasswordLb.AutoSize = true;
            this.AuthorizationPasswordLb.Location = new System.Drawing.Point(128, 62);
            this.AuthorizationPasswordLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorizationPasswordLb.Name = "AuthorizationPasswordLb";
            this.AuthorizationPasswordLb.Size = new System.Drawing.Size(83, 20);
            this.AuthorizationPasswordLb.TabIndex = 15;
            this.AuthorizationPasswordLb.Text = "Password";
            // 
            // AuthorizationLoginTb
            // 
            this.AuthorizationLoginTb.Location = new System.Drawing.Point(49, 59);
            this.AuthorizationLoginTb.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorizationLoginTb.Name = "AuthorizationLoginTb";
            this.AuthorizationLoginTb.Size = new System.Drawing.Size(76, 26);
            this.AuthorizationLoginTb.TabIndex = 16;
            this.AuthorizationLoginTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AuthorizationLoginTb_KeyPress);
            // 
            // AuthorizationPasswordTb
            // 
            this.AuthorizationPasswordTb.Location = new System.Drawing.Point(195, 59);
            this.AuthorizationPasswordTb.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorizationPasswordTb.Name = "AuthorizationPasswordTb";
            this.AuthorizationPasswordTb.PasswordChar = '*';
            this.AuthorizationPasswordTb.Size = new System.Drawing.Size(76, 26);
            this.AuthorizationPasswordTb.TabIndex = 17;
            this.AuthorizationPasswordTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AuthorizationPasswordTb_KeyPress);
            // 
            // AuthorizationGroupBox
            // 
            this.AuthorizationGroupBox.Controls.Add(this.AuthorizationNotificationLabel);
            this.AuthorizationGroupBox.Controls.Add(this.AuthorizationRegisterBt);
            this.AuthorizationGroupBox.Controls.Add(this.AuthorizationLogInBt);
            this.AuthorizationGroupBox.Controls.Add(this.AuthorizationPasswordTb);
            this.AuthorizationGroupBox.Controls.Add(this.AuthorizationLabel);
            this.AuthorizationGroupBox.Controls.Add(this.AuthorizationLoginTb);
            this.AuthorizationGroupBox.Controls.Add(this.AuthorizationLoginLb);
            this.AuthorizationGroupBox.Controls.Add(this.AuthorizationPasswordLb);
            this.AuthorizationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationGroupBox.Location = new System.Drawing.Point(8, 129);
            this.AuthorizationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorizationGroupBox.Name = "AuthorizationGroupBox";
            this.AuthorizationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.AuthorizationGroupBox.Size = new System.Drawing.Size(562, 92);
            this.AuthorizationGroupBox.TabIndex = 18;
            this.AuthorizationGroupBox.TabStop = false;
            this.AuthorizationGroupBox.Text = "Autorization";
            // 
            // AuthorizationNotificationLabel
            // 
            this.AuthorizationNotificationLabel.AutoSize = true;
            this.AuthorizationNotificationLabel.Location = new System.Drawing.Point(240, 21);
            this.AuthorizationNotificationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorizationNotificationLabel.Name = "AuthorizationNotificationLabel";
            this.AuthorizationNotificationLabel.Size = new System.Drawing.Size(0, 20);
            this.AuthorizationNotificationLabel.TabIndex = 21;
            // 
            // AuthorizationRegisterBt
            // 
            this.AuthorizationRegisterBt.Location = new System.Drawing.Point(418, 50);
            this.AuthorizationRegisterBt.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorizationRegisterBt.Name = "AuthorizationRegisterBt";
            this.AuthorizationRegisterBt.Size = new System.Drawing.Size(77, 31);
            this.AuthorizationRegisterBt.TabIndex = 18;
            this.AuthorizationRegisterBt.Text = "Register";
            this.AuthorizationRegisterBt.UseVisualStyleBackColor = true;
            this.AuthorizationRegisterBt.Click += new System.EventHandler(this.AuthorizationRegisterBt_Click);
            // 
            // PasswordGeneratorGroupBox
            // 
            this.PasswordGeneratorGroupBox.Controls.Add(this.IsCopiedGeneratorLb);
            this.PasswordGeneratorGroupBox.Controls.Add(this.CopyGeneratedPasswordBt);
            this.PasswordGeneratorGroupBox.Controls.Add(this.NumberOfGeneratedSymbolsNumUpDown);
            this.PasswordGeneratorGroupBox.Controls.Add(this.LengthPasswordLb);
            this.PasswordGeneratorGroupBox.Controls.Add(this.GeneratePasswordBt);
            this.PasswordGeneratorGroupBox.Controls.Add(this.GeneratedPasswordTb);
            this.PasswordGeneratorGroupBox.Controls.Add(this.PasswordGeneratorLb);
            this.PasswordGeneratorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordGeneratorGroupBox.Location = new System.Drawing.Point(9, 12);
            this.PasswordGeneratorGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordGeneratorGroupBox.Name = "PasswordGeneratorGroupBox";
            this.PasswordGeneratorGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.PasswordGeneratorGroupBox.Size = new System.Drawing.Size(561, 83);
            this.PasswordGeneratorGroupBox.TabIndex = 19;
            this.PasswordGeneratorGroupBox.TabStop = false;
            this.PasswordGeneratorGroupBox.Text = "Generator";
            // 
            // IsCopiedGeneratorLb
            // 
            this.IsCopiedGeneratorLb.AutoSize = true;
            this.IsCopiedGeneratorLb.Location = new System.Drawing.Point(438, 52);
            this.IsCopiedGeneratorLb.Name = "IsCopiedGeneratorLb";
            this.IsCopiedGeneratorLb.Size = new System.Drawing.Size(0, 20);
            this.IsCopiedGeneratorLb.TabIndex = 12;
            // 
            // CopyGeneratedPasswordBt
            // 
            this.CopyGeneratedPasswordBt.Location = new System.Drawing.Point(340, 52);
            this.CopyGeneratedPasswordBt.Margin = new System.Windows.Forms.Padding(2);
            this.CopyGeneratedPasswordBt.Name = "CopyGeneratedPasswordBt";
            this.CopyGeneratedPasswordBt.Size = new System.Drawing.Size(84, 26);
            this.CopyGeneratedPasswordBt.TabIndex = 11;
            this.CopyGeneratedPasswordBt.Text = "Copy";
            this.CopyGeneratedPasswordBt.UseVisualStyleBackColor = true;
            this.CopyGeneratedPasswordBt.Click += new System.EventHandler(this.CopyGeneratedPasswordBt_Click);
            // 
            // NumberOfGeneratedSymbolsNumUpDown
            // 
            this.NumberOfGeneratedSymbolsNumUpDown.Location = new System.Drawing.Point(498, 15);
            this.NumberOfGeneratedSymbolsNumUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.NumberOfGeneratedSymbolsNumUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumberOfGeneratedSymbolsNumUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumberOfGeneratedSymbolsNumUpDown.Name = "NumberOfGeneratedSymbolsNumUpDown";
            this.NumberOfGeneratedSymbolsNumUpDown.Size = new System.Drawing.Size(38, 26);
            this.NumberOfGeneratedSymbolsNumUpDown.TabIndex = 10;
            this.NumberOfGeneratedSymbolsNumUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // LengthPasswordLb
            // 
            this.LengthPasswordLb.AutoSize = true;
            this.LengthPasswordLb.Location = new System.Drawing.Point(438, 17);
            this.LengthPasswordLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LengthPasswordLb.Name = "LengthPasswordLb";
            this.LengthPasswordLb.Size = new System.Drawing.Size(65, 20);
            this.LengthPasswordLb.TabIndex = 9;
            this.LengthPasswordLb.Text = "Length:";
            // 
            // SaveLoadAndCopyGroupBox
            // 
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.DeleteAccountBt);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.NameServiceLb);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.NameServiceTb);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.IsCopiedAccountPasswordLb);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.PasswordSaverLb);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.LoginSaverLb);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.AccountSaverBt);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.LoadAccountLb);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.AccountLoginTb);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.AccountsListbx);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.AccountPasswordTb);
            this.SaveLoadAndCopyGroupBox.Controls.Add(this.CopySavedPasswordBt);
            this.SaveLoadAndCopyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveLoadAndCopyGroupBox.Location = new System.Drawing.Point(8, 226);
            this.SaveLoadAndCopyGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SaveLoadAndCopyGroupBox.Name = "SaveLoadAndCopyGroupBox";
            this.SaveLoadAndCopyGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SaveLoadAndCopyGroupBox.Size = new System.Drawing.Size(562, 218);
            this.SaveLoadAndCopyGroupBox.TabIndex = 20;
            this.SaveLoadAndCopyGroupBox.TabStop = false;
            this.SaveLoadAndCopyGroupBox.Text = "Save/Load/Copy";
            // 
            // IsCopiedAccountPasswordLb
            // 
            this.IsCopiedAccountPasswordLb.AutoSize = true;
            this.IsCopiedAccountPasswordLb.Location = new System.Drawing.Point(306, 147);
            this.IsCopiedAccountPasswordLb.Name = "IsCopiedAccountPasswordLb";
            this.IsCopiedAccountPasswordLb.Size = new System.Drawing.Size(0, 20);
            this.IsCopiedAccountPasswordLb.TabIndex = 12;
            // 
            // ShowAccountModeChkbx
            // 
            this.ShowAccountModeChkbx.AutoSize = true;
            this.ShowAccountModeChkbx.Checked = true;
            this.ShowAccountModeChkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAccountModeChkbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAccountModeChkbx.Location = new System.Drawing.Point(398, 104);
            this.ShowAccountModeChkbx.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAccountModeChkbx.Name = "ShowAccountModeChkbx";
            this.ShowAccountModeChkbx.Size = new System.Drawing.Size(184, 24);
            this.ShowAccountModeChkbx.TabIndex = 21;
            this.ShowAccountModeChkbx.Text = "Show Account Mode";
            this.ShowAccountModeChkbx.UseVisualStyleBackColor = true;
            this.ShowAccountModeChkbx.CheckedChanged += new System.EventHandler(this.ShowAccountModeChkbx_CheckedChanged);
            // 
            // NameServiceLb
            // 
            this.NameServiceLb.AutoSize = true;
            this.NameServiceLb.Location = new System.Drawing.Point(11, 40);
            this.NameServiceLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameServiceLb.Name = "NameServiceLb";
            this.NameServiceLb.Size = new System.Drawing.Size(70, 20);
            this.NameServiceLb.TabIndex = 13;
            this.NameServiceLb.Text = "Service:";
            // 
            // NameServiceTb
            // 
            this.NameServiceTb.Location = new System.Drawing.Point(68, 37);
            this.NameServiceTb.Margin = new System.Windows.Forms.Padding(2);
            this.NameServiceTb.Name = "NameServiceTb";
            this.NameServiceTb.Size = new System.Drawing.Size(238, 26);
            this.NameServiceTb.TabIndex = 14;
            // 
            // DeleteAccountBt
            // 
            this.DeleteAccountBt.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteAccountBt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteAccountBt.Location = new System.Drawing.Point(371, 168);
            this.DeleteAccountBt.Name = "DeleteAccountBt";
            this.DeleteAccountBt.Size = new System.Drawing.Size(177, 31);
            this.DeleteAccountBt.TabIndex = 15;
            this.DeleteAccountBt.Text = "Delete Chosen";
            this.DeleteAccountBt.UseVisualStyleBackColor = false;
            this.DeleteAccountBt.Click += new System.EventHandler(this.DeleteAccountBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.ShowAccountModeChkbx);
            this.Controls.Add(this.SaveLoadAndCopyGroupBox);
            this.Controls.Add(this.PasswordGeneratorGroupBox);
            this.Controls.Add(this.AuthorizationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Vault & Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AuthorizationGroupBox.ResumeLayout(false);
            this.AuthorizationGroupBox.PerformLayout();
            this.PasswordGeneratorGroupBox.ResumeLayout(false);
            this.PasswordGeneratorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfGeneratedSymbolsNumUpDown)).EndInit();
            this.SaveLoadAndCopyGroupBox.ResumeLayout(false);
            this.SaveLoadAndCopyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginSaverLb;
        private System.Windows.Forms.Label PasswordSaverLb;
        private System.Windows.Forms.Button AccountSaverBt;
        private System.Windows.Forms.TextBox AccountLoginTb;
        private System.Windows.Forms.TextBox AccountPasswordTb;
        private System.Windows.Forms.TextBox GeneratedPasswordTb;
        private System.Windows.Forms.Label PasswordGeneratorLb;
        private System.Windows.Forms.Button CopySavedPasswordBt;
        private System.Windows.Forms.Button GeneratePasswordBt;
        private System.Windows.Forms.ListBox AccountsListbx;
        private System.Windows.Forms.Label LoadAccountLb;
        private System.Windows.Forms.Button AuthorizationLogInBt;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.Label AuthorizationLoginLb;
        private System.Windows.Forms.Label AuthorizationPasswordLb;
        private System.Windows.Forms.TextBox AuthorizationLoginTb;
        private System.Windows.Forms.TextBox AuthorizationPasswordTb;
        private System.Windows.Forms.GroupBox AuthorizationGroupBox;
        private System.Windows.Forms.Button AuthorizationRegisterBt;
        private System.Windows.Forms.GroupBox PasswordGeneratorGroupBox;
        private System.Windows.Forms.GroupBox SaveLoadAndCopyGroupBox;
        private System.Windows.Forms.Button CopyGeneratedPasswordBt;
        private System.Windows.Forms.NumericUpDown NumberOfGeneratedSymbolsNumUpDown;
        private System.Windows.Forms.Label LengthPasswordLb;
        private System.Windows.Forms.Label AuthorizationNotificationLabel;
        private System.Windows.Forms.CheckBox ShowAccountModeChkbx;
        private System.Windows.Forms.Label IsCopiedGeneratorLb;
        private System.Windows.Forms.Label IsCopiedAccountPasswordLb;
        private System.Windows.Forms.Button DeleteAccountBt;
        private System.Windows.Forms.Label NameServiceLb;
        private System.Windows.Forms.TextBox NameServiceTb;
    }
}

