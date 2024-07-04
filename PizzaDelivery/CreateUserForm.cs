using PizzaDelivery.Entities;
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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            if (AreAllValuesValid())
            {
                AdminForm.NewUser = initUser(usernameTextBox.Text, passwordTextBox.Text, descriptionRichTextBox.Text != string.Empty ? descriptionRichTextBox.Text : "[N/A]", "admin");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void deliveryManButton_Click(object sender, EventArgs e)
        {
            if (AreAllValuesValid())
            {
                AdminForm.NewUser = initUser(usernameTextBox.Text, passwordTextBox.Text, descriptionRichTextBox.Text != string.Empty ? descriptionRichTextBox.Text : "[N/A]", "delivery");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            if (AreAllValuesValid())
            {
                AdminForm.NewUser = initUser(usernameTextBox.Text, passwordTextBox.Text, descriptionRichTextBox.Text != string.Empty ? descriptionRichTextBox.Text : "[N/A]", "client");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool AreAllValuesValid()
        {
            if (usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private User initUser(string username, string password, string description, string role)
        {
            User user = new User();
            user.Username = username;
            user.Password = password;
            user.Description = description;
            user.Role = role;
            return user;
        }
    }
}
