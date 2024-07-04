namespace PizzaDelivery
{
    partial class DeliveryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.announcementRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.formTitleLabel);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.musicButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_Mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_Mouse_Move);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.ForeColor = System.Drawing.Color.White;
            this.formTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(127, 23);
            this.formTitleLabel.TabIndex = 15;
            this.formTitleLabel.Text = "Delivery App";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(654, 5);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 33);
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
            this.musicButton.Location = new System.Drawing.Point(702, 5);
            this.musicButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(44, 33);
            this.musicButton.TabIndex = 8;
            this.musicButton.Text = "🔊";
            this.musicButton.UseVisualStyleBackColor = false;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(750, 5);
            this.exitButton.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(44, 33);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "✖";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleRichTextBox
            // 
            this.titleRichTextBox.BackColor = System.Drawing.Color.Black;
            this.titleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleRichTextBox.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleRichTextBox.ForeColor = System.Drawing.Color.Red;
            this.titleRichTextBox.Location = new System.Drawing.Point(12, 50);
            this.titleRichTextBox.Name = "titleRichTextBox";
            this.titleRichTextBox.ReadOnly = true;
            this.titleRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.titleRichTextBox.Size = new System.Drawing.Size(776, 48);
            this.titleRichTextBox.TabIndex = 11;
            this.titleRichTextBox.Text = "";
            // 
            // announcementRichTextBox
            // 
            this.announcementRichTextBox.BackColor = System.Drawing.Color.Black;
            this.announcementRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.announcementRichTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.announcementRichTextBox.Location = new System.Drawing.Point(314, 206);
            this.announcementRichTextBox.Name = "announcementRichTextBox";
            this.announcementRichTextBox.ReadOnly = true;
            this.announcementRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.announcementRichTextBox.Size = new System.Drawing.Size(195, 92);
            this.announcementRichTextBox.TabIndex = 12;
            this.announcementRichTextBox.Text = "";
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.announcementRichTextBox);
            this.Controls.Add(this.titleRichTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RichTextBox titleRichTextBox;
        private System.Windows.Forms.RichTextBox announcementRichTextBox;
    }
}