using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LinkedLists.Models;
using LinkedLists.Views;
using SQLite;

namespace LinkedLists.Database
{
    class ListDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ListDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Item>().Wait();
        }

        public Task<List<Item>> GetItemsAsync()
        {
            return database.Table<Item>().ToListAsync();
        }

        public Task<List<Item>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Item>("SELECT * FROM [Item] WHERE [Done] = 0");
        }

        internal static Task SaveItemAsync(NewItemPage todoItem)
        {
            throw new NotImplementedException();
        }

        internal static Task DeleteItemAsync(NewItemPage todoItem)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetItemAsync(string id)
        {
            return database.Table<Item>().Where(i => i.ListId == id).FirstOrDefaultAsync();
        }

        /*
        public Task<string> SaveItemAsync(Item item)
        {
            item.ListId = int.Parse(item.ListId);

            if (item.ListId != 0)
            {

                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        */

        public Task<int> DeleteItemAsync(Item item)
        {
            return database.DeleteAsync(item);
        }

    }
}
