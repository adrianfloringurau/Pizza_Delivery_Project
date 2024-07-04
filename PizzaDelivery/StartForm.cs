using PizzaDelivery.Entities;
using PizzaDelivery.Extensions;
using PizzaDelivery.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class StartForm : Form
    {
        public static SoundPlayer SoundPlayer;
        public static bool MusicOn = true;
        public static bool MusicFound = true;

        private Point _mouseLocation;
        private bool _loginMode = true;
        private List<string> _usernames = null;
        private int _passwordMinimumLength = 8;
        private int _passwordMaximumLength = 25;

        public string FormTitle
        {
            get
            {
                if (_loginMode) { return "Login"; }
                else { return "Sign Up"; }
            }
        }

        //For Login:
        public bool UsernameIsEmpty
        {
            get
            {
                if (usernameTextBox.Text.Equals(string.Empty))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool PasswordIsEmpty
        {
            get
            {
                if (passwordTextBox.Text.Equals(string.Empty))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //For SignUp:
        public bool UsernameAlreadyExists
        {
            get
            {
                if (_usernames.Contains(usernameTextBox.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool PasswordHasNotEnoughCharacters
        {
            get
            {
                if (passwordTextBox.Text.Length < _passwordMinimumLength)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool PasswordHasTooManyCharacters
        {
            get
            {
                if (passwordTextBox.Text.Length >= _passwordMaximumLength + 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public StartForm()
        {
            InitializeComponent();

            StartUpRepository.GenerateFolders();
            UsersRepository.CreateUsersDatabase();
            MainRepository.CreateMainDatabase();

            _usernames = UsersRepository.GetAllUsernames();

            formTitleLabel.Text = FormTitle;
            rulesRichTextBox.Disable(titleLabel);
            try
            {
                SoundPlayer = new SoundPlayer(Constants.SFXConstants.StartMusic);
                SoundPlayer.PlayLooping();
            }
            catch (Exception)
            {
                MusicFound = false;
                musicButton.BackColor = Constants.ColorConstants.Gray;
                musicButton.Text = "🔈";
                musicButton.Enabled = false;
            }
            SetRules();
        }

        public void CleanForm()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            rulesRichTextBox.Text = string.Empty;
        }

        public bool RestrictPassword()
        {
            bool isPasswordTooBig = PasswordHasTooManyCharacters;
            if (isPasswordTooBig)
            {
                passwordTextBox.Text = passwordTextBox.Text.Substring(0, _passwordMaximumLength);
            }
            return isPasswordTooBig;
        }

        public void SetRules()
        {
            string _rules = string.Empty;
            if (UsernameIsEmpty)
            {
                _rules += "Username cannot be empty.\n";
            }
            if (_loginMode)
            {
                RestrictPassword();
                if (PasswordIsEmpty)
                {
                    _rules += "Password cannot be empty.\n";
                }
            }
            else
            {
                if (UsernameAlreadyExists)
                {
                    _rules += "Username is already taken.\n";
                }
                if (PasswordHasNotEnoughCharacters)
                {
                    _rules += $"Password must have more than {_passwordMinimumLength} characters.\n";
                }
                if (RestrictPassword())
                {
                    _rules += $"Password can't have more than {_passwordMaximumLength} characters.\n";
                }
            }
            rulesRichTextBox.Text = _rules;
            if (_rules == string.Empty)
            {
                submitButton.BackColor = Constants.ColorConstants.DarkRed;
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.BackColor = Constants.ColorConstants.Gray;
                submitButton.Enabled = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bar_mouse_Down(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void bar_mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(_mouseLocation.X, _mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void showPass_mouse_Down(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
            showPasswordButton.Text = "🔑";
        }

        private void showPass_mouse_Up(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '✱';
            showPasswordButton.Text = "🔒";
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            CleanForm();
            _loginMode = false;
            formTitleLabel.Text = FormTitle;
            loginButton.Enabled = true;
            signUpButton.Enabled = false;
            loginButton.BackColor = Constants.ColorConstants.DarkGreen;
            signUpButton.BackColor = Constants.ColorConstants.Gray;
            SetRules();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            CleanForm();
            _loginMode = true;
            formTitleLabel.Text = FormTitle;
            signUpButton.Enabled = true;
            loginButton.Enabled = false;
            signUpButton.BackColor = Constants.ColorConstants.DarkTurquoise;
            loginButton.BackColor = Constants.ColorConstants.Gray;
            SetRules();
        }

        private void credentials_Changed(object sender, EventArgs e)
        {
            SetRules();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (_loginMode)
            {
                string _currentUsername = usernameTextBox.Text;
                string role, errMessage;

                if (UsersRepository.TryLogin(_currentUsername, passwordTextBox.Text, out role, out errMessage))
                {
                    Form form = null;
                    switch (role)
                    {
                        case "admin":
                            form = new AdminForm(this, _currentUsername);
                            break;
                        case "delivery":
                            form = new DeliveryForm(this, _currentUsername);
                            break;
                        case "client":
                            form = new ClientForm(this, _currentUsername);
                            break;
                    }
                    Hide();
                    form.ShowDialog();
                    if (MusicFound == false)
                    {
                        musicButton.BackColor = Constants.ColorConstants.Gray;
                        musicButton.Text = "🔈";
                        musicButton.Enabled = false;
                    }
                    else
                    {
                        if (MusicOn)
                        {
                            musicButton.Text = "🔊";
                            musicButton.BackColor = Constants.ColorConstants.DarkPurple;
                        }
                        else
                        {
                            musicButton.Text = "🔈";
                            musicButton.BackColor = Constants.ColorConstants.DarkYellow;
                        }
                    }
                }
                else
                {
                    rulesRichTextBox.Text = errMessage;
                }
            }
            else
            {
                var requestForm = new RequestForm(this, usernameTextBox.Text, passwordTextBox.Text);
                Hide();
                requestForm.ShowDialog(this);
                if (MusicFound == false)
                {
                    musicButton.BackColor = Constants.ColorConstants.Gray;
                    musicButton.Text = "🔈";
                    musicButton.Enabled = false;
                }
                else
                {
                    if (MusicOn)
                    {
                        musicButton.Text = "🔊";
                        musicButton.BackColor = Constants.ColorConstants.DarkPurple;
                    }
                    else
                    {
                        musicButton.Text = "🔈";
                        musicButton.BackColor = Constants.ColorConstants.DarkYellow;
                    }
                }
            }
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            if (MusicFound)
            {
                if (MusicOn)
                {
                    MusicOn = false;
                    musicButton.Text = "🔈";
                    musicButton.BackColor = Constants.ColorConstants.DarkYellow;
                    SoundPlayer.Stop();
                }
                else
                {
                    MusicOn = true;
                    musicButton.Text = "🔊";
                    musicButton.BackColor = Constants.ColorConstants.DarkPurple;
                    SoundPlayer.PlayLooping();
                }
            }
        }
    }
}
