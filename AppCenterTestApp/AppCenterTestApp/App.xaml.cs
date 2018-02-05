using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenterTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppCenterTestAppPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=f129a1c1-5879-400d-84a6-760b26ed2e44;" +
                            "ios=aa6177c9-4ad3-4524-8d6a-143f2bc6daa2",
                   typeof(Analytics), typeof(Crashes));

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
