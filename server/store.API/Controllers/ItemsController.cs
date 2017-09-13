using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Items.Services;
using Microsoft.AspNetCore.Mvc;

namespace store.API.Controllers
{
    [Route("[controller]")]
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _itemService.GetItems();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value2"
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
