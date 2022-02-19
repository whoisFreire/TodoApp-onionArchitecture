using System.Collections.Generic;
using TodoApp.Domain.Models;
using TodoApp.Infrastructure.Repositories.Interfaces;
using TodoApp.Services.Interfaces;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly IRepositoryBase<Todo> _repository;

        public TodoService(IRepositoryBase<Todo> repository)
        {
            _repository = repository;
        }


        public void DeleteTodo(string id)
        {
            var todo = _repository.Get(id);
            _repository.Delete(todo);
            _repository.SaveChanges();
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _repository.GetAll();
        }

        public Todo GetTodo(string id)
        {
            return _repository.Get(id);
        }

        public void InsertTodo(Todo todo)
        {
            _repository.Insert(todo);
        }

        public void UpdateTodo(Todo todo)
        {
            _repository.Update(todo);
        }
    }
}
