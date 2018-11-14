using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Reddit
{
   public partial class App:Application
    {
        public App()
        {
            NavigationPage page = new NavigationPage(new MainPage());
            page.BackgroundColor = Color.White;
            page.BarBackgroundColor = Color.White;
            MainPage = page;
        }
    }
}
