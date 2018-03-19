using System;
using System.Collections.Generic;
using System.Linq;
using CarouselView.FormsPlugin.iOS;
using Foundation;
using UIKit;

namespace KickassUI.FancyTutorial.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            CarouselViewRenderer.Init();

            LoadApplication(new App());

            UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

            return base.FinishedLaunching(app, options);
        }
    }
}
