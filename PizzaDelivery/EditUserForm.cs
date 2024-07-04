using PizzaDelivery.Entities;
using PizzaDelivery.Repositories;
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
    public partial class EditUserForm : Form
    {
        private User _user;
        public EditUserForm(User user)
        {
            _user = user;
            InitializeComponent();
            newPasswordTextBox.Text = _user.Password;
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text != string.Empty) {
                string errMessage;
                var newUser = UsersRepository.UpdatePassword(_user, newPasswordTextBox.Text, out errMessage);
                if (errMessage != null)
                {
                    MessageBox.Show(errMessage);
                }
                else
                {
                    AdminForm.NewUser = newUser;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
