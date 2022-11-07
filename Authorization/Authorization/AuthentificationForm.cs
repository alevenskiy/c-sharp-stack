namespace Authorization
{
    public partial class AuthentificationForm : Form
    {
        public AuthentificationForm()
        {
            InitializeComponent();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (new FileInfo("not_a_login.txt").Exists)
            {

                using (StreamReader sr = new StreamReader("not_a_login.txt"))
                {
                    if (sr != null)
                    {
                        loginTextBox.Text = sr.ReadLine();
                        passwordTextBox.Text = sr.ReadLine();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            new RegistrationForm(this).Show();
        }

        public void setLoginFromRegistration(string login)
        {
            loginTextBox.Text = login;
        }

        public void setPasswordFromRegistration(string password)
        {
            passwordTextBox.Text = password;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if (rememberCheckBox.Checked)
            {
                using (StreamWriter sw = new StreamWriter("not_a_login.txt", false))
                {
                    sw.WriteLine(login);
                    sw.WriteLine(password);
                }
            }

            string hashPassword = getPasswordHash(password);

            SQLCaller sql = new SQLCaller();
            sql.openConnection();

            if(sql.checkUser(login, hashPassword))
            {
                MessageBox.Show("You have successfully logged in");
                sql.closeConnection();
                this.Close();
            }
            else if (sql.checkUser(login))
                MessageBox.Show("Wrong password");
            else
                MessageBox.Show("This login is not used");
            
            sql.closeConnection();
        }

        private string getPasswordHash(string password)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToHexString(hashBytes);
            }
        }
    }
}