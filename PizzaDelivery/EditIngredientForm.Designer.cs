namespace PizzaDelivery
{
    partial class EditIngredientForm
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
            this.commitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newQuantityTextBox = new System.Windows.Forms.TextBox();
            this.newQuantityLabel = new System.Windows.Forms.Label();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // commitButton
            // 
            this.commitButton.BackColor = System.Drawing.Color.Lime;
            this.commitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commitButton.Location = new System.Drawing.Point(233, 134);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(75, 23);
            this.commitButton.TabIndex = 7;
            this.commitButton.Text = "Commit";
            this.commitButton.UseVisualStyleBackColor = false;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(12, 134);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // newQuantityTextBox
            // 
            this.newQuantityTextBox.Location = new System.Drawing.Point(12, 99);
            this.newQuantityTextBox.Name = "newQuantityTextBox";
            this.newQuantityTextBox.Size = new System.Drawing.Size(296, 20);
            this.newQuantityTextBox.TabIndex = 5;
            // 
            // newQuantityLabel
            // 
            this.newQuantityLabel.AutoSize = true;
            this.newQuantityLabel.ForeColor = System.Drawing.Color.White;
            this.newQuantityLabel.Location = new System.Drawing.Point(9, 72);
            this.newQuantityLabel.Name = "newQuantityLabel";
            this.newQuantityLabel.Size = new System.Drawing.Size(71, 13);
            this.newQuantityLabel.TabIndex = 4;
            this.newQuantityLabel.Text = "New Quantity";
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(12, 38);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(296, 20);
            this.newNameTextBox.TabIndex = 9;
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.ForeColor = System.Drawing.Color.White;
            this.newNameLabel.Location = new System.Drawing.Point(9, 11);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(60, 13);
            this.newNameLabel.TabIndex = 8;
            this.newNameLabel.Text = "New Name";
            // 
            // EditIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(321, 173);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newQuantityTextBox);
            this.Controls.Add(this.newQuantityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditIngredientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditIngredientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox newQuantityTextBox;
        private System.Windows.Forms.Label newQuantityLabel;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label newNameLabel;
    }
}