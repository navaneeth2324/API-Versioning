﻿using API_Versioning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.V2.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Item1", Description = "Updated Description1" },
            new Item { Id = 2, Name = "Item2", Description = "Updated Description2" }
        };

        // GET: api/v2/items
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems()
        {
            return items.Select(i => new Item { Id = i.Id, Name = i.Name, Description = "v2: " + i.Description }).ToList();
        }

        // GET: api/v2/items/1
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            item.Description = "v2: " + item.Description;
            return item;
        }

        // POST: api/v2/items
        [HttpPost]
        public ActionResult<Item> PostItem(Item item)
        {
            item.Id = items.Count + 1;
            items.Add(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        // PUT: api/v2/items/1
        [HttpPut("{id}")]
        public IActionResult PutItem(int id, Item item)
        {
            var existingItem = items.FirstOrDefault(i => i.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }

            existingItem.Name = item.Name;
            existingItem.Description = "v2: " + item.Description;

            return NoContent();
        }

        // DELETE: api/v2/items/1
        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            items.Remove(item);
            return NoContent();
        }
    }
}


