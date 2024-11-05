namespace Ingredients
{
    partial class AddForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            comboBox_Category = new ComboBox();
            OK_Button = new Button();
            Cancel_Button = new Button();
            label5 = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            checkBox_isAvailable = new CheckBox();
            label7 = new Label();
            comboBox_CreatedBy = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(112, 44);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(77, 103);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(41, 261);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 2;
            label3.Text = "Category ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(24, 163);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // txtID
            // 
            txtID.Location = new Point(162, 41);
            txtID.Name = "txtID";
            txtID.Size = new Size(501, 31);
            txtID.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(501, 31);
            txtName.TabIndex = 1;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(162, 160);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(501, 31);
            txtDescription.TabIndex = 2;
            txtDescription.KeyDown += txtDescription_KeyDown;
            // 
            // comboBox_Category
            // 
            comboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Items.AddRange(new object[] { "Starters", "Soups", "Main Dish", "Side dish", "Beverage", "Cocktails", "Desserts" });
            comboBox_Category.Location = new Point(162, 261);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(496, 33);
            comboBox_Category.TabIndex = 4;
            comboBox_Category.KeyDown += comboBox_Category_KeyDown;
            // 
            // OK_Button
            // 
            OK_Button.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            OK_Button.Location = new Point(86, 473);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(221, 71);
            OK_Button.TabIndex = 7;
            OK_Button.Text = "OK";
            OK_Button.UseVisualStyleBackColor = true;
            OK_Button.Click += OK_Button_Click;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Cancel_Button.Location = new Point(449, 473);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(221, 71);
            Cancel_Button.TabIndex = 8;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = true;
            Cancel_Button.Click += Cancel_Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(86, 213);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(24, 371);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 8;
            label6.Text = "Availability";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(162, 213);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(503, 31);
            txtPrice.TabIndex = 3;
            // 
            // checkBox_isAvailable
            // 
            checkBox_isAvailable.AutoSize = true;
            checkBox_isAvailable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            checkBox_isAvailable.Location = new Point(161, 373);
            checkBox_isAvailable.Name = "checkBox_isAvailable";
            checkBox_isAvailable.Size = new Size(205, 32);
            checkBox_isAvailable.TabIndex = 6;
            checkBox_isAvailable.Text = "Check if available";
            checkBox_isAvailable.UseVisualStyleBackColor = true;
            checkBox_isAvailable.CheckedChanged += checkBox_isAvailable_CheckedChanged;
            checkBox_isAvailable.KeyDown += checkBox_isAvailable_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(23, 320);
            label7.Name = "label7";
            label7.Size = new Size(114, 28);
            label7.TabIndex = 9;
            label7.Text = "Created by";
            // 
            // comboBox_CreatedBy
            // 
            comboBox_CreatedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CreatedBy.FormattingEnabled = true;
            comboBox_CreatedBy.Items.AddRange(new object[] { "Person1", "Person2" });
            comboBox_CreatedBy.Location = new Point(161, 315);
            comboBox_CreatedBy.Name = "comboBox_CreatedBy";
            comboBox_CreatedBy.Size = new Size(496, 33);
            comboBox_CreatedBy.TabIndex = 5;
            comboBox_CreatedBy.KeyDown += comboBox_CreatedBy_KeyDown;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(717, 579);
            Controls.Add(comboBox_CreatedBy);
            Controls.Add(label7);
            Controls.Add(checkBox_isAvailable);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Cancel_Button);
            Controls.Add(OK_Button);
            Controls.Add(comboBox_Category);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDescription;
        private ComboBox comboBox_Category;
        private Button OK_Button;
        private Button Cancel_Button;
        private Label label5;
        private Label label6;
        private TextBox txtPrice;
        private CheckBox checkBox_isAvailable;
        private Label label7;
        private ComboBox comboBox_CreatedBy;
    }
}