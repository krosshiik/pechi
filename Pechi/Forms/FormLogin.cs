using Pechi.DataBase;

namespace Pechi.Forms
{
    public partial class FormLogin : Form
    {
        public RegistrationData user;
        readonly Context context = new();

        public FormLogin()
        {
            InitializeComponent();
            TBPass.PasswordChar = '*';
        }

        public FormLogin(string? login, string? password)
        {
            InitializeComponent();
            if (login != null && password != null)
            {
                TBLog.Text = login;
                TBPass.Text = password;
            }
        }

        private void BLog_Click(object sender, EventArgs e)
        {
            var login = TBLog.Text;
            var password = TBPass.Text;

            user = context.Регистрация.FirstOrDefault(x =>
            x.Login == login && x.Password == password);

            if (user != null)
            {
                Program.formProstoi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
