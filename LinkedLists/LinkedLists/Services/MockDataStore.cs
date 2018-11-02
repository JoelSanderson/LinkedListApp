using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedLists.Models;

namespace LinkedLists.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { ListId = Guid.NewGuid().ToString(), ListTitle = "Camping Checklist", ListData="1. Tent"},
                new Item { ListId = Guid.NewGuid().ToString(), ListTitle = "Best Movies", ListData="list items" },
                new Item { ListId = Guid.NewGuid().ToString(), ListTitle = "Must Have Ingredients", ListData="list items" },
                new Item { ListId = Guid.NewGuid().ToString(), ListTitle = "Most Popular Sports", ListData="list items" }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.ListId == item.ListId).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.ListId == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.ListId == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

    }
}