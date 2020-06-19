using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XO
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class welcomePage : ContentPage
    {
        public welcomePage()
        {
            InitializeComponent();
            stack2.IsVisible = false;
            back.IsVisible = false;
        }
       public static String stat;
        async void Button_Clicked(object sender, EventArgs e)
        {
            stat = "two player";
            await Navigation.PushAsync(new MainPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            OnBackButtonPressed();
           
        }
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () => {
                var result = await this.DisplayAlert("Alert!", "Do you really want to exit?", "Yes", "No");
                if (result) await this.Navigation.PopAsync();  // or anything else
            });

            return false;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            stat = "one player";
            stack1.IsVisible = false;
            stack2.IsVisible =true;
            back.IsVisible = true;
        }

        async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void back_Clicked(object sender, EventArgs e)
        {
            stack2.IsVisible = false;
            stack1.IsVisible = true;
            back.IsVisible =false;
        }

        
    }
    }

    

