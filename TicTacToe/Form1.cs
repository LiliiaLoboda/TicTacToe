using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        string tic = "";
        Random xod = new Random();
        int [] a = new int[9];
        Button[] btn = new Button[9];

        public Form1()
        {
            InitializeComponent();

            if (xod.Next(1, 10) <= 5) { tic = "Крестики"; label1.Text = "Ходят крестики"; }
            else { tic = "nolik"; label1.Text = "Ходят нолики"; }

            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tic == "Крестики")
            {
                for(int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "X";
                        label1.Text = "Ходят нолики";
                        tic = "nolik";
                        btn[i].Enabled = false;
                        a[i] = 1;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "O";
                        label1.Text = "Ходят крестики";
                        tic = "Крестики";
                        btn[i].Enabled = false;
                        a[i] = 2;
                        break;
                    }
                }
            }
            // горизонталь 1
            if (a[0] == 1 && a[1] == 1 && a[2] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли крестики!";
            }
            // горизонталь 2
            else if (a[3] == 1 && a[4] == 1 && a[5] == 1) 
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли крестики!";
            }
            // горизонталь 3
            else if (a[6] == 1 && a[7] == 1 && a[8] == 1) 
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли крестики!";
            }
            // вертикаль 1
            else if (a[0] == 1 && a[3] == 1 && a[6] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли крестики!";
            }
            // вертикаль 2
            else if (a[1] == 1 && a[4] == 1 && a[7] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли крестики!";
            }
            // вертикаль 3
            else if (a[2] == 1 && a[5] == 1 && a[8] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли крестики!";
            }
            // диагональ 1
            else if (a[0] == 1 && a[4] == 1 && a[8] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли крестики!";
            }
            // диагональ 2
            else if (a[2] == 1 && a[4] == 1 && a[6] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли крестики!";
            }
            
            
            // горизонталь 1 нолики
            else if (a[0] == 2 && a[1] == 2 && a[2] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли нолики!";
            }
            // горизонталь 2 нолики
            else if (a[3] == 2 && a[4] == 2 && a[5] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли нолики!";
            }
            // горизонталь 3 нолики
            else if (a[6] == 2 && a[7] == 2 && a[8] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли нолики!";
            }
            // вертикаль 1 нолики
            else if (a[0] == 2 && a[3] == 2 && a[6] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли нолики!";
            }
            // вертикаль 2 нолики
            else if (a[1] == 2 && a[4] == 2 && a[7] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли нолики!";
            }
            // вертикаль 3 нолики
            else if (a[2] == 2 && a[5] == 2 && a[8] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли нолики!";
            }
            // диагональ 1 нолики 
            else if (a[0] == 2 && a[4] == 2 && a[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли нолики!";
            }
            // диагональ 2 нолики
            else if (a[2] == 2 && a[4] == 2 && a[6] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли нолики!";
            }
            else if (a[0]!=0 && a[1] != 0 && a[2] != 0 && a[3] != 0 && a[4] != 0 && a[5] != 0 && a[6] != 0 && a[7] != 0 && a[8] != 0)
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].BackColor = System.Drawing.Color.Green;
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победила дружба!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < btn.Length; i++)
            {
                a[i] = 0;
                btn[i].Text ="";

                if (xod.Next(1, 10) <= 5) { tic = "Крестики"; label1.Text = "Ходят крестики"; }
                else { tic = "nolik"; label1.Text = "Ходят нолики"; }

                btn[i].Enabled = true;
                btn[i].BackColor = System.Drawing.Color.White;
            }
        }
    }
}
