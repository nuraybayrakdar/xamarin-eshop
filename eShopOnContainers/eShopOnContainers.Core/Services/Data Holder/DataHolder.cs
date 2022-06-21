using eShopOnContainers.Core.Models.Catalog;
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.FirebaseManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.DataHolder
{
    public static class DataHolder
    {

        public static ObservableCollection<Product> Products { get; set; }
        public static ObservableCollection<Product> FilteredList { get; set; }

        //public static ObservableCollection<Product> GetProductsByCategory(string category)
        //{
        //    ObservableCollection<Product> filteredList = new ObservableCollection<Product>();
        //    foreach (Product product in Products)
        //    {
        //        if (product.Category == category)
        //        {
        //            filteredList.Add(product);
        //        }
        //    }
        //    return filteredList;
        //}

        public static async void GetProductsByCategory(string category)
        {
            FilteredList = new ObservableCollection<Product>();
            var productsByCategory = await DatabaseManager.DatabaseManager.GetProductByCategory(category);
            foreach (Product product in productsByCategory)
            {
                FilteredList.Add(product);
            }
        }

        public static async void GetProductsByName(string name)
        {
            FilteredList = new ObservableCollection<Product>();
            var productsByName = await  DatabaseManager.DatabaseManager.GetProductByName(name);
            foreach (Product product in productsByName)
            {
                FilteredList.Add(product);
            }

        }


        private static async void CheckDatabase()
        {
            var databaseItems = await DatabaseManager.DatabaseManager.GetProduct();
            foreach (var databaseItem in databaseItems)
            {
                foreach (var product in Products)
                {
                    if (product.Name == databaseItem.Name)
                    {
                        return;
                    }
                    Products.Add(databaseItem);
                }
            }
        }

        static DataHolder()
        {
            Products = new ObservableCollection<Product>();
            //Ürün eklemeleri
            {
                Products.Add(new Product
                {
                    Name = "KZ ZSN Pro 1BA+1DD Hibrit Kulaklýk",
                    Model = "KZ ZSN Pro",
                    Category = "kulaklýk",
                    Image = "KZ_ZSN_Pro",
                    Views = 5,
                    NoDiscount = 229.9f,
                    Price = 189.9f,
                    Description = "KZ ZSN Pro 1BA+1DD Dengeli Armatür ve" +
                      "Dinamik Sürücü Hibrit, HD Mikrofonlu," +
                       " Gürültü Azaltýcý Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZS10 Pro 4BA+1DD Hibrit Kulaklýk",
                    Model = "KZ ZS10 Pro",
                    Category = "kulaklýk",
                    Image = "KZ_ZS10_Pro",
                    Views = 5,
                    NoDiscount = 519.9f,
                    Price = 399.9f,
                    Description = "KZ ZS10 Pro 4BA+1DD 4 Dengeli Armatür ve" +
                    " 1 Dinamik Sürücü Hibrit, HD Mikrofonlu," +
                    " Gürültü Azaltýcý Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZSX Terminator 5BA+1DD Hibrit Kulaklýk",
                    Model = "KZ ZSX",
                    Category = "kulaklýk",
                    Image = "KZ_ZSX",
                    Views = 5,
                    NoDiscount = 579.9f,
                    Price = 439.9f,
                    Description = "KZ ZSX Terminator 5BA+1DD 5 Dengeli Armatür ve" +
                    " 1 Dinamik Sürücü Hibrit, HD Mikrofonlu," +
                    " Gürültü Azaltýcý Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZST Pro 1BA+1DD Hibrit Kulaklýk",
                    Model = "KZ ZST Pro",
                    Category = "kulaklýk",
                    Image = "KZ_ZST_Pro",
                    Views = 5,
                    NoDiscount = 229.9f,
                    Price = 189.9f,
                    Description = "KZ ZST Pro 1BA+1DD Dengeli Armatür ve" +
                    " Dinamik Sürücü Hibrit Yüksek Bas Özellikli," +
                    " HD Mikrofonlu, Gürültü Azaltýcý Kulakiçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZSN Pro X 1BA+1DD Gümüþ Kablolu Kulaklýk",
                    Model = "KZ ZSN Pro X",
                    Category = "kulaklýk",
                    Image = "KZ_ZSN_Pro_X",
                    Views = 5,
                    NoDiscount = 229.9f,
                    Price = 199.9f,
                    Description = "KZ ZSN Pro X 10mm Dinamik bas sürücü ve" +
                    " 30095 BA Denge Armatürü Hibrit Yüksek Bas," +
                    " Gümüþ Kablolu Kulakiçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZS3 1DD Yüksek Bass Kulaklýk",
                    Model = "KZ ZS3",
                    Category = "kulaklýk",
                    Image = "KZ_ZS3",
                    Views = 5,
                    NoDiscount = 149.9f,
                    Price = 109.9f,
                    Description = "KZ ZS3 1DD Dinamik Sürücü, HiFi Yüksek Bass," +
                    " HD Mikrofonlu, Gürültü Azaltýcý Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "QKZ VK4 Dinamik Sürücü Kulak Ýçi Kulaklýk",
                    Model = "QKZ VK4",
                    Category = "kulaklýk",
                    Image = "QKZ_VK4",
                    Views = 5,
                    NoDiscount = 169.9f,
                    Price = 129.9f,
                    Description = "QKZ VK4 1DD Güçlü Dinamik Sürücü, HiFi Yüksek Bass, Mikrofonlu Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ES4 1BA+1DD Kulak Ýçi Kulaklýk",
                    Model = "KZ_ES4",
                    Category = "kulaklýk",
                    Image = "KZ_ES4",
                    Views = 5,
                    NoDiscount = 219.9f,
                    Price = 179.9f,
                    Description = "KZ ES4 1BA+1DD Dengeli Armatür ve Dinamik Sürücü Hibrit, HD Mikrofonlu, Gürültü Azaltýcý Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZST X 1BA+1DD Gümüþ Kablolu Kulaklýk",
                    Model = "KZ ZST X",
                    Category = "kulaklýk",
                    Image = "KZ_ZST_X",
                    Views = 5,
                    NoDiscount = 229.9f,
                    Price = 209.9f,
                    Description = "KZ ZSTX 1BA+1DD Denge Armatür ve XUN Dinamik Sürücü Hibrit Yüksek Bas, Gümüþ Kablolu Kulakiçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ATR 1DD Dinamik Sürücü Bas Kulaklýk",
                    Model = "KZ ATR",
                    Category = "kulaklýk",
                    Image = "KZ_ATR",
                    Views = 5,
                    NoDiscount = 129.9f,
                    Price = 89.9f,
                    Description = "KZ ATR 1DD Dinamik Sürücü, HiFi Yüksek Bas, HD Mikrofonlu, Gürültü Azaltýcý Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ EDX 1DD Mikrofonlu Kulak Ýçi Kulaklýk",
                    Model = "KZ EDX",
                    Category = "kulaklýk",
                    Image = "KZ_EDX",
                    Views = 5,
                    NoDiscount = 159.9f,
                    Price = 109.9f,
                    Description = "KZ EDX Kompozit 1DD Dinamik Sürücü, HiFi Yüksek Bass, Mikrofonlu, Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ED12 1DD Dinamik Sürücü Bas Kulaklýk",
                    Model = "KZ ED12",
                    Category = "kulaklýk",
                    Image = "KZ_ED12",
                    Views = 5,
                    NoDiscount = 139.9f,
                    Price = 119.9f,
                    Description = "KZ ED12 1DD Dinamik Sürücü, HiFi Yüksek Bas, HD Mikrofonlu, Gürültü Azaltýcý Kulakiçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZAX 7BA+1DD Hibrit Kulak Ýçi Kulaklýk",
                    Model = "KZ ZAX",
                    Category = "kulaklýk",
                    Image = "KZ_ZAX",
                    Views = 5,
                    NoDiscount = 699.9f,
                    Price = 689.9f,
                    Description = "KZ ZAX 7 adet BA Denge Armatürü ve 10mm çift manyetik dinamik bas sürücü, Gümüþ Kablolu Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ DQ6 3DD 3 Dinamik Sürücü Kulak Ýçi Kulaklýk",
                    Model = "KZ DQ6",
                    Category = "kulaklýk",
                    Image = "KZ_DQ6",
                    Views = 5,
                    NoDiscount = 259.9f,
                    Price = 239.9f,
                    Description = "KZ DQ6 3DD 3 Adet Dinamik Sürücü Gümüþ Kablolu Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "QKZ AK6 Yüksek Bas Mikrofonlu Kulak Ýçi Kulaklýk",
                    Model = "QKZ AK6",
                    Category = "kulaklýk",
                    Image = "QKZ_AK6",
                    Views = 5,
                    NoDiscount = 99.9f,
                    Price = 79.9f,
                    Description = "QKZ AK6 1DD Dinamik Sürücü, HiFi Yüksek Bas, Mikrofonlu Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ASF 5BA Denge Armatürlü Kulak Ýçi Kulaklýk",
                    Model = "KZ ASF",
                    Category = "kulaklýk",
                    Image = "KZ_ASF",
                    Views = 5,
                    NoDiscount = 499.9f,
                    Price = 469.9f,
                    Description = "KZ ASF 5BA 5 adet Denge Armatür Sürücü Gümüþ Kablolu Kulak Ýçi Kulaklýk"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZSN, ZSN Pro, ZS10 Pro, ZSX, AS16, AS12, ASF, ASX, DQ6 Yedek Kablo",
                    Model = "KZ C",
                    Category = "kablo",
                    Image = "KZ_C",
                    Views = 0,
                    NoDiscount = 74.9f,
                    Price = 65.9f,
                    Description = "KZ Pin C Kablo. KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
                    " AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu orijinal yedek kulaklýk kablosu."
                });

                Products.Add(new Product
                {
                    Name = "KZ ZST ZST Pro AS10 BA10 ES3 ES4 ZS10 AS06 ZSR Yedek Kablo",
                    Model = "KZ B",
                    Category = "kablo",
                    Image = "KZ_B",
                    Views = 0,
                    NoDiscount = 74.9f,
                    Price = 54.9f,
                    Description = "KZ Pin B Kablo. ZST, ZST Pro, ZST X, AS10, BA10, ZS10(pro deðil)," +
                    " AS06, ES4, ED12, EDX, ZSR, ES3 modelleri ile uyumlu orijinal yedek kulaklýk kablosu."
                });

                Products.Add(new Product
                {
                    Name = "KZ Altýn+Gümüþ Kablo ZSN, ZSN Pro, ZS10 Pro, ZSX, ZAX, AS16, AS12, ASF, ASX, DQ6",
                    Model = "ALTIN GUMUS C",
                    Category = "kablo",
                    Image = "ALTIN_GUMUS_C",
                    Views = 0,
                    NoDiscount = 149.9f,
                    Price = 114.9f,
                    Description = "KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
                    " ZAX, AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu Pin C altýn+gümüþ" +
                    " yükseltme kablosu."
                });


                Products.Add(new Product
                {
                    Name = "KZ Gümüþ Kablo ZSN, ZSN Pro, ZS10 Pro, ZSX, ZAX, AS16, AS12, ASF, ASX, DQ6",
                    Model = "GUMUS C",
                    Category = "kablo",
                    Image = "GUMUS_C",
                    Views = 5,
                    NoDiscount = 99.9f,
                    Price = 89.9f,
                    Description = "KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
            " ZAX, AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu Pin C gümüþ yükseltme kablosu"
                });
                Products.Add(new Product
                {
                    Name = "KZ ZS3 ZS4 ZS5 ZS6 ZS7 ZSA ED16 Yedek Kablo",
                    Model = "KZ A",
                    Category = "kablo",
                    Image = "KZ_A",
                    Views = 5,
                    NoDiscount = 74.9f,
                    Price = 64.9f,
                    Description = "KZ Pin A Kablo. ZS3, ZS4, ZS5, ZS6, ZS7, ZSA, " +
                "ED16 modelleri ile uyumlu orijinal yedek kulaklýk kablosu."
                });
                Products.Add(new Product
                {
                    Name = "KZ Gümüþ Kablo ZST, ZST Pro, AS10, BA10, ES3, ES4, ZS10, AS06, ZSR",
                    Model = "GUMUS B",
                    Category = "kablo",
                    Image = "GUMUS_B",
                    Views = 5,
                    NoDiscount = 99.9f,
                    Price = 89.9f,
                    Description = "KZ ZST, ZST Pro, ZST X, AS10, BA10, ZS10(pro deðil), AS06, " +
                "ES4, ED12, EDX, ZSR, ES3 modelleri ile uyumlu Pin B gümüþ yükseltme kablosu."
                });

                Products.Add(new Product
                {
                    Name = "KZ Altýn+Gümüþ Kablo ZST, ZST Pro, AS10, BA10, ES3, ES4, ZS10, AS06, ZSR",
                    Model = "ALTIN GUMUS B",
                    Category = "kablo",
                    Image = "ALTIN_GUMUS_B",
                    Views = 5,
                    NoDiscount = 149.9f,
                    Price = 114.9f,
                    Description = "KZ ZST, ZST Pro, ZST X, AS10, BA10, ZS10 (pro deðil), AS06, ES4, ED12, EDX, " +
                "ZSR, ES3 modelleri ile uyumlu Pin B altýn+gümüþ yükseltme kablosu."
                });
                Products.Add(new Product
                {
                    Name = "KZ Gümüþ Kablo ZS3 ZS4 ZS5 ZS6 ZS7 ZSA ED16",
                    Model = "GUMUS A",
                    Category = "kablo",
                    Image = "GUMUS_A",
                    Views = 5,
                    NoDiscount = 109.9f,
                    Price = 89.9f,
                    Description = "KZ ZS3, KZ ZS4, KZ ZS5, KZ ZS6, KZ ZS7, KZ ZS3E, KZ ZSA, KZ" +
                " ED16 modelleri ile uyumlu Pin A gümüþ yükseltme kablosu."
                });
            }
        }



    }
}