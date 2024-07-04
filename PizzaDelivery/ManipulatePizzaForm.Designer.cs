namespace PizzaDelivery
{
    partial class ManipulatePizzaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.recipesDataGridView = new System.Windows.Forms.DataGridView();
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.recipesLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.quantityToSubtractTextBox = new System.Windows.Forms.TextBox();
            this.quantityToAddTextBox = new System.Windows.Forms.TextBox();
            this.subtractButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.commitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(317, 25);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(272, 69);
            this.descriptionRichTextBox.TabIndex = 13;
            this.descriptionRichTextBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(314, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(15, 74);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(272, 20);
            this.priceTextBox.TabIndex = 11;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(12, 58);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(15, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(272, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // recipesDataGridView
            // 
            this.recipesDataGridView.AllowUserToAddRows = false;
            this.recipesDataGridView.AllowUserToDeleteRows = false;
            this.recipesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesDataGridView.Location = new System.Drawing.Point(15, 128);
            this.recipesDataGridView.MultiSelect = false;
            this.recipesDataGridView.Name = "recipesDataGridView";
            this.recipesDataGridView.ReadOnly = true;
            this.recipesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipesDataGridView.Size = new System.Drawing.Size(574, 81);
            this.recipesDataGridView.TabIndex = 14;
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AllowUserToAddRows = false;
            this.ingredientsDataGridView.AllowUserToDeleteRows = false;
            this.ingredientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(15, 264);
            this.ingredientsDataGridView.MultiSelect = false;
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.ReadOnly = true;
            this.ingredientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingredientsDataGridView.Size = new System.Drawing.Size(574, 81);
            this.ingredientsDataGridView.TabIndex = 15;
            // 
            // recipesLabel
            // 
            this.recipesLabel.AutoSize = true;
            this.recipesLabel.ForeColor = System.Drawing.Color.White;
            this.recipesLabel.Location = new System.Drawing.Point(12, 112);
            this.recipesLabel.Name = "recipesLabel";
            this.recipesLabel.Size = new System.Drawing.Size(41, 13);
            this.recipesLabel.TabIndex = 16;
            this.recipesLabel.Text = "Recipe";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.ForeColor = System.Drawing.Color.White;
            this.ingredientsLabel.Location = new System.Drawing.Point(12, 248);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(104, 13);
            this.ingredientsLabel.TabIndex = 17;
            this.ingredientsLabel.Text = "Available ingredients";
            // 
            // quantityToSubtractTextBox
            // 
            this.quantityToSubtractTextBox.Location = new System.Drawing.Point(132, 225);
            this.quantityToSubtractTextBox.Name = "quantityToSubtractTextBox";
            this.quantityToSubtractTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityToSubtractTextBox.TabIndex = 18;
            // 
            // quantityToAddTextBox
            // 
            this.quantityToAddTextBox.Location = new System.Drawing.Point(366, 225);
            this.quantityToAddTextBox.Name = "quantityToAddTextBox";
            this.quantityToAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityToAddTextBox.TabIndex = 19;
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.Red;
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.Location = new System.Drawing.Point(239, 215);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(48, 43);
            this.subtractButton.TabIndex = 20;
            this.subtractButton.Text = "🡳";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lime;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(312, 215);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 43);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "🡱";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // commitButton
            // 
            this.commitButton.BackColor = System.Drawing.Color.Lime;
            this.commitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commitButton.Location = new System.Drawing.Point(317, 351);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(272, 23);
            this.commitButton.TabIndex = 23;
            this.commitButton.Text = "Commit";
            this.commitButton.UseVisualStyleBackColor = false;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(15, 351);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(272, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ManipulatePizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(606, 385);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.quantityToAddTextBox);
            this.Controls.Add(this.quantityToSubtractTextBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.recipesLabel);
            this.Controls.Add(this.ingredientsDataGridView);
            this.Controls.Add(this.recipesDataGridView);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManipulatePizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManipulatePizza";
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView recipesDataGridView;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.Label recipesLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.TextBox quantityToSubtractTextBox;
        private System.Windows.Forms.TextBox quantityToAddTextBox;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}