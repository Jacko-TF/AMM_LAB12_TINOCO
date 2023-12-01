using AMM_LAB12_TINOCO.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AMM_LAB12_TINOCO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TaskView();
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
    }
}
