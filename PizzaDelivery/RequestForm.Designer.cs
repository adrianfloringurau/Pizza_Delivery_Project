namespace PizzaDelivery
{
    partial class RequestForm
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.clientRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryManRadioButton = new System.Windows.Forms.RadioButton();
            this.administratorRadioButton = new System.Windows.Forms.RadioButton();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.moreInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.moreInfoLabel = new System.Windows.Forms.Label();
            this.formPanel.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formPanel.Controls.Add(this.backButton);
            this.formPanel.Controls.Add(this.musicButton);
            this.formPanel.Controls.Add(this.formTitleLabel);
            this.formPanel.Controls.Add(this.exitButton);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(350, 43);
            this.formPanel.TabIndex = 0;
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_mouse_Down);
            this.formPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_mouse_Move);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(207, 5);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 33);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "◄";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.musicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicButton.Location = new System.Drawing.Point(253, 5);
            this.musicButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(44, 33);
            this.musicButton.TabIndex = 12;
            this.musicButton.Text = "🔊";
            this.musicButton.UseVisualStyleBackColor = false;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.ForeColor = System.Drawing.Color.White;
            this.formTitleLabel.Location = new System.Drawing.Point(12, 10);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(138, 23);
            this.formTitleLabel.TabIndex = 6;
            this.formTitleLabel.Text = "Request Access";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(300, 5);
            this.exitButton.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(44, 33);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "✖";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(45, 70);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(261, 23);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "What role will you apply for?";
            // 
            // clientRadioButton
            // 
            this.clientRadioButton.AutoSize = true;
            this.clientRadioButton.ForeColor = System.Drawing.Color.Red;
            this.clientRadioButton.Location = new System.Drawing.Point(28, 30);
            this.clientRadioButton.Name = "clientRadioButton";
            this.clientRadioButton.Size = new System.Drawing.Size(79, 27);
            this.clientRadioButton.TabIndex = 2;
            this.clientRadioButton.TabStop = true;
            this.clientRadioButton.Text = "Client";
            this.clientRadioButton.UseVisualStyleBackColor = true;
            this.clientRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonGroup_Check);
            // 
            // deliveryManRadioButton
            // 
            this.deliveryManRadioButton.AutoSize = true;
            this.deliveryManRadioButton.ForeColor = System.Drawing.Color.Red;
            this.deliveryManRadioButton.Location = new System.Drawing.Point(28, 63);
            this.deliveryManRadioButton.Name = "deliveryManRadioButton";
            this.deliveryManRadioButton.Size = new System.Drawing.Size(147, 27);
            this.deliveryManRadioButton.TabIndex = 3;
            this.deliveryManRadioButton.TabStop = true;
            this.deliveryManRadioButton.Text = "Delivery Man";
            this.deliveryManRadioButton.UseVisualStyleBackColor = true;
            this.deliveryManRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonGroup_Check);
            // 
            // administratorRadioButton
            // 
            this.administratorRadioButton.AutoSize = true;
            this.administratorRadioButton.ForeColor = System.Drawing.Color.Red;
            this.administratorRadioButton.Location = new System.Drawing.Point(28, 96);
            this.administratorRadioButton.Name = "administratorRadioButton";
            this.administratorRadioButton.Size = new System.Drawing.Size(151, 27);
            this.administratorRadioButton.TabIndex = 4;
            this.administratorRadioButton.TabStop = true;
            this.administratorRadioButton.Text = "Administrator";
            this.administratorRadioButton.UseVisualStyleBackColor = true;
            this.administratorRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonGroup_Check);
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.administratorRadioButton);
            this.optionsGroupBox.Controls.Add(this.deliveryManRadioButton);
            this.optionsGroupBox.Controls.Add(this.clientRadioButton);
            this.optionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsGroupBox.ForeColor = System.Drawing.Color.White;
            this.optionsGroupBox.Location = new System.Drawing.Point(75, 108);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(200, 135);
            this.optionsGroupBox.TabIndex = 5;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Available options";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.Enabled = false;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Location = new System.Drawing.Point(46, 470);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(258, 39);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // moreInfoRichTextBox
            // 
            this.moreInfoRichTextBox.BackColor = System.Drawing.Color.Black;
            this.moreInfoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moreInfoRichTextBox.BulletIndent = 1;
            this.moreInfoRichTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.moreInfoRichTextBox.Location = new System.Drawing.Point(46, 303);
            this.moreInfoRichTextBox.Name = "moreInfoRichTextBox";
            this.moreInfoRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.moreInfoRichTextBox.Size = new System.Drawing.Size(258, 145);
            this.moreInfoRichTextBox.TabIndex = 12;
            this.moreInfoRichTextBox.Text = "";
            // 
            // moreInfoLabel
            // 
            this.moreInfoLabel.AutoSize = true;
            this.moreInfoLabel.ForeColor = System.Drawing.Color.White;
            this.moreInfoLabel.Location = new System.Drawing.Point(51, 261);
            this.moreInfoLabel.Name = "moreInfoLabel";
            this.moreInfoLabel.Size = new System.Drawing.Size(248, 23);
            this.moreInfoLabel.TabIndex = 13;
            this.moreInfoLabel.Text = "Tell us more about yourself.";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 540);
            this.Controls.Add(this.moreInfoLabel);
            this.Controls.Add(this.moreInfoRichTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.optionsGroupBox);
            this.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RequestForm";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton clientRadioButton;
        private System.Windows.Forms.RadioButton deliveryManRadioButton;
        private System.Windows.Forms.RadioButton administratorRadioButton;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox moreInfoRichTextBox;
        private System.Windows.Forms.Label moreInfoLabel;
    }
}