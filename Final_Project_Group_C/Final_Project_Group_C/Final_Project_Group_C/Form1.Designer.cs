namespace Final_Project_Group_C
{
    partial class Form1
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
            this.textBoxNumScoop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonRemoveCustomer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.checkBoxMakeItSuper = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrderSummary = new System.Windows.Forms.TextBox();
            this.listBoxOrderNum = new System.Windows.Forms.ListBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonPlain = new System.Windows.Forms.RadioButton();
            this.radioButtonChocolate = new System.Windows.Forms.RadioButton();
            this.radioButtonVanilla = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonYogurt = new System.Windows.Forms.RadioButton();
            this.radioButtonIceCream = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.listBoxManageCustomers = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumScoop
            // 
            this.textBoxNumScoop.Location = new System.Drawing.Point(808, 167);
            this.textBoxNumScoop.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNumScoop.Name = "textBoxNumScoop";
            this.textBoxNumScoop.Size = new System.Drawing.Size(196, 31);
            this.textBoxNumScoop.TabIndex = 8;
            this.textBoxNumScoop.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of scoop:";
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(351, 21);
            this.buttonAddCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(297, 71);
            this.buttonAddCustomer.TabIndex = 10;
            this.buttonAddCustomer.Text = "Add customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonRemoveCustomer
            // 
            this.buttonRemoveCustomer.Location = new System.Drawing.Point(696, 21);
            this.buttonRemoveCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRemoveCustomer.Name = "buttonRemoveCustomer";
            this.buttonRemoveCustomer.Size = new System.Drawing.Size(278, 71);
            this.buttonRemoveCustomer.TabIndex = 11;
            this.buttonRemoveCustomer.Text = "Remove customer";
            this.buttonRemoveCustomer.UseVisualStyleBackColor = true;
            this.buttonRemoveCustomer.Click += new System.EventHandler(this.buttonRemoveCustomer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1112, 44);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 793);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.buttonCancel);
            this.tabPage1.Controls.Add(this.buttonAddToOrder);
            this.tabPage1.Controls.Add(this.checkBoxMakeItSuper);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxOrderSummary);
            this.tabPage1.Controls.Add(this.listBoxOrderNum);
            this.tabPage1.Controls.Add(this.comboBoxCustomer);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxNumScoop);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1096, 746);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Take orders";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 31);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Please select a customer before placing order";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(895, 319);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Clear";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Location = new System.Drawing.Point(492, 294);
            this.buttonAddToOrder.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(199, 84);
            this.buttonAddToOrder.TabIndex = 19;
            this.buttonAddToOrder.Text = "Place order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // checkBoxMakeItSuper
            // 
            this.checkBoxMakeItSuper.AutoSize = true;
            this.checkBoxMakeItSuper.Location = new System.Drawing.Point(813, 214);
            this.checkBoxMakeItSuper.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxMakeItSuper.Name = "checkBoxMakeItSuper";
            this.checkBoxMakeItSuper.Size = new System.Drawing.Size(101, 29);
            this.checkBoxMakeItSuper.TabIndex = 18;
            this.checkBoxMakeItSuper.Text = "Super";
            this.checkBoxMakeItSuper.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Oders:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order summary:";
            // 
            // textBoxOrderSummary
            // 
            this.textBoxOrderSummary.Location = new System.Drawing.Point(268, 390);
            this.textBoxOrderSummary.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxOrderSummary.Multiline = true;
            this.textBoxOrderSummary.Name = "textBoxOrderSummary";
            this.textBoxOrderSummary.Size = new System.Drawing.Size(736, 254);
            this.textBoxOrderSummary.TabIndex = 15;
            // 
            // listBoxOrderNum
            // 
            this.listBoxOrderNum.FormattingEnabled = true;
            this.listBoxOrderNum.ItemHeight = 25;
            this.listBoxOrderNum.Location = new System.Drawing.Point(62, 390);
            this.listBoxOrderNum.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxOrderNum.Name = "listBoxOrderNum";
            this.listBoxOrderNum.Size = new System.Drawing.Size(118, 254);
            this.listBoxOrderNum.TabIndex = 14;
            this.listBoxOrderNum.SelectedIndexChanged += new System.EventHandler(this.listBoxOrderNum_SelectedIndexChanged);
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(366, 66);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(308, 33);
            this.comboBoxCustomer.TabIndex = 13;
            this.comboBoxCustomer.Text = "Select a customer...";
            this.comboBoxCustomer.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCustomer_SelectionChangeCommitted);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonLarge);
            this.groupBox3.Controls.Add(this.radioButtonRegular);
            this.groupBox3.Controls.Add(this.radioButtonSmall);
            this.groupBox3.Location = new System.Drawing.Point(576, 111);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(220, 192);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cone";
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(14, 131);
            this.radioButtonLarge.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(156, 29);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "GottaHaveit";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(14, 85);
            this.radioButtonRegular.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(101, 29);
            this.radioButtonRegular.TabIndex = 1;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "Loveit";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(14, 38);
            this.radioButtonSmall.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(94, 29);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Likeit";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPlain);
            this.groupBox2.Controls.Add(this.radioButtonChocolate);
            this.groupBox2.Controls.Add(this.radioButtonVanilla);
            this.groupBox2.Location = new System.Drawing.Point(304, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(220, 192);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What flavor";
            // 
            // radioButtonPlain
            // 
            this.radioButtonPlain.AutoSize = true;
            this.radioButtonPlain.Location = new System.Drawing.Point(36, 131);
            this.radioButtonPlain.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonPlain.Name = "radioButtonPlain";
            this.radioButtonPlain.Size = new System.Drawing.Size(175, 29);
            this.radioButtonPlain.TabIndex = 2;
            this.radioButtonPlain.TabStop = true;
            this.radioButtonPlain.Text = "FrenchVanilla";
            this.radioButtonPlain.UseVisualStyleBackColor = true;
            // 
            // radioButtonChocolate
            // 
            this.radioButtonChocolate.AutoSize = true;
            this.radioButtonChocolate.Location = new System.Drawing.Point(36, 85);
            this.radioButtonChocolate.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonChocolate.Name = "radioButtonChocolate";
            this.radioButtonChocolate.Size = new System.Drawing.Size(160, 29);
            this.radioButtonChocolate.TabIndex = 1;
            this.radioButtonChocolate.TabStop = true;
            this.radioButtonChocolate.Text = "CoffeeLover";
            this.radioButtonChocolate.UseVisualStyleBackColor = true;
            // 
            // radioButtonVanilla
            // 
            this.radioButtonVanilla.AutoSize = true;
            this.radioButtonVanilla.Location = new System.Drawing.Point(36, 38);
            this.radioButtonVanilla.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonVanilla.Name = "radioButtonVanilla";
            this.radioButtonVanilla.Size = new System.Drawing.Size(89, 29);
            this.radioButtonVanilla.TabIndex = 0;
            this.radioButtonVanilla.TabStop = true;
            this.radioButtonVanilla.Text = "plain";
            this.radioButtonVanilla.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonYogurt);
            this.groupBox1.Controls.Add(this.radioButtonIceCream);
            this.groupBox1.Location = new System.Drawing.Point(37, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(220, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make a choice";
            // 
            // radioButtonYogurt
            // 
            this.radioButtonYogurt.AutoSize = true;
            this.radioButtonYogurt.Location = new System.Drawing.Point(14, 83);
            this.radioButtonYogurt.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonYogurt.Name = "radioButtonYogurt";
            this.radioButtonYogurt.Size = new System.Drawing.Size(103, 29);
            this.radioButtonYogurt.TabIndex = 1;
            this.radioButtonYogurt.TabStop = true;
            this.radioButtonYogurt.Text = "yogurt";
            this.radioButtonYogurt.UseVisualStyleBackColor = true;
            // 
            // radioButtonIceCream
            // 
            this.radioButtonIceCream.AutoSize = true;
            this.radioButtonIceCream.Location = new System.Drawing.Point(14, 38);
            this.radioButtonIceCream.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonIceCream.Name = "radioButtonIceCream";
            this.radioButtonIceCream.Size = new System.Drawing.Size(136, 29);
            this.radioButtonIceCream.TabIndex = 0;
            this.radioButtonIceCream.TabStop = true;
            this.radioButtonIceCream.Text = "ice cream";
            this.radioButtonIceCream.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxCustomerID);
            this.tabPage2.Controls.Add(this.textBoxLastName);
            this.tabPage2.Controls.Add(this.textBoxFirstName);
            this.tabPage2.Controls.Add(this.listBoxManageCustomers);
            this.tabPage2.Controls.Add(this.buttonAddCustomer);
            this.tabPage2.Controls.Add(this.buttonRemoveCustomer);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1096, 746);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage customers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Customer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "First Name:";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(212, 267);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(196, 31);
            this.textBoxCustomerID.TabIndex = 15;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(212, 215);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(196, 31);
            this.textBoxLastName.TabIndex = 14;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(212, 163);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(196, 31);
            this.textBoxFirstName.TabIndex = 13;
            // 
            // listBoxManageCustomers
            // 
            this.listBoxManageCustomers.FormattingEnabled = true;
            this.listBoxManageCustomers.ItemHeight = 25;
            this.listBoxManageCustomers.Location = new System.Drawing.Point(444, 110);
            this.listBoxManageCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxManageCustomers.Name = "listBoxManageCustomers";
            this.listBoxManageCustomers.Size = new System.Drawing.Size(468, 504);
            this.listBoxManageCustomers.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1112, 837);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Ice Cream Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumScoop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonRemoveCustomer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrderSummary;
        private System.Windows.Forms.ListBox listBoxOrderNum;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonPlain;
        private System.Windows.Forms.RadioButton radioButtonChocolate;
        private System.Windows.Forms.RadioButton radioButtonVanilla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonYogurt;
        private System.Windows.Forms.RadioButton radioButtonIceCream;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxManageCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.CheckBox checkBoxMakeItSuper;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.TextBox textBox1;
    }
}


