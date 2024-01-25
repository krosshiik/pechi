using Pechi.DataBase;

namespace Pechi.Forms
{
    public partial class FormRegistration : Form
    {
        readonly Context context = new();
        private RegistrationData user;

        public FormRegistration()
        {
            InitializeComponent();
            TBPass1.PasswordChar = '*';
            TBPass2.PasswordChar = '*';
        }

        private void BReg_Click(object sender, EventArgs e)
        {
            try
            {
                var login = TBLog.Text;
                var password1 = TBPass1.Text;
                var password2 = TBPass2.Text;

                if (password1 != password2)
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TBPass1.Text = null;
                    TBPass1.BackColor = Color.Red;
                    TBPass2.Text = null;
                    TBPass2.BackColor = Color.Red;
                }
                else
                {
                    context.Add(new RegistrationData { Login = login, Password = password1 });
                    context.SaveChanges();

                    MessageBox.Show($"Успешно добавлен работник {login}", "Отлично!",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка регистрации {ex}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
