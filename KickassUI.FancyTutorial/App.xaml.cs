using FreshMvvm;
using Xamarin.Forms;

namespace KickassUI.FancyTutorial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var rootPage = FreshPageModelResolver.ResolvePageModel<PageModels.FancyTutorialPageModel>();
            MainPage = new FreshNavigationContainer(rootPage)
            {
                BarTextColor = Color.White
            };
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
    }
}
