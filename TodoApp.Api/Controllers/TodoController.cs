using Microsoft.AspNetCore.Mvc;
using TodoApp.Domain.Models;
using TodoApp.Services.Interfaces;

namespace TodoApp.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet(nameof(GetTodo))]
        public IActionResult GetTodo(string id)
        {
            var result = _todoService.GetTodo(id);

            if(result is not null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet(nameof(GetAllTodo))]
        public IActionResult GetAllTodo()
        {
            var result = _todoService.GetAllTodos();

            if( result is not null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost(nameof(InsertTodo))]
        public IActionResult InsertTodo(Todo todo)
        {
            _todoService.InsertTodo(todo);
            return Ok("Todo inserted");
        }

        [HttpPut(nameof(Updatetodo))]
        public IActionResult Updatetodo(Todo todo)
        {
            _todoService.UpdateTodo(todo);
            return Ok("Updation Done");
        }
           
        [HttpDelete(nameof(DeleteTodo))]
        public IActionResult DeleteTodo(string id)
        {
            _todoService.DeleteTodo(id);
            return Ok("Todo Deleted");
        }




    }
}
