using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackUpp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            try
            {
                // Look for existing account
                IEnumerable<IAccount> accounts = await App.AuthenticationClient.GetAccountsAsync();

                AuthenticationResult result = await App.AuthenticationClient
                    .AcquireTokenSilent(Constants.Scopes, accounts.FirstOrDefault())
                    .ExecuteAsync();

               
            }
            catch
            {
                // Do nothing - the user isn't logged in
            }
            base.OnAppearing();
        }
   


        async void login_Clicked(object sender, EventArgs e)
        {
            AuthenticationResult result;
            try
            {
                result = await App.AuthenticationClient
                    .AcquireTokenInteractive(Constants.Scopes)
                    .WithPrompt(Prompt.SelectAccount)
                    .WithParentActivityOrWindow(App.UIParent)
                    .ExecuteAsync();
                lab.Text = "touhemi bou fahja zaghret ay";
                await Navigation.PushAsync(new LoginPage(result));
            }
            catch (MsalException ex)
            {
                if (ex.Message != null && ex.Message.Contains("AADB2C90118"))
                {
                    //result = await OnForgotPassword();
                    // await Navigation.PushAsync(new LogoutPage(result));
                }
                else if (ex.ErrorCode != "authentication_canceled")
                {
                    await DisplayAlert("An error has occurred", "Exception message: " + ex.Message, "Dismiss");
                }
            }
        }
    }
}