using PizzaDelivery.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class ClientForm : Form
    {
        private bool _exitByButton = false;
        private Form _parentForm;
        private Point _mouseLocation;
        private string _username = null;
        public ClientForm(Form parentForm, string username)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _username = username;
            titleRichTextBox.Text = $"Welcome, {_username}!";
            titleRichTextBox.Disable(formTitleLabel);
            announcementRichTextBox.Text = "----Version 0.7.2----\nApp under maintenance\nWait for full release";
            announcementRichTextBox.Disable(formTitleLabel);

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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Hide();

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing || !_exitByButton)
            {
                _parentForm.Close();
            }
        }

        private void bar_Mouse_Down(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void bar_Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(_mouseLocation.X, _mouseLocation.Y);
                Location = mousePose;
            }
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
    }
}
