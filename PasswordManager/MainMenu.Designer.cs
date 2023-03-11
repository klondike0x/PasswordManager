namespace PasswordManager
{
    /// <summary>
    /// Дизайнерская форма Менеджер паролей
    /// </summary>
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizedForm = new System.Windows.Forms.Label();
            this.pictureBoxKlondike = new System.Windows.Forms.PictureBox();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.exitForm = new System.Windows.Forms.Label();
            this.textBoxPasswordList = new System.Windows.Forms.TextBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelCountPassword = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.checkBoxNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxLowerCase = new System.Windows.Forms.CheckBox();
            this.checkBoxUpperCase = new System.Windows.Forms.CheckBox();
            this.labelLenght = new System.Windows.Forms.Label();
            this.trackBarLenght = new System.Windows.Forms.TrackBar();
            this.buttonGenerator = new System.Windows.Forms.Button();
            this.buttonSavePassword = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelCountPasswordResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonInformation = new System.Windows.Forms.Label();
            this.trackBarCountPassword = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlondike)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.minimizedForm);
            this.panel1.Controls.Add(this.pictureBoxKlondike);
            this.panel1.Controls.Add(this.labelMainMenu);
            this.panel1.Controls.Add(this.exitForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 30);
            this.panel1.TabIndex = 0;
            // 
            // minimizedForm
            // 
            this.minimizedForm.AutoSize = true;
            this.minimizedForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizedForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizedForm.ForeColor = System.Drawing.Color.White;
            this.minimizedForm.Location = new System.Drawing.Point(448, 0);
            this.minimizedForm.Name = "minimizedForm";
            this.minimizedForm.Size = new System.Drawing.Size(25, 26);
            this.minimizedForm.TabIndex = 3;
            this.minimizedForm.Text = "—";
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
            this.labelMainMenu.Location = new System.Drawing.Point(38, 5);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(150, 19);
            this.labelMainMenu.TabIndex = 1;
            this.labelMainMenu.Text = "Менеджер паролей";
            // 
            // exitForm
            // 
            this.exitForm.AutoSize = true;
            this.exitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitForm.ForeColor = System.Drawing.Color.White;
            this.exitForm.Location = new System.Drawing.Point(473, 0);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(27, 26);
            this.exitForm.TabIndex = 0;
            this.exitForm.Text = "X";
            // 
            // textBoxPasswordList
            // 
            this.textBoxPasswordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBoxPasswordList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordList.ForeColor = System.Drawing.Color.White;
            this.textBoxPasswordList.Location = new System.Drawing.Point(247, 52);
            this.textBoxPasswordList.Multiline = true;
            this.textBoxPasswordList.Name = "textBoxPasswordList";
            this.textBoxPasswordList.ReadOnly = true;
            this.textBoxPasswordList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPasswordList.Size = new System.Drawing.Size(241, 176);
            this.textBoxPasswordList.TabIndex = 3;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.trackBarCountPassword);
            this.groupBoxSettings.Controls.Add(this.radioButton1);
            this.groupBoxSettings.Controls.Add(this.labelCountPassword);
            this.groupBoxSettings.Controls.Add(this.buttonReset);
            this.groupBoxSettings.Controls.Add(this.checkBoxSpecial);
            this.groupBoxSettings.Controls.Add(this.checkBoxNumber);
            this.groupBoxSettings.Controls.Add(this.checkBoxLowerCase);
            this.groupBoxSettings.Controls.Add(this.checkBoxUpperCase);
            this.groupBoxSettings.Controls.Add(this.labelLenght);
            this.groupBoxSettings.Controls.Add(this.trackBarLenght);
            this.groupBoxSettings.ForeColor = System.Drawing.Color.White;
            this.groupBoxSettings.Location = new System.Drawing.Point(10, 36);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(231, 250);
            this.groupBoxSettings.TabIndex = 4;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Параметры пароля";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 224);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Рекомендации";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelCountPassword
            // 
            this.labelCountPassword.AutoSize = true;
            this.labelCountPassword.Location = new System.Drawing.Point(15, 81);
            this.labelCountPassword.Name = "labelCountPassword";
            this.labelCountPassword.Size = new System.Drawing.Size(112, 13);
            this.labelCountPassword.TabIndex = 9;
            this.labelCountPassword.Text = "Количество паролей";
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Location = new System.Drawing.Point(131, 221);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Восстановить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // checkBoxSpecial
            // 
            this.checkBoxSpecial.AutoSize = true;
            this.checkBoxSpecial.Location = new System.Drawing.Point(65, 175);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(51, 17);
            this.checkBoxSpecial.TabIndex = 6;
            this.checkBoxSpecial.Text = "$%^&";
            this.checkBoxSpecial.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumber
            // 
            this.checkBoxNumber.AutoSize = true;
            this.checkBoxNumber.Location = new System.Drawing.Point(65, 152);
            this.checkBoxNumber.Name = "checkBoxNumber";
            this.checkBoxNumber.Size = new System.Drawing.Size(42, 17);
            this.checkBoxNumber.TabIndex = 5;
            this.checkBoxNumber.Text = "0-9";
            this.checkBoxNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowerCase
            // 
            this.checkBoxLowerCase.AutoSize = true;
            this.checkBoxLowerCase.Location = new System.Drawing.Point(16, 175);
            this.checkBoxLowerCase.Name = "checkBoxLowerCase";
            this.checkBoxLowerCase.Size = new System.Drawing.Size(41, 17);
            this.checkBoxLowerCase.TabIndex = 4;
            this.checkBoxLowerCase.Text = "a-z";
            this.checkBoxLowerCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperCase
            // 
            this.checkBoxUpperCase.AutoSize = true;
            this.checkBoxUpperCase.Location = new System.Drawing.Point(16, 152);
            this.checkBoxUpperCase.Name = "checkBoxUpperCase";
            this.checkBoxUpperCase.Size = new System.Drawing.Size(43, 17);
            this.checkBoxUpperCase.TabIndex = 3;
            this.checkBoxUpperCase.Text = "A-Z";
            this.checkBoxUpperCase.UseVisualStyleBackColor = true;
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Location = new System.Drawing.Point(15, 25);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(78, 13);
            this.labelLenght.TabIndex = 2;
            this.labelLenght.Text = "Длина пароля";
            // 
            // trackBarLenght
            // 
            this.trackBarLenght.Location = new System.Drawing.Point(6, 41);
            this.trackBarLenght.Maximum = 32;
            this.trackBarLenght.Minimum = 4;
            this.trackBarLenght.Name = "trackBarLenght";
            this.trackBarLenght.Size = new System.Drawing.Size(191, 45);
            this.trackBarLenght.TabIndex = 1;
            this.trackBarLenght.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarLenght.Value = 4;
            this.trackBarLenght.Validating += new System.ComponentModel.CancelEventHandler(this.trackBar1_Validating);
            // 
            // buttonGenerator
            // 
            this.buttonGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerator.ForeColor = System.Drawing.Color.White;
            this.buttonGenerator.Location = new System.Drawing.Point(247, 263);
            this.buttonGenerator.Name = "buttonGenerator";
            this.buttonGenerator.Size = new System.Drawing.Size(241, 23);
            this.buttonGenerator.TabIndex = 5;
            this.buttonGenerator.Text = "Сгенерировать пароль";
            this.buttonGenerator.UseVisualStyleBackColor = true;
            this.buttonGenerator.Click += new System.EventHandler(this.buttonGenerator_Click);
            // 
            // buttonSavePassword
            // 
            this.buttonSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSavePassword.ForeColor = System.Drawing.Color.White;
            this.buttonSavePassword.Location = new System.Drawing.Point(247, 234);
            this.buttonSavePassword.Name = "buttonSavePassword";
            this.buttonSavePassword.Size = new System.Drawing.Size(111, 23);
            this.buttonSavePassword.TabIndex = 6;
            this.buttonSavePassword.Text = "Сохранить пароли";
            this.buttonSavePassword.UseVisualStyleBackColor = true;
            this.buttonSavePassword.Click += new System.EventHandler(this.buttonSavePassword_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(364, 234);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(124, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelCountPasswordResult
            // 
            this.labelCountPasswordResult.AutoSize = true;
            this.labelCountPasswordResult.ForeColor = System.Drawing.Color.White;
            this.labelCountPasswordResult.Location = new System.Drawing.Point(244, 36);
            this.labelCountPasswordResult.Name = "labelCountPasswordResult";
            this.labelCountPasswordResult.Size = new System.Drawing.Size(209, 13);
            this.labelCountPasswordResult.TabIndex = 10;
            this.labelCountPasswordResult.Text = "Количество сгенерированных паролей:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonInformation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 23);
            this.panel2.TabIndex = 11;
            // 
            // buttonInformation
            // 
            this.buttonInformation.AutoSize = true;
            this.buttonInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInformation.ForeColor = System.Drawing.Color.White;
            this.buttonInformation.Location = new System.Drawing.Point(402, 2);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonInformation.Size = new System.Drawing.Size(94, 17);
            this.buttonInformation.TabIndex = 5;
            this.buttonInformation.Text = "О программе";
            // 
            // trackBarCountPassword
            // 
            this.trackBarCountPassword.Location = new System.Drawing.Point(6, 97);
            this.trackBarCountPassword.Maximum = 50;
            this.trackBarCountPassword.Minimum = 1;
            this.trackBarCountPassword.Name = "trackBarCountPassword";
            this.trackBarCountPassword.Size = new System.Drawing.Size(191, 45);
            this.trackBarCountPassword.TabIndex = 11;
            this.trackBarCountPassword.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarCountPassword.Value = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(500, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelCountPasswordResult);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSavePassword);
            this.Controls.Add(this.buttonGenerator);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.textBoxPasswordList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер паролей";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlondike)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitForm;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.TextBox textBoxPasswordList;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonGenerator;
        private System.Windows.Forms.Button buttonSavePassword;
        private System.Windows.Forms.Label labelLenght;
        private System.Windows.Forms.TrackBar trackBarLenght;
        private System.Windows.Forms.CheckBox checkBoxUpperCase;
        private System.Windows.Forms.CheckBox checkBoxNumber;
        private System.Windows.Forms.CheckBox checkBoxLowerCase;
        private System.Windows.Forms.CheckBox checkBoxSpecial;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBoxKlondike;
        private System.Windows.Forms.Label minimizedForm;
        private System.Windows.Forms.Label labelCountPassword;
        private System.Windows.Forms.Label labelCountPasswordResult;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label buttonInformation;
        private System.Windows.Forms.TrackBar trackBarCountPassword;
    }
}

