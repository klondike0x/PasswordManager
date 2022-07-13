namespace PasswordManager
{
    partial class MasterPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPassword));
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxKlondike = new System.Windows.Forms.PictureBox();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.textBoxMasterPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMasterPassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlondike)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(31, 160);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(111, 23);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(162, 160);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(111, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistration.ForeColor = System.Drawing.Color.White;
            this.buttonRegistration.Location = new System.Drawing.Point(31, 189);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(242, 23);
            this.buttonRegistration.TabIndex = 8;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.pictureBoxKlondike);
            this.panel1.Controls.Add(this.labelMainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 30);
            this.panel1.TabIndex = 9;
            // 
            // pictureBoxKlondike
            // 
            this.pictureBoxKlondike.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxKlondike.Image = global::PasswordManager.Properties.Resources.logo;
            this.pictureBoxKlondike.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxKlondike.Name = "pictureBoxKlondike";
            this.pictureBoxKlondike.Size = new System.Drawing.Size(34, 30);
            this.pictureBoxKlondike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKlondike.TabIndex = 2;
            this.pictureBoxKlondike.TabStop = false;
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainMenu.ForeColor = System.Drawing.Color.White;
            this.labelMainMenu.Location = new System.Drawing.Point(39, 5);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(127, 19);
            this.labelMainMenu.TabIndex = 1;
            this.labelMainMenu.Text = "Мастер паролей";
            // 
            // textBoxMasterPassword
            // 
            this.textBoxMasterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxMasterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMasterPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxMasterPassword.Location = new System.Drawing.Point(31, 104);
            this.textBoxMasterPassword.Name = "textBoxMasterPassword";
            this.textBoxMasterPassword.Size = new System.Drawing.Size(242, 21);
            this.textBoxMasterPassword.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Подтверждение личности";
            // 
            // checkBoxMasterPassword
            // 
            this.checkBoxMasterPassword.AutoSize = true;
            this.checkBoxMasterPassword.Checked = true;
            this.checkBoxMasterPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMasterPassword.ForeColor = System.Drawing.Color.White;
            this.checkBoxMasterPassword.Location = new System.Drawing.Point(31, 131);
            this.checkBoxMasterPassword.Name = "checkBoxMasterPassword";
            this.checkBoxMasterPassword.Size = new System.Drawing.Size(113, 17);
            this.checkBoxMasterPassword.TabIndex = 11;
            this.checkBoxMasterPassword.Text = "Показать пароль";
            this.checkBoxMasterPassword.UseVisualStyleBackColor = true;
            // 
            // MasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.checkBoxMasterPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMasterPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEnter);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterPassword";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастер паролей";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlondike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxKlondike;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.TextBox textBoxMasterPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMasterPassword;
    }
}