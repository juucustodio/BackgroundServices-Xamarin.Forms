using Foundation;
using Matcha.BackgroundService.iOS;
using UIKit;

namespace DemoBackground.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            BackgroundAggregator.Init(this);

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
