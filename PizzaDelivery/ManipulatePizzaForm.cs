using PizzaDelivery.Commands;
using PizzaDelivery.Entities;
using PizzaDelivery.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class ManipulatePizzaForm : Form
    {
        private Pizza _pizza;
        private List<Recipe> _newRecipes;
        private string _mode;
        public ManipulatePizzaForm(Pizza pizza, string mode)
        {
            _pizza = pizza;
            _mode = mode;
            _newRecipes = new List<Recipe>();
            InitializeComponent();
            if (_mode.Equals("edit"))
            {
                nameTextBox.Text = pizza.Name;
                priceTextBox.Text = pizza.Price.ToString();
                descriptionRichTextBox.Text = pizza.Description;
                foreach (var recipe in _pizza.Recipes)
                {
                    _newRecipes.Add(recipe);
                }
            }
            recipesDataGridView.DataSource = pizza.Recipes;
            ingredientsDataGridView.DataSource = MainRepository.GetAllIngredients();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(quantityToAddTextBox.Text, out var quantity))
                {
                    throw new ArgumentException("Value to add is not valid.");
                }
                if (quantity < 0)
                {
                    throw new Exception("Value to add cannot be negative.");
                }
                if (ingredientsDataGridView.SelectedRows.Count > 0)
                {
                    var row = ingredientsDataGridView.SelectedRows[0];
                    Ingredient data = (Ingredient)ingredientsDataGridView.Rows[row.Index].DataBoundItem;
                    var foundItem = _newRecipes.FirstOrDefault(x => x.Id == data.Id);
                    if (foundItem != null)
                    {
                        foundItem.Quantity += quantity;
                    }
                    else
                    {
                        _newRecipes.Add(new Recipe { Id = data.Id, Name = data.Name, Quantity = quantity });
                    }
                    recipesDataGridView.DataSource = null;
                    recipesDataGridView.DataSource = _newRecipes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(quantityToSubtractTextBox.Text, out var quantity))
                {
                    throw new ArgumentException("Value to subtract is not valid.");
                }
                if (quantity < 0)
                {
                    throw new Exception("Value to subtract cannot be negative.");
                }
                //if (ingredientsDataGridView.SelectedRows.Count > 0)
                //{
                //    var row = ingredientsDataGridView.SelectedRows[0];
                //    Ingredient data = (Ingredient)ingredientsDataGridView.Rows[row.Index].DataBoundItem;
                //    var foundItem = _newRecipes.FirstOrDefault(x => x.Id == data.Id);
                //    if (foundItem != null)
                //    {
                //        if (foundItem.Quantity <= quantity)
                //        {
                //            _newRecipes.Remove(foundItem);
                //        }
                //        else
                //        {
                //            foundItem.Quantity -= quantity;
                //        }
                //    }
                //    else
                //    {
                //        throw new Exception("You can't subtract the quantity of an ingredient that is not in recipe.");
                //    }
                //    recipesDataGridView.DataSource = null;
                //    recipesDataGridView.DataSource = _newRecipes;
                //}
                if (recipesDataGridView.SelectedRows.Count > 0)
                {
                    var row = recipesDataGridView.SelectedRows[0];
                    Recipe data = (Recipe)row.DataBoundItem;
                    if (data.Quantity <= quantity)
                    {
                        _newRecipes.Remove(data);
                    }
                    else
                    {
                        data.Quantity -= quantity;
                    }
                    recipesDataGridView.DataSource = null;
                    recipesDataGridView.DataSource = _newRecipes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == string.Empty)
                {
                    throw new ArgumentException("Pizza's name cannot be null.");
                }
                if (!double.TryParse(priceTextBox.Text, out var price))
                {
                    throw new ArgumentException("Pizza's price is invalid.");
                }
                if (price < 0)
                {
                    throw new ArgumentException("Pizza's price cannot be negative.");
                }
                if (!_newRecipes.Any())
                {
                    throw new Exception("Pizza's recipe cannot be null.");
                }
                if (_mode.Equals("create"))
                {
                    _pizza.Name = nameTextBox.Text;
                    _pizza.Price = price;
                    _pizza.Description = descriptionRichTextBox.Text;
                    _pizza.Recipes = _newRecipes;
                    AdminForm.NewPizza = _pizza;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (_mode.Equals("edit"))
                {
                    string errMessage;
                    MainRepository.UpdatePizza(_pizza, nameTextBox.Text, price, descriptionRichTextBox.Text, _newRecipes, out errMessage);
                    if (errMessage != null)
                    {
                        MessageBox.Show(errMessage);
                    }
                    else
                    {
                        _pizza.Name = nameTextBox.Text;
                        _pizza.Price = price;
                        _pizza.Description = descriptionRichTextBox.Text;
                        _pizza.Recipes = _newRecipes;
                        AdminForm.NewPizza = new Pizza()
                        {
                            Id = _pizza.Id,
                            Description = _pizza.Description,
                            Recipes = _pizza.Recipes,
                            Name = _pizza.Name,
                            Price = _pizza.Price
                        };
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
