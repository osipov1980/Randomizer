using System;
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

        //-----------create new object------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomNum num = new RandomNum();
        }


        //-----------startBtn_Click---------------------------------------------------------------------

        private void startBtn_Click(object sender, EventArgs e)
        {
            resetLabels();
            int[] numSize = selectNumSize();
            RandomNum num = new RandomNum();
            int randomizedNum = num.GenerateRandomNumber(numSize);


            decLabel.Text = randomizedNum.ToString();
            //decLabel.Text = numSize[0].ToString();
        }


        //This function clean the lables from previous data

        private void resetLabels()
        {
            decLabel.Text = "Decimal Number";
            binLabel.Text = "Binary Number";
            hexLabel.Text = "Hexadecimal number";
        }


        //-----------------------------------------------------------------------------------------------

        private int[] selectNumSize()
        {
            int fromNum = 0;
            int toNum = 0;
            
            switch (digitComboBox.Text)
            {
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
            }
            int[] range = new int[2] { fromNum, toNum };
            return range;
        }


        //-----------View Decimal Number---------------------------------------------------------

        private void viewDecBtn_Click(object sender, EventArgs e)
        {
            decLabel.Text = randomizedNum.ToString();
        }


        //------------View Binary Number---------------------------------------------------------

        private void viewBinBtn_Click(object sender, EventArgs e)
        {
            string str = Convert.ToString(randomizedNum, 2);  //convert from decimal to binary and to string

            str = addZeros(str);
            str = addSpaces(str);
 
            binLabel.Text = str;
        }

        //------------Add missing zeros to Binary Number from left---------------------------------------

        private string addZeros(string strSource)
        {
            string str = strSource;
            int strLen = str.Length;

            while((strLen % 4) != 0)
            {
                strLen = strLen + 1;
                char pad = '0';
                str = str.PadLeft(strLen, pad);  //add to str zeros from left and save to newStr
            }
            return str;
        }


       //------------Add spaces between every 4 digits---------------------------------------

        private string addSpaces(string strSource)
        {
            string str = strSource;
            int strLen = str.Length;

            if(str.Length == 4)
            {
                return str;
            }

            string newStr = "";

            for (int i = 4; i < str.Length; i += 5)
            {
                newStr = str.Insert(i, " ");
                str = newStr;
            }

            return newStr;
        }


        //-------------View Hexadecimal Number-----------------------------------------------------------

        private void viewHexBtn_Click(object sender, EventArgs e)
        {
            hexLabel.Text = randomizedNum.ToString("X");
        }

    }
}
