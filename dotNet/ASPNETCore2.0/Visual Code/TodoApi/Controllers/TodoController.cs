using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController:Controller
    {
        private readonly TodoContext _todoContext;
        public TodoController(TodoContext todoContext)
        {
            _todoContext=todoContext;
            if (!_todoContext.TodoItems.Any())
            {
                _todoContext.TodoItems.Add(new TodoItem{ Name="defaultItem"});
                _todoContext.SaveChanges();
            }
        }

        /// <summary>
        /// 获取所有TodoItem
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json( await _todoContext.TodoItems.ToListAsync());
        }

        /// <summary>
        /// 根据Id获取TodoItem
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}",Name="GetTodo")]
        public async Task<IActionResult> GetById(long id)
        {
            var item =await _todoContext.TodoItems.FirstOrDefaultAsync(o=>o.Id == id);

            if (item==null)
            {
                return NotFound();
            }

            return new ObjectResult(item);
        }

        /// <summary>
        /// 新增一个TodoItem
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create ([FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

           await _todoContext.TodoItems.AddAsync(item);
           await _todoContext.SaveChangesAsync();

           return CreatedAtRoute($"GetTodo",new {id = item.Id},item);
        }
    }
}