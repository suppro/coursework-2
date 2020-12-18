using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ARU
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private String getHash(String text)
        {
            byte[] hashenc, bytes = Encoding.ASCII.GetBytes(text);
            String result = "";

            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                hashenc = md5.ComputeHash(bytes);
                foreach (var b in hashenc)
                    result += b.ToString("x2");
            }

            return result;
        }

        private void loginUser(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (String.IsNullOrEmpty(login) || login.Equals("Логин"))
            {
                MessageBox.Show("Не введен логин", "Информация"); return;
            }
            else if (String.IsNullOrEmpty(password) || password.Equals("Пароль"))
            {
                MessageBox.Show("Не введен пароль", "Информация"); return;
            }

            password = getHash(getHash(password));

            Employee employee;
            bool userAuth = false;
            using (ARUDBEntities db = new ARUDBEntities())
            {
                employee = db.Employee.FirstOrDefault(u => u.login == login && u.password == password);
                if (employee != null)
                {
                    userAuth = true;
                }
            }
            if (!userAuth)
            {
                MessageBox.Show("Неправильный логин или пароль"); return;
            }
            else
            {
                this.Visible = false;
                ProgramForm userForm = new ProgramForm(login);
                userForm.Show();
            }
        }

        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
