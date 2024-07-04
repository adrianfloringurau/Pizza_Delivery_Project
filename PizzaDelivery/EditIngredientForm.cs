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
    public partial class EditIngredientForm : Form
    {
        private Ingredient _ingredient;
        public EditIngredientForm(Ingredient ingredient)
        {
            _ingredient = ingredient;
            InitializeComponent();
            newNameTextBox.Text = ingredient.Name;
            newQuantityTextBox.Text = ingredient.Quantity.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            if (newNameTextBox.Text != string.Empty && newQuantityTextBox.Text != string.Empty)
            {
                string errMessage;
                var newIngredient = MainRepository.UpdateIngredient(_ingredient, newNameTextBox.Text, newQuantityTextBox.Text, out errMessage);
                if (errMessage != null)
                {
                    MessageBox.Show(errMessage);
                }
                else
                {
                    AdminForm.NewIngredient = newIngredient;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
