using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Threading;
using System.Diagnostics;
namespace XO
{
    
    class XOgame
    {
     public int X = 0;
       public int O = 0;
        int state = 1;
        private int[,] winstate = new int[,]
        {
        {0,1,2 },
        {3,4,5 },
        {6,7,8 },
        {0,3,6 },
        {1,4,7 },
        {2,5,8 },
        {0,4,8 },
        {2,4,6 }
        };
       
       
        public bool win(Button[]buttons)
        {
            for(int i=0;i<8;i++)
            {
                int a = winstate[i, 0];
                int b = winstate[i, 1];
                int c = winstate[i, 2];
                Button but1 = buttons[a];
                Button but2 = buttons[b];
                Button but3 = buttons[c];
                //check fady
                if (but1.Text == "" || but2.Text == "" || but3.Text == "")
                    continue;

                if (but1.Text == but2.Text && but2.Text == but3.Text)
                {
                    but3.BackgroundColor = Color.Red;
                    but2.BackgroundColor = Color.White;
                    but1.BackgroundColor = Color.Aqua;
                    
                    if (but1.Text == "X")
                        X++;
                    else
                        O++;

                         return true;
                }
            }
            bool istie =true;
            for(int i=0;i<9;i++)
            {
                if (buttons[i].Text == "")
                    istie = false;
            }
           
                return istie;
        }
        public void reset(Button[]buttons)
        {
            state = 1;
            foreach(var b in buttons)
            {
                b.Text = "";
                b.BackgroundColor = Color.Gray;
            }
        }
        public void setButton(Button b)
        {
            if (welcomePage.stat == "two player")
            {
                if (b.Text == "")
                {
                    if (state == 1)
                    {
                        b.Text = "X";
                        b.BackgroundColor = Color.Blue;
                    }
                    else
                    {
                        b.Text = "O";
                        b.BackgroundColor = Color.Yellow;
                    }
                    state = 1 - state;
                }
            }
            else
            {
                Random random = new Random();
                 if (b.Text == "")
                {
                    if (state == 1)
                    {
                        b.Text = "X";
                        b.BackgroundColor = Color.Blue;
                        state = 0;
                    }
                   
                }
                for (int i = 0; i < 9; i++)
                {
                    int x = random.Next(1, 9);
                    if (MainPage.buttons[x].Text == "")
                    {
                        MainPage.buttons[x].Text = "O";
                        MainPage.buttons[x].BackgroundColor = Color.Yellow;
                        state = 1;
                        break;
                    }
                }
            }
        }

    }
}
