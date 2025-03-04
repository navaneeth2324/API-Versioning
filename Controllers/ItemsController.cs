using API_Versioning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Item1", Description = "Description1" },
            new Item { Id = 2, Name = "Item2", Description = "Description2" }
        };

        // GET: api/items
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems()
        {
            return items;
        }

        // GET: api/items/1
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST: api/items
        [HttpPost]
        public ActionResult<Item> PostItem(Item item)
        {
            item.Id = items.Count + 1;
            items.Add(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        // PUT: api/items/1
        [HttpPut("{id}")]
        public IActionResult PutItem(int id, Item item)
        {
            var existingItem = items.FirstOrDefault(i => i.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }

            existingItem.Name = item.Name;
            existingItem.Description = item.Description;

            return NoContent();
        }

        // DELETE: api/items/1
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

