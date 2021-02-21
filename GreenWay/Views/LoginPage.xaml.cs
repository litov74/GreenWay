using GreenWay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            ActivitySpinner.IsVisible = false;
            LoginImage.HeightRequest = Constants.LoginIconHeight;
            usernameEntry.Completed += (s, e) => passwordEntry.Focus();
            passwordEntry.Completed += (s, e) => signInProcedure(s, e);
        }

        void signInProcedure(object sender, EventArgs e)
        {
            User user = new User(usernameEntry.Text, passwordEntry.Text);
            if (user.CheckUser())
            {
                DisplayAlert("Вход", "Вошли успешно!", "Ok");
                App.userDatabaseController.SaveUser(user);
            }
            else
            {
                DisplayAlert("Вход", "Не удается войти. Проверьте логин и пароль.", "Ok");
            }
        }
    }
}