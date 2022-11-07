namespace Authorization
{
    public partial class RegistrationForm : Form
    {
        AuthentificationForm authForm;
        public RegistrationForm(AuthentificationForm authForm)
        {
            InitializeComponent();
            this.authForm = authForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(createLoginTextBox.Text.Length < 8)
                loginMustLabel.Visible = true;
            else
                loginMustLabel.Visible = false;

            if(isCharectersOk(createLoginTextBox.Text))
                latinMustCharectersLabel.Visible = false;
            else
                latinMustCharectersLabel.Visible = true;
        }

        private bool isCharectersOk(string str)
        {
            foreach(char c in str)
            {
                int intChar = (int)c;
                if(!((intChar >= 48 && intChar <= 57) ||  //Numeric 0..9
                    (intChar >= 65 && intChar <= 90) || //UpperCase A..Z
                    (intChar >= 97 && intChar <= 122))) //LowCase a..z
                    return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            createPasswordTextBox.UseSystemPasswordChar = !createPasswordTextBox.UseSystemPasswordChar;
        }

        private void showRepeatPasswordButton_Click(object sender, EventArgs e)
        {
            repeatPasswordTextBox.UseSystemPasswordChar = !repeatPasswordTextBox.UseSystemPasswordChar;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(!(loginMustLabel.Visible) && 
                !(passwordMustLabel.Visible) &&
                !(passwordsMustEqualsLabel.Visible))
            {
                string login = createLoginTextBox.Text;
                string password = createPasswordTextBox.Text;

                authForm.setLoginFromRegistration(login);
                authForm.setPasswordFromRegistration(password);

                saveLoginPassword(login, password);

            }
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

        private void saveLoginPassword(string login, string password)
        {
            SQLCaller sql = new SQLCaller();
            sql.openConnection();

            string hashPassword = getPasswordHash(password);

            if (sql.addUser(login, hashPassword))
            {
                MessageBox.Show("Your login has been successfully registered");
                sql.closeConnection();
                this.Close();
            }
            else
            {
                MessageBox.Show("This login is already in use\nPlease enter new one");
                sql.closeConnection();
            }
        }

        private void repeatPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (repeatPasswordTextBox.Text != createPasswordTextBox.Text)
                passwordsMustEqualsLabel.Visible = true;
            else
                passwordsMustEqualsLabel.Visible = false;

        }

        private bool isPasswordCharectersOk(string str)
        {
            bool flagNum = false;
            bool flagUp = false;
            foreach (char c in str)
            {
                int intChar = (int)c;
                if (intChar >= 48 && intChar <= 57)//Numeric 0..9
                {
                    flagNum = true;
                }
                if (intChar >= 65 && intChar <= 90)//UpperCase A..Z
                {
                    flagUp = true;
                }
            }
            return (flagUp && flagNum);
        }
        private void createPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (createPasswordTextBox.Text.Length >= 8 &&
                isPasswordCharectersOk(createPasswordTextBox.Text)) 
                passwordMustLabel.Visible = false;
            else
                passwordMustLabel.Visible = true;

            if (isCharectersOk(createPasswordTextBox.Text))
                latinMustCharectersLabel.Visible = false;
            else
                latinMustCharectersLabel.Visible = true;
        }
    }
}