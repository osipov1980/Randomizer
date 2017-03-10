using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Form1 : Form
    {
        int randomizedNum;
        public Form1()
        {
            InitializeComponent();
            randomizedNum = 0;
            digitComboBox.Text = "1";
        }


//This function clean the lables from previous data and get random number

        private void startBtn_Click(object sender, EventArgs e)
        {
            resetLabels();
            randomizedNum = getRandomNumber();        
        }


        //-----------------------------------------------------------------------------------------------

        private int getRandomNumber()
        {
            int fromNum = 0;
            int toNum = 0;
            string digitFromComboBox = digitComboBox.Text;
            switch (digitFromComboBox)
            {
                case "0":
                case "1":
                    {
                        fromNum = 1;
                        toNum = 9;
                    }
                    break;
                case "2":
                    {
                        fromNum = 10;
                        toNum = 99;
                    }
                    break;
                case "3":
                    {
                        fromNum = 100;
                        toNum = 999;
                    }
                    break;
                case "4":
                    {
                        fromNum = 1000;
                        toNum = 9999;
                    }
                    break;
                case "5":
                    {
                        fromNum = 10000;
                        toNum = 99999;
                    }
                    break;
                case "6":
                    {
                        fromNum = 100000;
                        toNum = 999999;
                    }
                    break;
                case "7":
                    {
                        fromNum = 1000000;
                        toNum = 9999999;
                    }
                    break;
                case "8":
                    {
                        fromNum = 10000000;
                        toNum = 99999999;
                    }
                    break;
                case "9":
                    {
                        fromNum = 100000000;
                        toNum = 999999999;
                    }
                    break;
                default:
                    {
                        fromNum = 1;
                        toNum = 9;
                    }
                    break;
            }

            Random rnd = new Random();
            return  rnd.Next(fromNum, toNum);  // creates a number between fromNum and toNum
        }

//-----------------------------------------------------------------------------------------------

        private void viewDecBtn_Click(object sender, EventArgs e)
        {
            decLabel.Text = randomizedNum.ToString();
        }

//-----------------------------------------------------------------------------------------------

        private void viewBinBtn_Click(object sender, EventArgs e)
        {
            binLabel.Text = Convert.ToString(randomizedNum, 2);
        }

//-----------------------------------------------------------------------------------------------

        private void viewHexBtn_Click(object sender, EventArgs e)
        {
            hexLabel.Text = randomizedNum.ToString("X");
        }

//-----------------------------------------------------------------------------------------------

        private void resetLabels()
        {
            decLabel.Text = "Decimal Number";
            binLabel.Text = "Binary Number";
            hexLabel.Text = "Hexadecimal number";
        }
    }
}
