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
            this.labelCountPassword = new System.Windows.Forms.Label();
            this.numericUpDownCountPassword = new System.Windows.Forms.NumericUpDown();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlondike)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // minimizedForm
            // 
            this.minimizedForm.AutoSize = true;
            this.minimizedForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizedForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizedForm.ForeColor = System.Drawing.Color.White;
            this.minimizedForm.Location = new System.Drawing.Point(748, 0);
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
            this.exitForm.Location = new System.Drawing.Point(773, 0);
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
            this.textBoxPasswordList.Location = new System.Drawing.Point(388, 52);
            this.textBoxPasswordList.Multiline = true;
            this.textBoxPasswordList.Name = "textBoxPasswordList";
            this.textBoxPasswordList.ReadOnly = true;
            this.textBoxPasswordList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPasswordList.Size = new System.Drawing.Size(400, 355);
            this.textBoxPasswordList.TabIndex = 3;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.labelCountPassword);
            this.groupBoxSettings.Controls.Add(this.numericUpDownCountPassword);
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
            this.groupBoxSettings.Size = new System.Drawing.Size(372, 400);
            this.groupBoxSettings.TabIndex = 4;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Параметры пароля";
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
            // numericUpDownCountPassword
            // 
            this.numericUpDownCountPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDownCountPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownCountPassword.ForeColor = System.Drawing.Color.White;
            this.numericUpDownCountPassword.Location = new System.Drawing.Point(18, 97);
            this.numericUpDownCountPassword.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCountPassword.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountPassword.Name = "numericUpDownCountPassword";
            this.numericUpDownCountPassword.Size = new System.Drawing.Size(167, 21);
            this.numericUpDownCountPassword.TabIndex = 8;
            this.numericUpDownCountPassword.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Location = new System.Drawing.Point(272, 371);
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
            this.checkBoxSpecial.Location = new System.Drawing.Point(18, 198);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(101, 17);
            this.checkBoxSpecial.TabIndex = 6;
            this.checkBoxSpecial.Text = "Спец. символы";
            this.checkBoxSpecial.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumber
            // 
            this.checkBoxNumber.AutoSize = true;
            this.checkBoxNumber.Location = new System.Drawing.Point(18, 175);
            this.checkBoxNumber.Name = "checkBoxNumber";
            this.checkBoxNumber.Size = new System.Drawing.Size(81, 17);
            this.checkBoxNumber.TabIndex = 5;
            this.checkBoxNumber.Text = "Цифры 0-9";
            this.checkBoxNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowerCase
            // 
            this.checkBoxLowerCase.AutoSize = true;
            this.checkBoxLowerCase.Location = new System.Drawing.Point(18, 152);
            this.checkBoxLowerCase.Name = "checkBoxLowerCase";
            this.checkBoxLowerCase.Size = new System.Drawing.Size(135, 17);
            this.checkBoxLowerCase.TabIndex = 4;
            this.checkBoxLowerCase.Text = "Маленькие буквы a-z";
            this.checkBoxLowerCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperCase
            // 
            this.checkBoxUpperCase.AutoSize = true;
            this.checkBoxUpperCase.Location = new System.Drawing.Point(18, 129);
            this.checkBoxUpperCase.Name = "checkBoxUpperCase";
            this.checkBoxUpperCase.Size = new System.Drawing.Size(125, 17);
            this.checkBoxUpperCase.TabIndex = 3;
            this.checkBoxUpperCase.Text = "Большие буквы A-Z";
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
            this.trackBarLenght.Name = "trackBarLenght";
            this.trackBarLenght.Size = new System.Drawing.Size(300, 45);
            this.trackBarLenght.TabIndex = 1;
            this.trackBarLenght.Validating += new System.ComponentModel.CancelEventHandler(this.trackBar1_Validating);
            // 
            // buttonGenerator
            // 
            this.buttonGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerator.ForeColor = System.Drawing.Color.White;
            this.buttonGenerator.Location = new System.Drawing.Point(677, 413);
            this.buttonGenerator.Name = "buttonGenerator";
            this.buttonGenerator.Size = new System.Drawing.Size(111, 23);
            this.buttonGenerator.TabIndex = 5;
            this.buttonGenerator.Text = "Сгенерировать";
            this.buttonGenerator.UseVisualStyleBackColor = true;
            this.buttonGenerator.Click += new System.EventHandler(this.buttonGenerator_Click);
            // 
            // buttonSavePassword
            // 
            this.buttonSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSavePassword.ForeColor = System.Drawing.Color.White;
            this.buttonSavePassword.Location = new System.Drawing.Point(388, 413);
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
            this.buttonClear.Location = new System.Drawing.Point(593, 413);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 23);
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
            this.labelCountPasswordResult.Location = new System.Drawing.Point(388, 36);
            this.labelCountPasswordResult.Name = "labelCountPasswordResult";
            this.labelCountPasswordResult.Size = new System.Drawing.Size(209, 13);
            this.labelCountPasswordResult.TabIndex = 10;
            this.labelCountPasswordResult.Text = "Количество сгенерированных паролей:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlondike)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownCountPassword;
        private System.Windows.Forms.Label labelCountPasswordResult;
    }
}

