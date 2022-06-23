using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace eShopOnContainers.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.companyname.navigation2").StartApp();

            }

            return ConfigureApp.iOS.InstalledApp("com.companyname.navigation2").StartApp();
        }
    }
}