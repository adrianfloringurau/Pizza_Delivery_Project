using PizzaDelivery.Commands;
using PizzaDelivery.Entities;
using PizzaDelivery.Extensions;
using PizzaDelivery.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class AdminForm : Form
    {
        public static User NewUser { get; set; }
        public static Ingredient NewIngredient { get; set; }
        public static Pizza NewPizza { get; set; }
        private enum _modes
        {
            Users = 0,
            Ingredients = 1,
            Pizzas = 2
        }
        private _modes _mode = _modes.Users;

        private bool _exitByButton = false;
        private Point _mouseLocation;
        private Form _parentForm;
        private string _username = null;
        public AdminForm(Form parentForm, string username)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _username = username;
            formTitleRichTextBox.Disable(multiDataGridView);
            formTitleRichTextBox.Text = $"admin_panel→users→{_username}";
            usersToolStripDropDownButton.Image = SystemIcons.Shield.ToBitmap();
            ingredientsToolStripDropDownButton.Image = SystemIcons.Shield.ToBitmap();
            pizzasToolStripDropDownButton.Image = SystemIcons.Shield.ToBitmap();

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

            multiDataGridView.AutoGenerateColumns = false;
            DataGridViewCommands.SetDataAsUsers(multiDataGridView);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            _exitByButton = true;
            Close();
            _parentForm.Close();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Hide();

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing || !_exitByButton)
            {
                _parentForm.Close();
            }
        }

        private void viewIngredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_mode != _modes.Ingredients)
            {
                _mode = _modes.Ingredients;
                DataGridViewCommands.SetDataAsIngredients(multiDataGridView);
            }
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_mode != _modes.Users)
            {
                _mode = _modes.Users;
                DataGridViewCommands.SetDataAsUsers(multiDataGridView);
            }
        }

        private void viewPizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_mode != _modes.Pizzas)
            {
                _mode = _modes.Pizzas;
                DataGridViewCommands.SetDataAsPizzas(multiDataGridView);
            }
        }

        private void multiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("You cannot select the headers row.");
                return;
            }
            var row = multiDataGridView.Rows[e.RowIndex];
            if (row != null)
            {
                var columnName = multiDataGridView.Columns[e.ColumnIndex].Name.ToString();
                switch (_mode)
                {
                    case _modes.Users:
                        var user = (User)row.DataBoundItem;
                        string errMessage;
                        switch (columnName)
                        {
                            case "VerifyUnverify":
                                
                                var newUser = UsersRepository.VerifyUnverify(user, _username, out errMessage);
                                if (errMessage != null)
                                {
                                    MessageBox.Show(errMessage);
                                }
                                else
                                {
                                    DataGridViewCommands.UpdateUserRowValues(row, newUser);
                                }
                                break;
                            case "EditColumn":
                                Form editUserForm = new EditUserForm(user);
                                if (editUserForm.ShowDialog() == DialogResult.OK)
                                {
                                    DataGridViewCommands.UpdateUserRowValues(row, NewUser);
                                }
                                break;
                            case "DeleteColumn":
                                var action = MessageBox.Show($"Do you want to delete {user.Username} ({user.Id})?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (action == DialogResult.Yes)
                                {
                                    UsersRepository.DeleteUser(user, _username, out errMessage);
                                    if (errMessage != null)
                                    {
                                        MessageBox.Show(errMessage);
                                    }
                                    else
                                    {
                                        DataGridViewCommands.SetDataAsUsers(multiDataGridView);
                                    }
                                }
                                break;
                        }
                        break;
                    case _modes.Ingredients:
                        var ingredient = (Ingredient)row.DataBoundItem;
                        switch(columnName)
                        {
                            case "EditColumn":
                                Form editIngredientForm = new EditIngredientForm(ingredient);
                                if (editIngredientForm.ShowDialog() == DialogResult.OK)
                                {
                                    DataGridViewCommands.UpdateIngredientRowValues(row, NewIngredient);
                                }
                                break;
                            case "DeleteColumn":
                                var action = MessageBox.Show($"Do you want to delete {ingredient.Name} ({ingredient.Id})?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (action == DialogResult.Yes)
                                {
                                    MainRepository.DeleteIngredient(ingredient, out errMessage);
                                    if (errMessage != null)
                                    {
                                        MessageBox.Show(errMessage);
                                    }
                                    else
                                    {
                                        DataGridViewCommands.SetDataAsIngredients(multiDataGridView);
                                    }
                                }
                                break;
                        }
                        break;
                    case _modes.Pizzas:
                        var pizza = (Pizza)row.DataBoundItem;
                        switch(columnName)
                        {
                            case "EditColumn":
                                Form manipulatePizzaForm = new ManipulatePizzaForm(pizza, "edit");
                                if (manipulatePizzaForm.ShowDialog() == DialogResult.OK)
                                {
                                    DataGridViewCommands.UpdatePizzaRowValues(row, NewPizza);
                                    multiDataGridView.Refresh();
                                }
                                break;
                            case "DeleteColumn":
                                var action = MessageBox.Show($"Do you want to delete {pizza.Name} ({pizza.Id})?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (action == DialogResult.Yes)
                                {
                                    MainRepository.DeletePizza(pizza, out errMessage);
                                    if (errMessage != null)
                                    {
                                        MessageBox.Show(errMessage);
                                    }
                                    else
                                    {
                                        DataGridViewCommands.SetDataAsPizzas(multiDataGridView);
                                    }
                                }
                                break;
                        }
                        break;
                }
            }
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form createUserForm = new CreateUserForm();
            if (createUserForm.ShowDialog() == DialogResult.OK)
            {
                UsersRepository.TrySignUp(NewUser.Username, NewUser.Password, NewUser.Role, NewUser.Description);
                if (_mode == _modes.Users)
                {
                    DataGridViewCommands.SetDataAsUsers(multiDataGridView);
                }
            }
        }

        private void createIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form createIngredientForm = new CreateIngredientForm();
            if (createIngredientForm.ShowDialog() == DialogResult.OK)
            {
                MainRepository.CreateIngredient(NewIngredient.Name, NewIngredient.Quantity);
                if (_mode == _modes.Ingredients)
                {
                    DataGridViewCommands.SetDataAsIngredients(multiDataGridView);
                }
            }
        }

        private void createPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza newPizza = new Pizza();
            Form manipulatePizzaForm = new ManipulatePizzaForm(newPizza, "create");
            if (manipulatePizzaForm.ShowDialog() == DialogResult.OK)
            {
                MainRepository.CreatePizza(NewPizza.Name, NewPizza.Price, NewPizza.Description, NewPizza.Recipes);
                if (_mode == _modes.Pizzas)
                {
                    DataGridViewCommands.SetDataAsPizzas(multiDataGridView);
                }
            }
        }
    }
}
