using Microsoft.AspNetCore.Mvc;
using TodoApplication.Data;
using TodoApplication.Entities;
using TodoApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApplication.Controllers
{
	public class TodoController : Controller
	{
		private readonly TodoApplicationDbContext _dbContext;

		public TodoController(TodoApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpPost]
		public async Task<IActionResult> TodoApp(TodoAppViewModel model)
		{

			var Todo = new Todo
			{
				Title = model.Title,
				Description = model.Description,
				Check=model.Check,

			};

			_dbContext.Todo.Add(Todo);
			await _dbContext.SaveChangesAsync();
			return View(model);
		}

		[HttpGet]
		public IActionResult TodoApp()
		{
			return View();
		}
	}
}
