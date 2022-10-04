using System;
using Catalog1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog1.Repositories
{
    public interface IItemsRepository
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
         Task CreateItemAsync(Item item);

         Task UpdateItemAsync(Item item);

         Task DeleteItemAsync(Guid id);
    }
    

}