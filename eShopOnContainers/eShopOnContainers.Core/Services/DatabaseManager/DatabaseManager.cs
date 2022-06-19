using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using eShopOnContainers.Core.Models;
using System.Collections.ObjectModel;

namespace eShopOnContainers.Core.Services.FirebaseManager
{
    public static class DatabaseManager
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");
            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Account>();
            await db.CreateTableAsync<Product>();
            await AddValues();

        }

        private static async Task AddValues()
        {
            await db.DeleteAllAsync<Product>();
            if (await db.Table<Account>().CountAsync() == 0)
            {
                foreach (var item in AccountManager.Accounts)
                {
                    await AddAccount(item);
                }
            }
            if (await db.Table<Product>().CountAsync() == 0)
            {
                foreach (var item in DataHolder.Products)
                {
                    await AddProduct(item);
                }
            }
        }

        public static async Task AddAccount(Account accountToInsert)
        {
            await Init();

            var accounts = await db.Table<Account>().ToListAsync();
            foreach (Account account in accounts)
            {
                if (account.Username == accountToInsert.Username && account.Password == accountToInsert.Password)
                    return;
            }
            await db.InsertAsync(accountToInsert);
        }

        public static async Task<IEnumerable<Account>> GetAccount()
        {
            await Init();

            var accounts = await db.Table<Account>().ToListAsync();
            if (accounts.Count == 0)
                return null;
            return accounts;
        }

        public static async Task AddProduct(Product productToInsert)
        {
            await Init();

            var products = await db.Table<Product>().ToListAsync();
            foreach (Product product in products)
            {
                if (product.Name == productToInsert.Name)
                    return;
            }
            await db.InsertAsync(productToInsert);
        }

        public static async Task<IEnumerable<Product>> GetProduct()
        {
            await Init();

            var products = await db.Table<Product>().ToListAsync();
            if (products.Count == 0)
                return null;
            return products;
        }

        public static async Task<IEnumerable<Product>> GetProductByCategory(string category)
        {
            await Init();

            var products = await db.Table<Product>().Where(c => c.Category.ToLower() == category.ToLower()).ToArrayAsync();
            return products;
        }
        public static async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            await Init();
            name = name.Trim();
            var products = await db.Table<Product>().Where(n => n.Name.ToLower().Contains(name.ToLower())).ToArrayAsync();
            return products;
        }

    }
}
