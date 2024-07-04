namespace PizzaDelivery
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.multiDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formTitleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.formToolStrip = new System.Windows.Forms.ToolStrip();
            this.usersToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.usersToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ingredientsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ingredientsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewIngredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createIngredientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pizzasToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pizzasToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewPizzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.multiDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.formToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiDataGridView
            // 
            this.multiDataGridView.AllowUserToAddRows = false;
            this.multiDataGridView.AllowUserToDeleteRows = false;
            this.multiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.multiDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.multiDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.multiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.multiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.multiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.multiDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.multiDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.multiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.multiDataGridView.Location = new System.Drawing.Point(0, 79);
            this.multiDataGridView.MultiSelect = false;
            this.multiDataGridView.Name = "multiDataGridView";
            this.multiDataGridView.ReadOnly = true;
            this.multiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.multiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.multiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.multiDataGridView.Size = new System.Drawing.Size(800, 371);
            this.multiDataGridView.TabIndex = 7;
            this.multiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.multiDataGridView_CellContentClick);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(744, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(44, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "✖";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.formTitleRichTextBox);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.musicButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_Mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_Mouse_Move);
            // 
            // formTitleRichTextBox
            // 
            this.formTitleRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formTitleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formTitleRichTextBox.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleRichTextBox.ForeColor = System.Drawing.Color.White;
            this.formTitleRichTextBox.Location = new System.Drawing.Point(12, 9);
            this.formTitleRichTextBox.Multiline = false;
            this.formTitleRichTextBox.Name = "formTitleRichTextBox";
            this.formTitleRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.formTitleRichTextBox.Size = new System.Drawing.Size(484, 35);
            this.formTitleRichTextBox.TabIndex = 15;
            this.formTitleRichTextBox.Text = "";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(650, 9);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 35);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "◄";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.musicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicButton.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicButton.Location = new System.Drawing.Point(697, 9);
            this.musicButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(44, 35);
            this.musicButton.TabIndex = 13;
            this.musicButton.Text = "🔊";
            this.musicButton.UseVisualStyleBackColor = false;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // formToolStrip
            // 
            this.formToolStrip.BackColor = System.Drawing.Color.Maroon;
            this.formToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formToolStrip.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.formToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripLabel,
            this.usersToolStripDropDownButton,
            this.toolStripSeparator1,
            this.ingredientsToolStripLabel,
            this.ingredientsToolStripDropDownButton,
            this.toolStripSeparator2,
            this.pizzasToolStripLabel,
            this.pizzasToolStripDropDownButton,
            this.toolStripSeparator3});
            this.formToolStrip.Location = new System.Drawing.Point(0, 53);
            this.formToolStrip.Name = "formToolStrip";
            this.formToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.formToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.formToolStrip.Size = new System.Drawing.Size(800, 26);
            this.formToolStrip.TabIndex = 9;
            this.formToolStrip.Text = "formToolStrip";
            // 
            // usersToolStripLabel
            // 
            this.usersToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.usersToolStripLabel.Margin = new System.Windows.Forms.Padding(9, 1, 0, 2);
            this.usersToolStripLabel.Name = "usersToolStripLabel";
            this.usersToolStripLabel.Size = new System.Drawing.Size(49, 23);
            this.usersToolStripLabel.Text = "USERS";
            // 
            // usersToolStripDropDownButton
            // 
            this.usersToolStripDropDownButton.AutoToolTip = false;
            this.usersToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersToolStripMenuItem,
            this.createUserToolStripMenuItem});
            this.usersToolStripDropDownButton.ForeColor = System.Drawing.Color.Black;
            this.usersToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripDropDownButton.Image")));
            this.usersToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usersToolStripDropDownButton.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.usersToolStripDropDownButton.Name = "usersToolStripDropDownButton";
            this.usersToolStripDropDownButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.usersToolStripDropDownButton.Size = new System.Drawing.Size(34, 23);
            this.usersToolStripDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.viewUsersToolStripMenuItem.Text = "View users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.createUserToolStripMenuItem.Text = "Create user";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // ingredientsToolStripLabel
            // 
            this.ingredientsToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.ingredientsToolStripLabel.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.ingredientsToolStripLabel.Name = "ingredientsToolStripLabel";
            this.ingredientsToolStripLabel.Size = new System.Drawing.Size(98, 23);
            this.ingredientsToolStripLabel.Text = "INGREDIENTS";
            // 
            // ingredientsToolStripDropDownButton
            // 
            this.ingredientsToolStripDropDownButton.AutoToolTip = false;
            this.ingredientsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingredientsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewIngredientsToolStripMenuItem,
            this.createIngredientToolStripMenuItem});
            this.ingredientsToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ingredientsToolStripDropDownButton.Image")));
            this.ingredientsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ingredientsToolStripDropDownButton.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.ingredientsToolStripDropDownButton.Name = "ingredientsToolStripDropDownButton";
            this.ingredientsToolStripDropDownButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ingredientsToolStripDropDownButton.Size = new System.Drawing.Size(39, 23);
            this.ingredientsToolStripDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // viewIngredientsToolStripMenuItem
            // 
            this.viewIngredientsToolStripMenuItem.Name = "viewIngredientsToolStripMenuItem";
            this.viewIngredientsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewIngredientsToolStripMenuItem.Text = "View ingredients";
            this.viewIngredientsToolStripMenuItem.Click += new System.EventHandler(this.viewIngredientsToolStripMenuItem_Click);
            // 
            // createIngredientToolStripMenuItem
            // 
            this.createIngredientToolStripMenuItem.Name = "createIngredientToolStripMenuItem";
            this.createIngredientToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.createIngredientToolStripMenuItem.Text = "Create ingredient";
            this.createIngredientToolStripMenuItem.Click += new System.EventHandler(this.createIngredientToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // pizzasToolStripLabel
            // 
            this.pizzasToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.pizzasToolStripLabel.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.pizzasToolStripLabel.Name = "pizzasToolStripLabel";
            this.pizzasToolStripLabel.Size = new System.Drawing.Size(55, 23);
            this.pizzasToolStripLabel.Text = "PIZZAS";
            // 
            // pizzasToolStripDropDownButton
            // 
            this.pizzasToolStripDropDownButton.AutoToolTip = false;
            this.pizzasToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pizzasToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPizzasToolStripMenuItem,
            this.createPizzaToolStripMenuItem});
            this.pizzasToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("pizzasToolStripDropDownButton.Image")));
            this.pizzasToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pizzasToolStripDropDownButton.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.pizzasToolStripDropDownButton.Name = "pizzasToolStripDropDownButton";
            this.pizzasToolStripDropDownButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pizzasToolStripDropDownButton.Size = new System.Drawing.Size(39, 23);
            this.pizzasToolStripDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // viewPizzasToolStripMenuItem
            // 
            this.viewPizzasToolStripMenuItem.Name = "viewPizzasToolStripMenuItem";
            this.viewPizzasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewPizzasToolStripMenuItem.Text = "View pizzas";
            this.viewPizzasToolStripMenuItem.Click += new System.EventHandler(this.viewPizzasToolStripMenuItem_Click);
            // 
            // createPizzaToolStripMenuItem
            // 
            this.createPizzaToolStripMenuItem.Name = "createPizzaToolStripMenuItem";
            this.createPizzaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.createPizzaToolStripMenuItem.Text = "Create pizza";
            this.createPizzaToolStripMenuItem.Click += new System.EventHandler(this.createPizzaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formToolStrip);
            this.Controls.Add(this.multiDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pizza Delivery Service";
            ((System.ComponentModel.ISupportInitialize)(this.multiDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.formToolStrip.ResumeLayout(false);
            this.formToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView multiDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox formTitleRichTextBox;
        private System.Windows.Forms.ToolStrip formToolStrip;
        private System.Windows.Forms.ToolStripLabel usersToolStripLabel;
        private System.Windows.Forms.ToolStripDropDownButton usersToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ingredientsToolStripLabel;
        private System.Windows.Forms.ToolStripDropDownButton ingredientsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem viewIngredientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createIngredientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel pizzasToolStripLabel;
        private System.Windows.Forms.ToolStripDropDownButton pizzasToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem viewPizzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

