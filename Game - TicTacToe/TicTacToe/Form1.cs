using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author: Hamish Harrison December 13th 2019

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //variables
        char[,] place = new char[3, 3]; //game grid
        bool xTurn = true; //turn rotator
        char input = 'X'; // insert text into button
        int turnCount = 0; // cats game test
        int xWins = 0;
        int oWins = 0;
        int cats = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //updates the array and increments turncount
        private void inputArray(int x, int y, char player)
        {
            place[x, y] = player;
            turnCount++;
        }

        //tests all rows and columns, cats game, finishing turn
        private void testForWin()
        {
           for(int i = 0; i < 3; i++)
            {
                testHorizontal(i);
                
                if (pnlGamePanel.Enabled == true) //check to see if game is still active
                {
                    testVertical(i);
                } 
            }
           if(pnlGamePanel.Enabled == true) //check to see if game is still active
            {
                testCrissCross();
            }
            //tests for cats game
            if (turnCount == 9 && pnlGamePanel.Enabled == true)
            {
                lblGameResult.Text = "Cats Game!";
                cats++;
                lblCats.Text = cats.ToString();
                pnlGamePanel.Enabled = false;
            }
            //rotate turns
            else if (xTurn == true)
            {
                xTurn = false;
                lblPlayerTurn.Text = "It is O's Turn";
            }
            else
            {
                xTurn = true;
                lblPlayerTurn.Text = "It is X's Turn";
            }
        }

        //testing all horizontal lines
        private void testHorizontal(int x)
        {
            int xCount = 0;
            int oCount = 0;

            for (int i = 0; i < 3; i++)
            {
                if (place[i, x] == 'X')
                {
                    xCount += 1;
                }
                else if (place[i, x] == 'O')
                {
                    oCount += 1;
                }
                if (gameResult(xCount, oCount))
                {
                    pnlGamePanel.Enabled = false;
                }
            }
        }

        //testing all vertical lines
        private void testVertical(int x)
        {
            int xCount = 0;
            int oCount = 0;

            for (int i = 0; i < 3; i++)
            {
                if (place[x, i] == 'X')
                {
                    xCount += 1;
                }
                else if (place[x, i] == 'O')
                {
                    oCount += 1;
                }
                //Check win condition
                if (gameResult(xCount, oCount))
                {
                    pnlGamePanel.Enabled = false;
                }
            }
        }

        //testing criss crossing lines
                private void testCrissCross()
        {
            int xCount = 0;
            int oCount = 0;

            if(place[0,0] == 'X' && place[1,1] == 'X' && place[2,2] == 'X')
            {
                xCount = 3;
            }
            else if(place[0, 0] == 'O' && place[1, 1] == 'O' && place[2, 2] == 'O')
            {
                oCount = 3;
            }
            else if (place[2, 0] == 'X' && place[1, 1] == 'X' && place[0, 2] == 'X')
            {
                xCount = 3;
            }
            else if (place[2, 0] == 'O' && place[1, 1] == 'O' && place[0, 2] == 'O')
            {
                oCount = 3;
            }
            if (gameResult(xCount, oCount))
            {
                pnlGamePanel.Enabled = false;
            }
        }

        //tests win condition
        private bool gameResult(int x, int o)
        {
            if (x == 3)
            {
                lblGameResult.Text = "X Wins the game!";
                xWins++;
                lblXWins.Text = xWins.ToString();
                return true;
            }
            else if (o == 3)
            {
                lblGameResult.Text = "O Wins the game!";
                oWins++;
                lblOWins.Text = oWins.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        //reset the game
        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    place[i, y] = ' ';
                }
            }
            btn1.Text = " ";
            btn2.Text = " ";
            btn3.Text = " ";
            btn4.Text = " ";
            btn5.Text = " ";
            btn6.Text = " ";
            btn7.Text = " ";
            btn8.Text = " ";
            btn9.Text = " ";
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            xTurn = true;
            turnCount = 0;
            lblGameResult.Text = "";
            pnlGamePanel.Enabled = true;
        }

        //individual button clicks
        private void btn1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            if (xTurn == true)
            {
                input = 'X';
                btn1.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn1.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn1.Enabled = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 0;
            if (xTurn == true)
            {
                input = 'X';
                btn2.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn2.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 0;
            if (xTurn == true)
            {
                input = 'X';
                btn3.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn3.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 1;
            if (xTurn == true)
            {
                input = 'X';
                btn4.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn4.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            if (xTurn == true)
            {
                input = 'X';
                btn5.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn5.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 1;
            if (xTurn == true)
            {
                input = 'X';
                btn6.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn6.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 2;
            if (xTurn == true)
            {
                input = 'X';
                btn7.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn7.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 2;
            if (xTurn == true)
            {
                input = 'X';
                btn8.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn8.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 2;
            if (xTurn == true)
            {
                input = 'X';
                btn9.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            else
            {
                input = 'O';
                btn9.Text = input.ToString();
                inputArray(x, y, input);
                testForWin();
            }
            btn9.Enabled = false;
        }
    }
}
