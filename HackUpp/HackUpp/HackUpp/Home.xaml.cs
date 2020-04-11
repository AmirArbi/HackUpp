using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackUpp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        bool green = false;
        bool red = false;
        public Home()
        {
            InitializeComponent();
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!green)
            {
                (sender as Xamarin.Forms.Button).TextColor = Color.Green;
                green = true;
            } else
            {
                (sender as Xamarin.Forms.Button).TextColor = Color.Black;
                green = false;
            }
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!red)
            {
                (sender as Xamarin.Forms.Button).TextColor = Color.Red;
                red = true;
            }
            else
            {
                (sender as Xamarin.Forms.Button).TextColor = Color.Black;
                red = false;
            }
        }
    }
}