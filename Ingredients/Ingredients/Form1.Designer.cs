namespace Ingredients
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addNewToolStripMenuItem = new ToolStripMenuItem();
            editTableToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            button5 = new Button();
            button6 = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            addNewItemToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            newBillToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.Location = new Point(86, 346);
            label5.Name = "label5";
            label5.Size = new Size(0, 36);
            label5.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1585, 1258);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addNewToolStripMenuItem, editTableToolStripMenuItem, deleteToolStripMenuItem1, deleteToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(207, 164);
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(206, 32);
            addNewToolStripMenuItem.Text = "Add new";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // editTableToolStripMenuItem
            // 
            editTableToolStripMenuItem.Name = "editTableToolStripMenuItem";
            editTableToolStripMenuItem.Size = new Size(206, 32);
            editTableToolStripMenuItem.Text = "Edit table";
            editTableToolStripMenuItem.Click += editTableToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(206, 32);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(206, 32);
            deleteToolStripMenuItem.Text = "Delete(window)";
            deleteToolStripMenuItem.Click += deleteRowToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(206, 32);
            exitToolStripMenuItem.Text = "Exit Application";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button5.Location = new Point(1620, 1276);
            button5.Name = "button5";
            button5.Size = new Size(223, 84);
            button5.TabIndex = 17;
            button5.Text = "Exit Application";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button6.Location = new Point(1620, 65);
            button6.Name = "button6";
            button6.Size = new Size(223, 94);
            button6.TabIndex = 16;
            button6.Text = "Create New+\r\n";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem3, toolStripMenuItem2, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1855, 33);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(85, 29);
            toolStripMenuItem1.Text = "System";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(144, 34);
            toolStripMenuItem5.Text = "E&xit";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(144, 34);
            toolStripMenuItem6.Text = "133";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { addNewItemToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(73, 29);
            toolStripMenuItem3.Text = "Menu";
            // 
            // addNewItemToolStripMenuItem
            // 
            addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            addNewItemToolStripMenuItem.Size = new Size(226, 34);
            addNewItemToolStripMenuItem.Text = "Add new Item";
            addNewItemToolStripMenuItem.Click += addNewItemToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { newBillToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(50, 29);
            toolStripMenuItem2.Text = "Bill";
            // 
            // newBillToolStripMenuItem
            // 
            newBillToolStripMenuItem.Name = "newBillToolStripMenuItem";
            newBillToolStripMenuItem.Size = new Size(177, 34);
            newBillToolStripMenuItem.Text = "New bill";
            newBillToolStripMenuItem.Click += newBillToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1855, 1372);
            Controls.Add(menuStrip1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        public DataGridView dataGridView1;       
        private Button button5;
        private Button button6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editTableToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem addNewItemToolStripMenuItem;
        private ToolStripMenuItem newBillToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}
