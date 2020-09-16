using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.DBContext;
using Microsoft.EntityFrameworkCore;
using shared.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("category")]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        StoreContext context;

        public CategoryController(StoreContext db)
        {
            context = db;
            context.Database.EnsureCreated();
        } 

        [HttpGet]
        [ResponseCache(Duration=60)]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return context.Categories;
        }

        [HttpGet("{id}")]
        public ActionResult<Category> Get(string id)
        {
            if(!Guid.TryParse(id, out var categoryId)) return BadRequest();

            var categoryFound = context.Categories.FirstOrDefault(p=> p.IdCategory == categoryId);

            if (categoryFound!= null)
                return Ok(categoryFound);
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] string value)
        {
            try   
            {
                if(!string.IsNullOrEmpty(value))
                { 
                    var category = new Category();
                    category.Description_Category = value;
                    context.Categories.Add(category);
                    await context.SaveChangesAsync();
                    return Ok();
                }  
               
               return BadRequest();

            }
            catch(Exception)
            {
                return BadRequest();
            }           
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] string value)
        {
             if(!Guid.TryParse(id, out var categoryId)) return BadRequest();

            var categoryFound = context.Categories.FirstOrDefault(p=> p.IdCategory == Guid.Parse(id));

            if (categoryFound!= null)
            {
                categoryFound.Description_Category = value;
                await context.SaveChangesAsync();
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if(!Guid.TryParse(id, out var categoryId)) return BadRequest();

            var categoryFound = context.Categories.FirstOrDefault(p=> p.IdCategory == Guid.Parse(id));

            if (categoryFound!= null)
            {
                context.Categories.Remove(categoryFound);
                await context.SaveChangesAsync();
                return Ok();
            }
            else
                return NotFound();
        }
    }
}