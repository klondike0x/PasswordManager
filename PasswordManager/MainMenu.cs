using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace PasswordManager
{
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Главная форма Менеджер паролей
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            trackBarLenght.Validating += trackBar1_Validating;

            Point lastpoint = new Point();
            groupBoxSettings.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Left += e.X - lastpoint.X;
                    Top += e.Y - lastpoint.Y;
                }
            };
            groupBoxSettings.MouseDown += (s, e) =>
            {
                lastpoint = new Point(e.X, e.Y);
            };

            panel1.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Left += e.X - lastpoint.X;
                    Top += e.Y - lastpoint.Y;
                }
            };
            panel1.MouseDown += (s, e) =>
            {
                lastpoint = new Point(e.X, e.Y);
            };

            pictureBoxKlondike.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Left += e.X - lastpoint.X;
                    Top += e.Y - lastpoint.Y;
                }
            };
            pictureBoxKlondike.MouseDown += (s, e) =>
            {
                lastpoint = new Point(e.X, e.Y);
            };
            pictureBoxKlondike.MouseClick += (s, e) =>
            {
                Process.Start("https://vk.com/klondike0x");
            };

            labelMainMenu.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Left += e.X - lastpoint.X;
                    Top += e.Y - lastpoint.Y;
                }
            };
            labelMainMenu.MouseDown += (s, e) =>
            {
                lastpoint = new Point(e.X, e.Y);
            };

            exitForm.Click += (s, e) =>
            {
                if (MessageBox.Show("Вы действительно хотите покинуть текущую сессию?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Form form = Application.OpenForms[0];
                    form.Show();
                    Close();
                }
            };
            exitForm.MouseEnter += (s, e) =>
            {
                exitForm.ForeColor = Color.Red;
            };
            exitForm.MouseLeave += (s, e) =>
            {
                exitForm.ForeColor = Color.White;
            };

            minimizedForm.Click += (s, e) =>
            {
                WindowState = FormWindowState.Minimized;
            };
            minimizedForm.MouseEnter += (s, e) =>
            {
                minimizedForm.ForeColor = Color.Red;
            };
            minimizedForm.MouseLeave += (s, e) =>
            {
                minimizedForm.ForeColor = Color.White;
            };

            labelLenght.Text = string.Format($"Длина пароля: 0");
            trackBarLenght.Scroll += (s, e) =>
            {
                labelLenght.Text = string.Format($"Длина пароля: {trackBarLenght.Value}");
            };

            labelCountPasswordResult.Text = string.Format($"Количество сгенерированных паролей: 0");

            buttonClear.Click += (s, e) =>
            {
                textBoxPasswordList.Clear();
                labelCountPasswordResult.Text = string.Format($"Количество сгенерированных паролей: {textBoxPasswordList.Lines.Length}");
            };

            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked == false)
                {
                    MessageBox.Show("Выберите параметры пароля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Метод на создание генерацию паролей
        /// </summary>
        Random random = new Random();
        private string PasswordGenerator(bool upperCase, bool lowerCase, bool number, bool specialCharacter, int passwordLenght)
        {
            const string UPPER_CASE = "QWERTYUIOPASDFGHJKLZXCVBNM";
            const string LOWER_CASE = "qwertyuiopasdfghjklzxcvbnm";
            const string NUMERIC = "1234567890";
            const string SPECIAL_CHARACTERS = @"~!@#$%^&*()+=-";

            char[] password = new char[passwordLenght];
            string charset = "";
            if (upperCase)
                charset += UPPER_CASE;
            if (lowerCase)
                charset += LOWER_CASE;
            if (number)
                charset += NUMERIC;
            if (specialCharacter)
                charset += SPECIAL_CHARACTERS;
            if (charset == "")
                MessageBox.Show("Выберите параметры для паролей", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                for (int i = 0; i < passwordLenght; i++)
                    password[i] = charset[random.Next(charset.Length - 1)];
            }
            return string.Join(null, password);
        }

        /// <summary>
        /// Метод для сгенерирование пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerator_Click(object sender, EventArgs e)
        {
            if (trackBarLenght.Value <= 0)
            {
                MessageBox.Show("Выберите длину пароля", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBoxPasswordList.Select(0, 0);
            }
            else
            {
                for (int i = 0; i < numericUpDownCountPassword.Value; i++)
                {
                    textBoxPasswordList.Text += PasswordGenerator(
                        checkBoxUpperCase.Checked,
                        checkBoxLowerCase.Checked,
                        checkBoxNumber.Checked,
                        checkBoxSpecial.Checked,
                        trackBarLenght.Value);
                    textBoxPasswordList.AppendText(Environment.NewLine);
                    
                    labelCountPasswordResult.Text = string.Format($"Количество сгенерированных паролей: {textBoxPasswordList.Lines.Length - 1}");
                }
            }
        }

        /// <summary>
        /// Метод для восстановление параметра генерации пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelLenght.Text = string.Format($"Длина пароля: {trackBarLenght.Value = 0}");
            numericUpDownCountPassword.Value = 1;
            checkBoxUpperCase.CheckState = 0;
            checkBoxLowerCase.CheckState = 0;
            checkBoxNumber.CheckState = 0;
            checkBoxSpecial.CheckState = 0;
        }

        /// <summary>
        /// Метод который сохраняет сгенерированные пароли
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите сохранить пароль?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
                {
                    string fileName = saveFileDialog1.FileName;
                    File.WriteAllText(fileName, textBoxPasswordList.Text);
                    MessageBox.Show("Пароли успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Метод подсказка с предупреждением, если пароль меньше указанной рекомендации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(trackBarLenght.Value.ToString()))
                errorProvider1.SetError(trackBarLenght, "Не указано длина пароля!");
            else if (trackBarLenght.Value < 12)
                errorProvider1.SetError(trackBarLenght, "Длина пароля слишком мал!");
            else
                errorProvider1.Clear();
        }
    }
}