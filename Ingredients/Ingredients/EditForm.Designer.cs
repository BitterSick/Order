namespace Ingredients
{
    partial class EditForm
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
            button1 = new Button();
            button2 = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            comboBox_Category = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtPrice = new TextBox();
            checkBox_isAvailable = new CheckBox();
            label8 = new Label();
            comboBox_CreatedBy = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(301, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 0;
            label1.Text = "Edit Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(47, 81);
            label2.Name = "label2";
            label2.Size = new Size(33, 28);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(50, 280);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(47, 129);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(58, 460);
            button1.Name = "button1";
            button1.Size = new Size(144, 64);
            button1.TabIndex = 7;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(512, 460);
            button2.Name = "button2";
            button2.Size = new Size(144, 64);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(177, 78);
            txtID.Name = "txtID";
            txtID.Size = new Size(482, 31);
            txtID.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(482, 31);
            txtName.TabIndex = 1;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(47, 176);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 9;
            label5.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(177, 176);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(482, 31);
            txtDescription.TabIndex = 2;
            txtDescription.KeyDown += txtDescription_KeyDown;
            // 
            // comboBox_Category
            // 
            comboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Items.AddRange(new object[] { "Starters", "Soups", "Main dish", "Side dish", "Beverage", "Cocktails", "Desserts" });
            comboBox_Category.Location = new Point(180, 280);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(482, 33);
            comboBox_Category.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(47, 230);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 10;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(47, 392);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 11;
            label7.Text = "Availability";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(177, 230);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(479, 31);
            txtPrice.TabIndex = 3;
            txtPrice.KeyDown += txtPrice_KeyDown;
            // 
            // checkBox_isAvailable
            // 
            checkBox_isAvailable.AutoSize = true;
            checkBox_isAvailable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            checkBox_isAvailable.Location = new Point(177, 388);
            checkBox_isAvailable.Name = "checkBox_isAvailable";
            checkBox_isAvailable.Size = new Size(205, 32);
            checkBox_isAvailable.TabIndex = 6;
            checkBox_isAvailable.Text = "Check if available";
            checkBox_isAvailable.UseVisualStyleBackColor = true;
            checkBox_isAvailable.KeyDown += checkBox_isAvailable_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(47, 338);
            label8.Name = "label8";
            label8.Size = new Size(114, 28);
            label8.TabIndex = 12;
            label8.Text = "Created by";
            // 
            // comboBox_CreatedBy
            // 
            comboBox_CreatedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CreatedBy.FormattingEnabled = true;
            comboBox_CreatedBy.Items.AddRange(new object[] { "Person1", "Person2" });
            comboBox_CreatedBy.Location = new Point(177, 333);
            comboBox_CreatedBy.Name = "comboBox_CreatedBy";
            comboBox_CreatedBy.Size = new Size(482, 33);
            comboBox_CreatedBy.TabIndex = 5;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(686, 536);
            Controls.Add(comboBox_CreatedBy);
            Controls.Add(label8);
            Controls.Add(checkBox_isAvailable);
            Controls.Add(txtPrice);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox_Category);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditForm";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox txtID;
        private TextBox txtName;
        private Label label5;
        private TextBox txtDescription;
        private ComboBox comboBox_Category;
        private Label label6;
        private Label label7;
        private TextBox txtPrice;
        private CheckBox checkBox_isAvailable;
        private Label label8;
        private ComboBox comboBox_CreatedBy;
    }
}