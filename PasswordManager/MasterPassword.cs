using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MasterPassword : Form
    {
        public string password = string.Empty;
        private ClassUsers users = new ClassUsers();
        public MasterPassword()
        {
            InitializeComponent();

            LoadUsers();

            Point lastpoint = new Point();
            MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Left += e.X - lastpoint.X;
                    Top += e.Y - lastpoint.Y;
                }
            };
            MouseDown += (s, e) =>
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

            buttonEnter.Click += (s, e) =>
            {
                if (textBoxMasterPassword.Text == "")
                {
                    MessageBox.Show("Пустое поле с паролем!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                EnterToFrom();
            };

            buttonExit.Click += (s, e) =>
            {
                if (MessageBox.Show("Вы действительно хотите выйти?", "Окно выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            buttonRegistration.Click += (s, e) =>
            {
                AddUser();
            };

            checkBoxMasterPassword.CheckedChanged += (s, e) =>
            {
                if (checkBoxMasterPassword.Checked == true)
                    textBoxMasterPassword.PasswordChar = '\0';
                else
                    textBoxMasterPassword.PasswordChar = '*';
            };
        }

        private void LoadUsers()
        {
            try
            {
                FileStream fs = new FileStream("Users.dat", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                users = (ClassUsers)formatter.Deserialize(fs);
                fs.Close();
                if (users == null)
                    buttonRegistration.Visible = true;
                else
                    buttonRegistration.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AddUser()
        {
            if (textBoxMasterPassword.Text == "")
            {
                MessageBox.Show("Пустое поле с паролем!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password == textBoxMasterPassword.Text)
            {
                MessageBox.Show("Такой пароль существует!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            users.Password.Add(textBoxMasterPassword.Text);
            FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate);
            File.SetAttributes(Environment.CurrentDirectory + "\\Users.dat", FileAttributes.Hidden);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, users);
            fs.Close();
            MessageBox.Show("Регистрация прошла успешно", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            password = textBoxMasterPassword.Text;
            textBoxMasterPassword.Clear();
            buttonRegistration.Visible = false;
        }

        private void EnterToFrom()
        {
            for (int i = 0; i < users.Password.Count; i++)
            {
                if (users.Password[i] == textBoxMasterPassword.Text)
                {
                    password = users.Password[i];
                    textBoxMasterPassword.Clear();

                    MessageBox.Show("Вы вошли в систему!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    Hide();
                }
                else if (textBoxMasterPassword.Text != users.Password[i])
                {
                    password = users.Password[i];

                    MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
    }
}
