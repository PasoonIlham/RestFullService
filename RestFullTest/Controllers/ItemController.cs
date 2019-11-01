using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

namespace RestFullTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private static readonly List<Item> Items = new List<Item>() 
        {
            new Item(1, "bread", "low", 33),
            new Item(2, "Alex", "year", 23),
            new Item(3, "Dennis", "year", 26),
            new Item(4, "Abed", "year", 25)
        };
        // GET: api/Item
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return Items;
        }

        // GET: api/Item/5
        [HttpGet("{id}", Name = "Get")]
        public Item Get(int id)
        {
            return Items.Find(i =>i.ID ==id);
        }


        // POST: api/Item
        [HttpPost]
        public void Post([FromBody] Item value)
        {
            Items.Add(value);
        }


        // PUT: api/Item/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item value)
        {
            Item item = Get(id);
            if (item != null)
            {
                item.ID = value.ID;
                item.Name = value.Name;
                item.Quality = value.Quality;
                item.Quantity = value.Quantity;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Item item = Get(id);
            Items.Remove(item); 
        }
    }
}
