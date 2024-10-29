namespace Project__3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grpScoops = new GroupBox();
            radThreeScoop = new RadioButton();
            radTwoScoop = new RadioButton();
            radOneScoop = new RadioButton();
            lstFlavors = new ListBox();
            grpToppings = new GroupBox();
            chkGummyWorms = new CheckBox();
            chkCherrySyrup = new CheckBox();
            chkChocolateChips = new CheckBox();
            chkOreos = new CheckBox();
            chkSprinkles = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTotal = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            btnPrintOrder = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            grpScoops.SuspendLayout();
            grpToppings.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(126, 41);
            label1.TabIndex = 0;
            label1.Text = "Flavors:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 48);
            label2.Name = "label2";
            label2.Size = new Size(125, 41);
            label2.TabIndex = 1;
            label2.Text = "Scoops:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(714, 48);
            label3.Name = "label3";
            label3.Size = new Size(156, 41);
            label3.TabIndex = 2;
            label3.Text = "Toppings:";
            // 
            // grpScoops
            // 
            grpScoops.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpScoops.BackColor = Color.White;
            grpScoops.BackgroundImageLayout = ImageLayout.None;
            grpScoops.Controls.Add(radThreeScoop);
            grpScoops.Controls.Add(radTwoScoop);
            grpScoops.Controls.Add(radOneScoop);
            grpScoops.Location = new Point(350, 100);
            grpScoops.Margin = new Padding(0);
            grpScoops.Name = "grpScoops";
            grpScoops.Padding = new Padding(0);
            grpScoops.Size = new Size(345, 512);
            grpScoops.TabIndex = 3;
            grpScoops.TabStop = false;
            // 
            // radThreeScoop
            // 
            radThreeScoop.AutoSize = true;
            radThreeScoop.Font = new Font("Segoe UI", 9F);
            radThreeScoop.Location = new Point(54, 406);
            radThreeScoop.Name = "radThreeScoop";
            radThreeScoop.Size = new Size(235, 45);
            radThreeScoop.TabIndex = 3;
            radThreeScoop.TabStop = true;
            radThreeScoop.Text = "Three Scoops";
            radThreeScoop.UseVisualStyleBackColor = true;
            radThreeScoop.CheckedChanged += radThreeScoop_CheckedChanged;
            // 
            // radTwoScoop
            // 
            radTwoScoop.AutoSize = true;
            radTwoScoop.Font = new Font("Segoe UI", 9F);
            radTwoScoop.Location = new Point(54, 246);
            radTwoScoop.Name = "radTwoScoop";
            radTwoScoop.Size = new Size(214, 45);
            radTwoScoop.TabIndex = 2;
            radTwoScoop.TabStop = true;
            radTwoScoop.Text = "Two Scoops";
            radTwoScoop.UseVisualStyleBackColor = true;
            radTwoScoop.CheckedChanged += radTwoScoop_CheckedChanged;
            // 
            // radOneScoop
            // 
            radOneScoop.AutoSize = true;
            radOneScoop.Font = new Font("Segoe UI", 9F);
            radOneScoop.Location = new Point(54, 89);
            radOneScoop.Name = "radOneScoop";
            radOneScoop.Size = new Size(203, 45);
            radOneScoop.TabIndex = 1;
            radOneScoop.TabStop = true;
            radOneScoop.Text = "One Scoop";
            radOneScoop.UseVisualStyleBackColor = true;
            radOneScoop.CheckedChanged += radOneScoop_CheckedChanged;
            // 
            // lstFlavors
            // 
            lstFlavors.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstFlavors.FormattingEnabled = true;
            lstFlavors.ItemHeight = 41;
            lstFlavors.Items.AddRange(new object[] { "Chocolate", "Vanilla", "Cookie dough", "Strawberry", "Mint chip", "Mocha", "Cookies n cream" });
            lstFlavors.Location = new Point(38, 116);
            lstFlavors.Name = "lstFlavors";
            lstFlavors.SelectionMode = SelectionMode.MultiSimple;
            lstFlavors.Size = new Size(281, 496);
            lstFlavors.TabIndex = 0;
            // 
            // grpToppings
            // 
            grpToppings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpToppings.BackColor = Color.White;
            grpToppings.BackgroundImageLayout = ImageLayout.None;
            grpToppings.Controls.Add(chkGummyWorms);
            grpToppings.Controls.Add(chkCherrySyrup);
            grpToppings.Controls.Add(chkChocolateChips);
            grpToppings.Controls.Add(chkOreos);
            grpToppings.Controls.Add(chkSprinkles);
            grpToppings.Location = new Point(730, 100);
            grpToppings.Margin = new Padding(0);
            grpToppings.Name = "grpToppings";
            grpToppings.Padding = new Padding(0);
            grpToppings.Size = new Size(351, 512);
            grpToppings.TabIndex = 4;
            grpToppings.TabStop = false;
            // 
            // chkGummyWorms
            // 
            chkGummyWorms.AutoSize = true;
            chkGummyWorms.Font = new Font("Segoe UI", 9F);
            chkGummyWorms.Location = new Point(56, 392);
            chkGummyWorms.Name = "chkGummyWorms";
            chkGummyWorms.Size = new Size(263, 45);
            chkGummyWorms.TabIndex = 8;
            chkGummyWorms.Text = "Gummy Worms";
            chkGummyWorms.UseVisualStyleBackColor = true;
            chkGummyWorms.CheckedChanged += chkGummyWorms_CheckedChanged;
            // 
            // chkCherrySyrup
            // 
            chkCherrySyrup.AutoSize = true;
            chkCherrySyrup.Font = new Font("Segoe UI", 9F);
            chkCherrySyrup.Location = new Point(56, 306);
            chkCherrySyrup.Name = "chkCherrySyrup";
            chkCherrySyrup.Size = new Size(226, 45);
            chkCherrySyrup.TabIndex = 7;
            chkCherrySyrup.Text = "Cherry Syrup";
            chkCherrySyrup.UseVisualStyleBackColor = true;
            chkCherrySyrup.CheckedChanged += chkCherrySyrup_CheckedChanged;
            // 
            // chkChocolateChips
            // 
            chkChocolateChips.AutoSize = true;
            chkChocolateChips.Font = new Font("Segoe UI", 9F);
            chkChocolateChips.Location = new Point(56, 221);
            chkChocolateChips.Name = "chkChocolateChips";
            chkChocolateChips.Size = new Size(272, 45);
            chkChocolateChips.TabIndex = 6;
            chkChocolateChips.Text = "Chocolate Chips";
            chkChocolateChips.UseVisualStyleBackColor = true;
            chkChocolateChips.CheckedChanged += chkChocolateChips_CheckedChanged;
            // 
            // chkOreos
            // 
            chkOreos.AutoSize = true;
            chkOreos.Font = new Font("Segoe UI", 9F);
            chkOreos.Location = new Point(56, 145);
            chkOreos.Name = "chkOreos";
            chkOreos.Size = new Size(136, 45);
            chkOreos.TabIndex = 5;
            chkOreos.Text = "Oreos";
            chkOreos.UseVisualStyleBackColor = true;
            chkOreos.CheckedChanged += chkOreos_CheckedChanged;
            // 
            // chkSprinkles
            // 
            chkSprinkles.AutoSize = true;
            chkSprinkles.Font = new Font("Segoe UI", 9F);
            chkSprinkles.Location = new Point(56, 64);
            chkSprinkles.Name = "chkSprinkles";
            chkSprinkles.Size = new Size(175, 45);
            chkSprinkles.TabIndex = 4;
            chkSprinkles.Text = "Sprinkles";
            chkSprinkles.UseVisualStyleBackColor = true;
            chkSprinkles.CheckedChanged += chkSprinkles_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(350, 622);
            label4.Name = "label4";
            label4.Size = new Size(170, 32);
            label4.TabIndex = 6;
            label4.Text = "$1.00/scoop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F);
            label5.Location = new Point(730, 634);
            label5.Name = "label5";
            label5.Size = new Size(173, 32);
            label5.TabIndex = 7;
            label5.Text = "$.50/topping";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.Location = new Point(609, 731);
            label6.Name = "label6";
            label6.Size = new Size(86, 32);
            label6.TabIndex = 8;
            label6.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(720, 721);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(371, 47);
            txtTotal.TabIndex = 9;
            txtTotal.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(720, 831);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(173, 50);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.Location = new Point(918, 831);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 50);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPrintOrder
            // 
            btnPrintOrder.Font = new Font("Segoe UI", 9F);
            btnPrintOrder.Location = new Point(350, 831);
            btnPrintOrder.Name = "btnPrintOrder";
            btnPrintOrder.Size = new Size(236, 50);
            btnPrintOrder.TabIndex = 9;
            btnPrintOrder.Text = "Print Order";
            btnPrintOrder.UseVisualStyleBackColor = true;
            btnPrintOrder.Click += btnPrintOrder_Click;
            // 
            // printDocument1
            // 
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1117, 893);
            Controls.Add(btnPrintOrder);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(grpToppings);
            Controls.Add(lstFlavors);
            Controls.Add(label2);
            Controls.Add(grpScoops);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Ice Cream Store";
            grpScoops.ResumeLayout(false);
            grpScoops.PerformLayout();
            grpToppings.ResumeLayout(false);
            grpToppings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox grpScoops;
        private ListBox lstFlavors;
        private RadioButton radThreeScoop;
        private RadioButton radTwoScoop;
        private RadioButton radOneScoop;
        private GroupBox grpToppings;
        private CheckBox chkChocolateChips;
        private CheckBox chkOreos;
        private CheckBox chkSprinkles;
        private CheckBox chkGummyWorms;
        private CheckBox chkCherrySyrup;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTotal;
        private Button btnClear;
        private Button btnExit;
        private Button btnPrintOrder;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
