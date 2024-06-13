using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZODIAKS.Data;
namespace ZODIAKS
{
    public partial class App : Application
    {

        static ZodiaksDB zodiaksDB;

        public static ZodiaksDB ZodiaksDB
        {
            get
            {
                if (zodiaksDB == null)
                {
                    zodiaksDB = new ZodiaksDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "ZodiaksDatabase.db3"));
                }
                return zodiaksDB;
            }
        }
       
        public App()
        {
            InitializeComponent();

            MainPage = new AppShel();
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
