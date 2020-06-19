using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XO
{
  
    public partial class MainPage : ContentPage
    {
        private XOgame xo = new XOgame();
        public static Button[] buttons = new Button[9];

        public MainPage()
        {
            InitializeComponent();
            buttons[0] = b1;
            buttons[1] = b2;
            buttons[2] = b3;
            buttons[3] = b4;
            buttons[4] = b5;
            buttons[5] = b6;
            buttons[6] = b7;
            buttons[7] = b8;
            buttons[8] = b9;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            xo.setButton((Button)sender);
            if (xo.win(buttons) == true)
            {
                win_OR_lose.IsVisible = true;
                X_score.Text = xo.X.ToString();
                O_score.Text = xo.O.ToString();
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
                b5.IsEnabled = false;
                b6.IsEnabled = false;
                b7.IsEnabled = false;
                b8.IsEnabled = false;
                b9.IsEnabled = false;
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            xo.reset(buttons);
            win_OR_lose.IsVisible = false;
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
        }
    }
}
