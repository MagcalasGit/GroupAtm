using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginLastoutput
{
    public partial class FormLogIn : Form
    {
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 3;
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void ShowHid_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHid.Checked && txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "0000")
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }
    }
}
