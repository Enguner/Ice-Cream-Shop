using System.Windows.Forms;

namespace Project__3
{
    public partial class Form1 : Form
    {
        const double PRICE_PER_SCOOP = 1.00;
        const double PRICE_PER_TOPPING = 0.50;
        int numOfScoops = 1;
        int toppingsClicked = 0;
        public Form1()
        {
            InitializeComponent();
            lstFlavors.SelectedIndex = 0;
            radOneScoop.Checked = true;

        }

        private void btnClear_Click(object sender, EventArgs e) // Done
        {
            lstFlavors.SelectedIndex = -1; // Flavor collection cleared of selectionunclickButton(); // meant to unclick radio buttons if clicked
            lstFlavors.SelectedIndex = 0;
            radOneScoop.Checked = true;
            unclickChecks();
            updateTotal();
        }

        private void updateTotal() // Done
        {
            double totalAmount = 0 + (0.50 * toppingsClicked);

            switch (numOfScoops)
            {
                case 0:
                    totalAmount = 0;
                    break;

                default:
                    totalAmount += (PRICE_PER_SCOOP * numOfScoops);
                    break;
            }
            txtTotal.Text = "$" + totalAmount.ToString("F2");
        }

        private void unclickChecks() //Done 
        {
            chkSprinkles.Checked = false;
            chkOreos.Checked = false;
            chkChocolateChips.Checked = false;
            chkCherrySyrup.Checked = false;
            chkGummyWorms.Checked = false;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintOrder_Click(object sender, EventArgs e) // Please implement
        {
            if (lstFlavors.SelectedItems.Count >= 1)
            {
                string selectedFlavors = string.Join(", ", lstFlavors.SelectedItems.Cast<string>());
                string printMe = "Total: " + txtTotal.Text + "\r\n" + "Flavors: " + selectedFlavors + "\r\n";
                switch (numOfScoops)
                {
                    case 1:
                        printMe += "Scoops: One Scoop\r\n";
                        break;

                    case 2:
                        printMe += "Scoops: Two Scoops\r\n";
                        break;

                    case 3:
                        printMe += "Scoops: Three Scoops\r\n";
                        break;
                }
                printMe += "Toppings:\r\n";

                if (toppingsClicked == 0)
                {
                    printMe += "No Toppings\r\n";
                }

                else
                {
                    if (chkSprinkles.Checked)
                    {
                        printMe += "\t-Sprinkles\r\n";
                    }
                    if (chkOreos.Checked)
                    {
                        printMe += "\t-Oreos\r\n";
                    }
                    if (chkChocolateChips.Checked)
                    {
                        printMe += "\t-Chococolate Chips\r\n";
                    }
                    if (chkCherrySyrup.Checked)
                    {
                        printMe += "\t-Cherry Syrup\r\n";
                    }
                    if (chkGummyWorms.Checked)
                    {
                        printMe += "\t-Gummy Worms\r\n";
                    }
                }


                Form2 form2 = new Form2(printMe);
                form2.Show();
            }


        }

            private void chkSprinkles_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged(chkSprinkles);
        }

        private void chkOreos_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged(chkOreos);
        }

        private void chkChocolateChips_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged(chkChocolateChips);
        }

        private void chkCherrySyrup_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged(chkCherrySyrup);
        }
        
        private void chkGummyWorms_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged(chkGummyWorms);
        }

        private void chkChanged(CheckBox chkBox)
        {
            if (chkBox.Checked)
            {
                toppingsClicked += 1;
            }

            else
            {
                toppingsClicked -= 1;
            }

            updateTotal();
        }

        private void radOneScoop_CheckedChanged(object sender, EventArgs e)
        {
            radButtonChanged(1);
        }

        private void radTwoScoop_CheckedChanged(object sender, EventArgs e)
        {
            radButtonChanged(2);
        }

        private void radThreeScoop_CheckedChanged(object sender, EventArgs e)
        {
            radButtonChanged(3);
        }

        private void radButtonChanged(int numOfScoops)
        {
            this.numOfScoops = numOfScoops;
            updateTotal();
        }


    }
}
