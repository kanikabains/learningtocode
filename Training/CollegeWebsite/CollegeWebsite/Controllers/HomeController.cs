using Microsoft.AspNetCore.Mvc;
using CollegeWebsite.Data;
using CollegeWebsite.Models;
using CollegeWebsite.Entities;
using Microsoft.EntityFrameworkCore;

namespace CollegeWebsite.Controllers
{
	public class HomeController : Controller
	{
		private readonly ProgrammesDbContext _dbContext;

		public HomeController(ProgrammesDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		[HttpGet]
		public JsonResult Programmes()
		{
			var Program = _dbContext.Programmes.ToList();

			return Json(Program);
		}


		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
	}
}
