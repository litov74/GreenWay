﻿using GreenWay.Data;
using GreenWay.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWay
{
    public partial class App : Application
    {

        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public static UserDatabaseController userDatabaseController
        {
            get
            {
                if(userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }
        public static TokenDatabaseController tokenDatabaseController
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }
        }
    }
}
