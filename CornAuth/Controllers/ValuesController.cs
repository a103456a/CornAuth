using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace CornAuth.Controllers
{
    [Route("api/mongo")]
    public class MongoController : Controller
    {
        IMongoClient MongoDB;
        public MongoController(IMongoClient MongoDB)
        {
            this.MongoDB = MongoDB;
        }                     
        [HttpGet("")]
        [HttpGet("databases")]
        public async Task<IActionResult> Get()
        {
            var databases = await MongoDB.ListDatabasesAsync();
            var names = new List<string>();
            
            while (await databases.MoveNextAsync())
            {                   
                names.AddRange(databases.Current.Select(document => document.GetElement("name").Value.AsString));
            }

            return Json(names);
        }      
    }
}
