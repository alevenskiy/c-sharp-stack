namespace Authorization
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createLoginTextBox = new System.Windows.Forms.TextBox();
            this.createPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createLoginLabel = new System.Windows.Forms.Label();
            this.createPasswordLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.latinMustCharectersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginMustLabel = new System.Windows.Forms.Label();
            this.passwordMustLabel = new System.Windows.Forms.Label();
            this.passwordsMustEqualsLabel = new System.Windows.Forms.Label();
            this.showRepeatPasswordButton = new System.Windows.Forms.Button();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.showCreatePasswordButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createLoginTextBox
            // 
            this.createLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLoginTextBox.Location = new System.Drawing.Point(13, 43);
            this.createLoginTextBox.MaxLength = 255;
            this.createLoginTextBox.Name = "createLoginTextBox";
            this.createLoginTextBox.Size = new System.Drawing.Size(543, 35);
            this.createLoginTextBox.TabIndex = 0;
            this.createLoginTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // createPasswordTextBox
            // 
            this.createPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createPasswordTextBox.Location = new System.Drawing.Point(13, 114);
            this.createPasswordTextBox.MaxLength = 255;
            this.createPasswordTextBox.Name = "createPasswordTextBox";
            this.createPasswordTextBox.Size = new System.Drawing.Size(543, 35);
            this.createPasswordTextBox.TabIndex = 1;
            this.createPasswordTextBox.UseSystemPasswordChar = true;
            this.createPasswordTextBox.TextChanged += new System.EventHandler(this.createPasswordTextBox_TextChanged);
            // 
            // createLoginLabel
            // 
            this.createLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLoginLabel.AutoSize = true;
            this.createLoginLabel.Location = new System.Drawing.Point(13, 10);
            this.createLoginLabel.Name = "createLoginLabel";
            this.createLoginLabel.Size = new System.Drawing.Size(130, 30);
            this.createLoginLabel.TabIndex = 2;
            this.createLoginLabel.Text = "Create Login";
            this.createLoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createPasswordLabel
            // 
            this.createPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createPasswordLabel.AutoSize = true;
            this.createPasswordLabel.Location = new System.Drawing.Point(13, 81);
            this.createPasswordLabel.Name = "createPasswordLabel";
            this.createPasswordLabel.Size = new System.Drawing.Size(165, 30);
            this.createPasswordLabel.TabIndex = 3;
            this.createPasswordLabel.Text = "Create Password";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(161, 394);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(350, 50);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 707);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.latinMustCharectersLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Location = new System.Drawing.Point(104, 91);
            this.panel1.MaximumSize = new System.Drawing.Size(757, 523);
            this.panel1.MinimumSize = new System.Drawing.Size(458, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 523);
            this.panel1.TabIndex = 6;
            // 
            // latinMustCharectersLabel
            // 
            this.latinMustCharectersLabel.AutoSize = true;
            this.latinMustCharectersLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.latinMustCharectersLabel.Location = new System.Drawing.Point(161, 394);
            this.latinMustCharectersLabel.Name = "latinMustCharectersLabel";
            this.latinMustCharectersLabel.Size = new System.Drawing.Size(374, 90);
            this.latinMustCharectersLabel.TabIndex = 13;
            this.latinMustCharectersLabel.Text = "Login and Password must contain only:\r\n- Characters of Latin Alphabet\r\n- Numeric " +
    "Characters";
            this.latinMustCharectersLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.loginMustLabel);
            this.panel2.Controls.Add(this.passwordMustLabel);
            this.panel2.Controls.Add(this.passwordsMustEqualsLabel);
            this.panel2.Controls.Add(this.showRepeatPasswordButton);
            this.panel2.Controls.Add(this.repeatPasswordLabel);
            this.panel2.Controls.Add(this.repeatPasswordTextBox);
            this.panel2.Controls.Add(this.showCreatePasswordButton);
            this.panel2.Controls.Add(this.createLoginTextBox);
            this.panel2.Controls.Add(this.createLoginLabel);
            this.panel2.Controls.Add(this.createPasswordLabel);
            this.panel2.Controls.Add(this.createPasswordTextBox);
            this.panel2.Location = new System.Drawing.Point(64, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(569, 306);
            this.panel2.TabIndex = 12;
            // 
            // loginMustLabel
            // 
            this.loginMustLabel.AutoSize = true;
            this.loginMustLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginMustLabel.Location = new System.Drawing.Point(13, 81);
            this.loginMustLabel.Name = "loginMustLabel";
            this.loginMustLabel.Size = new System.Drawing.Size(339, 30);
            this.loginMustLabel.TabIndex = 13;
            this.loginMustLabel.Text = "Login must be 8 Charecters at least";
            // 
            // passwordMustLabel
            // 
            this.passwordMustLabel.AutoSize = true;
            this.passwordMustLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.passwordMustLabel.Location = new System.Drawing.Point(13, 152);
            this.passwordMustLabel.Name = "passwordMustLabel";
            this.passwordMustLabel.Size = new System.Drawing.Size(258, 120);
            this.passwordMustLabel.TabIndex = 12;
            this.passwordMustLabel.Text = "Password must be at least:\r\n- 8 Characters\r\n- 1 Upper case\r\n- 1 Number";
            this.passwordMustLabel.Visible = false;
            // 
            // passwordsMustEqualsLabel
            // 
            this.passwordsMustEqualsLabel.AutoSize = true;
            this.passwordsMustEqualsLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.passwordsMustEqualsLabel.Location = new System.Drawing.Point(13, 238);
            this.passwordsMustEqualsLabel.Name = "passwordsMustEqualsLabel";
            this.passwordsMustEqualsLabel.Size = new System.Drawing.Size(257, 30);
            this.passwordsMustEqualsLabel.TabIndex = 11;
            this.passwordsMustEqualsLabel.Text = "Passwords must be Similar";
            this.passwordsMustEqualsLabel.Visible = false;
            // 
            // showRepeatPasswordButton
            // 
            this.showRepeatPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showRepeatPasswordButton.Location = new System.Drawing.Point(513, 185);
            this.showRepeatPasswordButton.Name = "showRepeatPasswordButton";
            this.showRepeatPasswordButton.Size = new System.Drawing.Size(43, 35);
            this.showRepeatPasswordButton.TabIndex = 10;
            this.showRepeatPasswordButton.TabStop = false;
            this.showRepeatPasswordButton.Text = "button1";
            this.showRepeatPasswordButton.UseVisualStyleBackColor = true;
            this.showRepeatPasswordButton.Click += new System.EventHandler(this.showRepeatPasswordButton_Click);
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(13, 152);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(169, 30);
            this.repeatPasswordLabel.TabIndex = 9;
            this.repeatPasswordLabel.Text = "Repeat Password";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(13, 185);
            this.repeatPasswordTextBox.MaxLength = 255;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(543, 35);
            this.repeatPasswordTextBox.TabIndex = 2;
            this.repeatPasswordTextBox.UseSystemPasswordChar = true;
            this.repeatPasswordTextBox.TextChanged += new System.EventHandler(this.repeatPasswordTextBox_TextChanged);
            // 
            // showCreatePasswordButton
            // 
            this.showCreatePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCreatePasswordButton.Location = new System.Drawing.Point(513, 114);
            this.showCreatePasswordButton.Name = "showCreatePasswordButton";
            this.showCreatePasswordButton.Size = new System.Drawing.Size(43, 35);
            this.showCreatePasswordButton.TabIndex = 7;
            this.showCreatePasswordButton.TabStop = false;
            this.showCreatePasswordButton.Text = "button1";
            this.showCreatePasswordButton.UseVisualStyleBackColor = true;
            this.showCreatePasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox createLoginTextBox;
        private TextBox createPasswordTextBox;
        private Label createLoginLabel;
        private Label createPasswordLabel;
        private Button registerButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button showCreatePasswordButton;
        private Button showRepeatPasswordButton;
        private Label repeatPasswordLabel;
        private TextBox repeatPasswordTextBox;
        private Label passwordsMustEqualsLabel;
        private Panel panel2;
        private Label passwordMustLabel;
        private Label loginMustLabel;
        private Label latinMustCharectersLabel;
    }
}