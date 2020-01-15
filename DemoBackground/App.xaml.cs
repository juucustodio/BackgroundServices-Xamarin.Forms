using DemoBackground.Services;
using Matcha.BackgroundService;
using Xamarin.Forms;

namespace DemoBackground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.MainPage();
        }

        protected override void OnStart()
        {
            // Registra
            BackgroundAggregatorService.Add(() => new BackgroundService(15));

            // Inicia
            BackgroundAggregatorService.StartBackgroundService();
        }

        protected override void OnSleep()
        {
            // Para
            BackgroundAggregatorService.StopBackgroundService();
        }

        protected override void OnResume()
        {
            // Inicia Novamente
            BackgroundAggregatorService.StartBackgroundService();
        }

    }
}
