using PizzaDelivery.Entities;
using PizzaDelivery.Extensions;
using PizzaDelivery.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery.Commands
{
    public static class DataGridViewCommands
    {
        public static void SetDataAsUsers(DataGridView usersDataGridView)
        {
            usersDataGridView.Columns.Clear();
            usersDataGridView
                .UpdateDataSource(UsersRepository.GetAllUsers())
                .AddTextBoxColumn(nameof(User.Id), "ID")
                .AddTextBoxColumn(nameof(User.Username), "Username")
                .AddTextBoxColumn(nameof(User.Password), "Password")
                .AddTextBoxColumn(nameof(User.Role), "Role")
                .AddTextBoxColumn(nameof(User.Description), "Description")
                .AddTextBoxColumn(nameof(User.IsVerified), "Verified?")
                .AddButtonColumn("VerifyUnverify", "Verify / Unverify")
                .AddButtonColumn("EditColumn", "Edit")
                .AddButtonColumn("DeleteColumn", "Delete");
        }

        public static void SetDataAsIngredients(DataGridView ingredientsDataGridView)
        {
            ingredientsDataGridView.Columns.Clear();
            ingredientsDataGridView
                .UpdateDataSource(MainRepository.GetAllIngredients())
                .AddTextBoxColumn(nameof(Ingredient.Id), "ID")
                .AddTextBoxColumn(nameof(Ingredient.Name), "Name")
                .AddTextBoxColumn(nameof(Ingredient.Quantity), "Quantity")
                .AddButtonColumn("EditColumn", "Edit")
                .AddButtonColumn("DeleteColumn", "Delete");
        }

        public static void SetDataAsPizzas(DataGridView pizzasDataGridView)
        {
            pizzasDataGridView.Columns.Clear();
            pizzasDataGridView
                .UpdateDataSource(MainRepository.GetAllPizzas())
                .AddTextBoxColumn(nameof(Pizza.Id), "ID")
                .AddTextBoxColumn(nameof(Pizza.Price), "Price")
                .AddTextBoxColumn(nameof(Pizza.Name), "Name")
                .AddTextBoxColumn(nameof(Pizza.Description), "Description")
                .AddTextBoxColumn(nameof(Pizza.RecipesString), "Recipe")
                .AddButtonColumn("EditColumn", "Edit")
                .AddButtonColumn("DeleteColumn", "Delete");
        }

        public static void UpdateUserRowValues(DataGridViewRow row, User updatedUser)
        {
            row.Cells[nameof(User.Id)].Value = updatedUser.Id;
            row.Cells[nameof(User.Username)].Value = updatedUser.Username;
            row.Cells[nameof(User.Password)].Value = updatedUser.Password;
            row.Cells[nameof(User.Role)].Value = updatedUser.Role;
            row.Cells[nameof(User.Description)].Value = updatedUser.Description;
            row.Cells[nameof(User.IsVerified)].Value = updatedUser.IsVerified;
        }

        public static void UpdateIngredientRowValues(DataGridViewRow row, Ingredient updatedIngredient)
        {
            row.Cells[nameof(Ingredient.Id)].Value = updatedIngredient.Id;
            row.Cells[nameof(Ingredient.Name)].Value = updatedIngredient.Name;
            row.Cells[nameof(Ingredient.Quantity)].Value = updatedIngredient.Quantity;
        }

        public static void UpdatePizzaRowValues(DataGridViewRow row, Pizza updatedPizza)
        {
            row.Cells[nameof(Pizza.Id)].Value = updatedPizza.Id;
            row.Cells[nameof(Pizza.Name)].Value = updatedPizza.Name;
            row.Cells[nameof(Pizza.Price)].Value = updatedPizza.Price;
            row.Cells[nameof(Pizza.Description)].Value = updatedPizza.Description;
            row.Cells[nameof(Pizza.RecipesString)].Value = updatedPizza.RecipesString;
        }
    }
}
