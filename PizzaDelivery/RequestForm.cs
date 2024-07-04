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
    public partial class RequestForm : Form
    {
        private bool _exitByButton = false;
        private Point _mouseLocation;
        private Form _parentForm;
        private string _username;
        private string _password;
        public RequestForm(Form parentForm, string username, string password)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _username = username;
            _password = password;
            
            if (StartForm.MusicFound == false)
            {
                musicButton.BackColor = Constants.ColorConstants.Gray;
                musicButton.Text = "🔈";
                musicButton.Enabled = false;
            }
            else
            {
                if (StartForm.MusicOn)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            _exitByButton = true;
            Close();
            _parentForm.Close();
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

        private void radioButtonGroup_Check(object sender, EventArgs e)
        {
            submitButton.BackColor = Constants.ColorConstants.DarkRed;
            submitButton.Enabled = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string role = null;
            if (clientRadioButton.Checked) role = "client";
            if (deliveryManRadioButton.Checked) role = "delivery";
            if (administratorRadioButton.Checked) role = "admin";
            UsersRepository.TrySignUp(_username, _password, role, moreInfoRichTextBox.Text);
            Close();
            _parentForm.Close();
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            if (StartForm.MusicFound)
            {
                if (StartForm.MusicOn)
                {
                    StartForm.MusicOn = false;
                    musicButton.Text = "🔈";
                    musicButton.BackColor = Constants.ColorConstants.DarkYellow;
                    StartForm.SoundPlayer.Stop();
                }
                else
                {
                    StartForm.MusicOn = true;
                    musicButton.Text = "🔊";
                    musicButton.BackColor = Constants.ColorConstants.DarkPurple;
                    StartForm.SoundPlayer.PlayLooping();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _exitByButton = true;
            Close();
            _parentForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Hide();

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing || !_exitByButton)
            {
                _parentForm.Close();
            }
        }
    }
}
