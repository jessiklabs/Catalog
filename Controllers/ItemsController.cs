using Microsoft.AspNetCore.Mvc;
using Catalog1.Repositories;
using System.Collections.Generic;
using Catalog1.Entities;
namespace Catalog1.Controllers
{
    //GET /items
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController()
        {
            repository = new InMemItemsRepository();
        }
        //GET /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {

        }
    }
}