using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double swordPrice = 5.03;
        double chestplatePrice = 10.75;
        double hammerPrice = 3.37;

        double swordAmount;
        double chestplateAmount;
        double hammerAmount;
        double tenderedAmount;

        double tax = 0.13;
        double totalPrice;
        double subTotal;
        double taxPrice;
        double change;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                swordAmount = Convert.ToInt32(numberOfSwordsTextbox.Text);
                chestplateAmount = Convert.ToInt32(numberOfChestplatesTextbox.Text);
                hammerAmount = Convert.ToInt32(numberOfHammersTextbox.Text);

                subTotal = (swordAmount * swordPrice) + (chestplateAmount * chestplatePrice) + (hammerAmount * hammerPrice);
                subTotalNumLabel.Text = $"{subTotal.ToString("C")}";

                taxPrice = subTotal * tax;
                taxNumLabel.Text = $"{taxPrice.ToString("C")}";


                totalPrice = taxPrice + subTotal;
                totalNumLabel.Text = $"{totalPrice.ToString("C")}";
            }
            catch
            {
                anitiCrashLabel.Text = "Please insert amount and use numbers";

                anitiCrashLabel.ForeColor = Color.Red;
                anitiCrashLabel.BackColor = Color.Transparent;
                Refresh();
                Thread.Sleep(100);

                anitiCrashLabel.ForeColor = Color.White;
                anitiCrashLabel.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(100);

                anitiCrashLabel.ForeColor = Color.Red;
                anitiCrashLabel.BackColor = Color.Transparent;
                Refresh();
                Thread.Sleep(100);
            }

        }


        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderedAmount = Convert.ToInt32(tenderedTextbox.Text);
                change = tenderedAmount - totalPrice;

                changeNumLabel.Text = $"{change.ToString("C")}";
            }
            catch
            {
                anitiCrashLabel.Text = "Please ender tender amount in numbers";

                anitiCrashLabel.ForeColor = Color.Red;
                anitiCrashLabel.BackColor = Color.Transparent;
                Refresh();
                Thread.Sleep(100);

                anitiCrashLabel.ForeColor = Color.White;
                anitiCrashLabel.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(100);

                anitiCrashLabel.ForeColor = Color.Red;
                anitiCrashLabel.BackColor = Color.Transparent;
                Refresh();
                Thread.Sleep(100);
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "        Hunters Blacksmith";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += "\n\nOrder Number 66";
            Refresh();
            Thread.Sleep(500);
            
            receiptLabel.Text += "\nFebruary 10, 2021";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\n\nSwords                  x{swordAmount}  @ {swordPrice}";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\nChestplates             x{chestplateAmount}  @ {chestplatePrice}";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\nHammers                 x{hammerAmount}  @ {hammerPrice}";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\n\nSubtotal                     {subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\nTax                          {taxPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\nTotal                        {totalPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\n\nTendered                     ${tenderedAmount}";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\nChange                       {change.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\n\n        Have a nice day!";
            Refresh();
            Thread.Sleep(500);


        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            swordAmount = 0;
            chestplateAmount = 0;
            hammerAmount = 0;

            swordPrice = 0;
            chestplatePrice = 0;
            hammerPrice = 0;

            subTotal = 0;
            taxPrice = 0;
            totalPrice = 0;
            tenderedAmount = 0;
            change = 0;


            numberOfSwordsTextbox.Text = "0";
            numberOfChestplatesTextbox.Text = "0";
            numberOfHammersTextbox.Text = "0";
            tenderedTextbox.Text = "0";

            subTotalNumLabel.Text = "0";
            taxNumLabel.Text = "0";
            totalNumLabel.Text = "0";
            changeNumLabel.Text = "0";

            swordPrice = 5.03;
            chestplatePrice = 10.75;
            hammerPrice = 3.36;


        }
    }
}
