using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoterKaasEieren
{
    public partial class Form1 : Form
    {
        private int Player, ButtonsLeft;
        private bool IsOver;
        System.Threading.Thread thd;
        public Form1()
        {
            InitializeComponent();
            thd = new System.Threading.Thread(music);
            this.ButtonsLeft = 9;
        }
        private void music()
        {
            for (int i = 37; i <= 32767; i++)
            {
                Console.Beep(i, 100);
            }
        }
        private void Reset()
        {
            this.ButtonsLeft = 9;
            thd.Abort();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = false;
            button10.Visible = false;

        }
        private void WinnerCheck()
        {

            if( button1.Text == "X" && button2.Text == "X" && button3.Text == "X"||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X"||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X"||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X"||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X"||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X"||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X"||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" )
            {
                MessageBox.Show("X Won");
                this.IsOver = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = true;
                button10.Visible = true;
                try
                {
                    thd.Start();
                }
                catch
                {
                }
            }


            if( button1.Text == "O" && button2.Text == "O" && button3.Text == "O"||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O"||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O"||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O"||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O"||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O"||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O"||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" )
            {
                MessageBox.Show("O Won");
                this.IsOver = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = true;
                button10.Visible = true;
                try
                {
                    thd.Start();
                }
                catch
                {
                }
            }

                
            //If No one won.
            if (ButtonsLeft <= 0 && !IsOver)
            {
                MessageBox.Show("It's a tie!");
                this.IsOver = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (Player == 0)
                {
                    this.button1.Text = "X";
                    this.button1.Enabled = false;
                    this.Player = 1;
                    this.ButtonsLeft--;
                }
                else if (Player == 1)
                {
                    this.button1.Text = "O";
                    this.button1.Enabled = false;
                    this.Player = 0;
                    this.ButtonsLeft--;
                }
                WinnerCheck();
            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Player == 0)
            {
                this.button2.Text = "X";
                this.button2.Enabled = false;
                this.Player = 1;
                this.ButtonsLeft--;
            }
            else if (Player == 1)
            {
                this.button2.Text = "O";
                this.button2.Enabled = false;
                this.Player = 0;
                this.ButtonsLeft--;
            }
            WinnerCheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Player == 0)
            {
                this.button3.Text = "X";
                this.button3.Enabled = false;
                this.Player = 1;
                this.ButtonsLeft--;
            }
            else if (Player == 1)
            {
                this.button3.Text = "O";
                this.button3.Enabled = false;
                this.Player = 0;
                this.ButtonsLeft--;
            }
            WinnerCheck();
        }    

        private void button4_Click(object sender, EventArgs e)
        {
            if (Player == 0)
            {
                this.button4.Text = "X";
                this.button4.Enabled = false;
                this.Player = 1;
                this.ButtonsLeft--;
            }
            else if (Player == 1)
            {
                this.button4.Text = "O";
                this.button4.Enabled = false;
                this.Player = 0;
                this.ButtonsLeft--;
            }
            WinnerCheck();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (Player == 0)
            {
                this.button5.Text = "X";
                this.button5.Enabled = false;
                this.Player = 1;
                this.ButtonsLeft--;
            }
            else if (Player == 1)
            {
                this.button5.Text = "O";
                this.button5.Enabled = false;
                this.Player = 0;
                this.ButtonsLeft--;
            }
            WinnerCheck();
        }
                
        private void button6_Click(object sender, EventArgs e)
        {
            if (Player == 0)
            {
                this.button6.Text = "X";
                this.button6.Enabled = false;
                this.Player = 1;
                this.ButtonsLeft--;
            }
            else if (Player == 1)
            {
                this.button6.Text = "O";
                this.button6.Enabled = false;
                this.Player = 0;
                this.ButtonsLeft--;
            }
            WinnerCheck();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Player == 0)
            {
                this.button7.Text = "X";
                this.button7.Enabled = false;
                this.Player = 1;
                this.ButtonsLeft--;
            }
            else if (Player == 1)
            {
                this.button7.Text = "O";
                this.button7.Enabled = false;
                this.Player = 0;
                this.ButtonsLeft--;
            }
            WinnerCheck();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Player == 0)
            {
                this.button8.Text = "X";
                this.button8.Enabled = false;
                this.Player = 1;
                this.ButtonsLeft--;
            }
            else if (Player == 1)
            {
                this.button8.Text = "O";
                this.button8.Enabled = false;
                this.Player = 0;
                this.ButtonsLeft--;
            }
            WinnerCheck();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Player == 0)
            {
                this.button9.Text = "X";
                this.button9.Enabled = false;
                this.Player = 1;
                this.ButtonsLeft--;
            }
            else if (Player == 1)
            {
                this.button9.Text = "O";
                this.button9.Enabled = false;
                this.Player = 0;
                this.ButtonsLeft--;
            }
            WinnerCheck();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
