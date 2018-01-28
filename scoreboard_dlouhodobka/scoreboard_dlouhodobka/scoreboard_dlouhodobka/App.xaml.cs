using scoreboard_dlouhodobka.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace scoreboard_dlouhodobka
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new scoreboard_dlouhodobka.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        private static Database _data;

        public static Database Data
        {
            get
            {
                if (_data == null)
                {
                    _data = new Database(DependencyService.Get<IFileHelper>().GetLocalFilePath("scoreboard.db3"));

                }
                return _data;
            }
        }
    }
}
