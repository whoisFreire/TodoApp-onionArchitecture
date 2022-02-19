using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Models;

namespace TodoApp.Services.Interfaces
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAllTodos();
        Todo GetTodo(string id);
        void InsertTodo(Todo todo);
        void UpdateTodo(Todo todo);
        void DeleteTodo(string id);
    }
}
