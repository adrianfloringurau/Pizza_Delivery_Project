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
    public partial class CreateIngredientForm : Form
    {
        public CreateIngredientForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool AreAllValuesValid()
        {
            if (nameTextBox.Text != string.Empty && quantityTextBox.Text != string.Empty &&
                double.TryParse(quantityTextBox.Text, out var quantity) && quantity >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Ingredient initIngredient(string name, string quantity)
        {
            Ingredient ingredient = new Ingredient();
            ingredient.Name = name;
            ingredient.Quantity = double.Parse(quantity);
            return ingredient;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (AreAllValuesValid())
            {
                AdminForm.NewIngredient = initIngredient(nameTextBox.Text, quantityTextBox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
