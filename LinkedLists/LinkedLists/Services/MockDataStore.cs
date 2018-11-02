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
                new Item (Guid.NewGuid().ToString(), "Camping Checklist", ListType.Checklist, ListCategory.Outdoors, ListPrivacy.Private, "", 0, 0),
                new Item (Guid.NewGuid().ToString(), "Best Movies", ListType.BestOf, ListCategory.Entertainment, ListPrivacy.Private, "", 0, 0),
                new Item (Guid.NewGuid().ToString(), "Must Have Ingredients", ListType.Checklist, ListCategory.Food, ListPrivacy.Private, "", 0, 0),
                new Item (Guid.NewGuid().ToString(), "Most Popular Sports", ListType.BestOf, ListCategory.Sport, ListPrivacy.Private, "", 0, 0)
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
