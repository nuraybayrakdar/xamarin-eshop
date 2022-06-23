using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace eShopOnContainers.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        static readonly Func<AppQuery, AppQuery> AppShellMenu = c => c.Marked("OK");
        static readonly Func<AppQuery, AppQuery> Anasayfa = c => c.Marked("AppShellAnasayfa");
        static readonly Func<AppQuery, AppQuery> KZKulaklik = c => c.Marked("AppShellKZKulaklik");
        static readonly Func<AppQuery, AppQuery> Kablolar = c => c.Marked("AppShellKablolar");
        static readonly Func<AppQuery, AppQuery> BizeUlasin = c => c.Marked("AppShellBizeUlasin");
        static readonly Func<AppQuery, AppQuery> Giris = c => c.Marked("AppShellGiris");
        static readonly Func<AppQuery, AppQuery> Hesap = c => c.Marked("AppShellHesap");

        static readonly Func<AppQuery, AppQuery> FacebookButon = c => c.Marked("FacebookButon");
        static readonly Func<AppQuery, AppQuery> TwitterButon = c => c.Marked("TwitterButon");
        static readonly Func<AppQuery, AppQuery> InstagramButon = c => c.Marked("InstagramButon");

        static readonly Func<AppQuery, AppQuery> CollectionViewItem = c => c.Marked("CollectionViewItem");

        static readonly Func<AppQuery, AppQuery> AnasayfaView = c => c.Marked("AnasayfaView");
        static readonly Func<AppQuery, AppQuery> KulaklikView = c => c.Marked("KulaklikView");
        static readonly Func<AppQuery, AppQuery> KablolarView = c => c.Marked("KablolarView");
        static readonly Func<AppQuery, AppQuery> IletisimView = c => c.Marked("IletisimView");
        static readonly Func<AppQuery, AppQuery> GirisView = c => c.Marked("GirisView");
        static readonly Func<AppQuery, AppQuery> HesapView = c => c.Marked("HesapView");

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        private void Check(Func<AppQuery, AppQuery> func, string error)
        {
            AppResult[] result = app.Query(func);
            Assert.IsTrue(result.Any(), error);
        }

        private void CheckProductPage(Func<AppQuery, AppQuery> page)
        {
            app.Tap(AppShellMenu);
            app.Tap(page);
            Check(FacebookButon, $"{nameof(page)} Sayfasında Facebook butonu bulunamadı");
            Check(InstagramButon, $"{nameof(page)} Sayfasında Instagram butonu bulunamadı");
            Check(TwitterButon, $"{nameof(page)} Sayfasında Twitter butonu bulunamadı");

            Check(CollectionViewItem, $"{nameof(page)} Sayfasında ürün bulunamadı");
        }


        [Test]
        public void AppLaunches()
        {
#if DEBUG
            //app.Repl();
#endif
            Check(AnasayfaView, "Uygulama anasayfa ile başlatılmadı");

            app.Tap(AppShellMenu);
            Check(Anasayfa, "Navigasyon menüsünde Anasayfa butonu bulunamadı");
            Check(KZKulaklik, "Navigasyon menüsünde KZ Kulaklık butonu bulunamadı");
            Check(Kablolar, "Navigasyon menüsünde Kablolar butonu bulunamadı");
            Check(BizeUlasin, "Navigasyon menüsünde Bize Ulaşın butonu bulunamadı");
            Check(Giris, "Navigasyon menüsünde Giriş Yap butonu bulunamadı");
        }

        [Test]
        public void SayfaTest()
        {
            CheckProductPage(Anasayfa);
            CheckProductPage(Kablolar);
            CheckProductPage(KZKulaklik);
        }

        [Test]
        public void GirisTest()
        {
            app.Tap(AppShellMenu);
            app.Tap(Giris);
            app.EnterText(x => x.Marked("LoginUsername"), "Admin");
            app.EnterText(x => x.Marked("LoginPassword"), "Password");
            app.Tap(x => x.Marked("LoginButon"));
            app.WaitForElement("AnasayfaView", "Giriş yapıldıktan sonra anasayfaya yönlendirilmedi", TimeSpan.FromSeconds(5f));
        }


    }
}
