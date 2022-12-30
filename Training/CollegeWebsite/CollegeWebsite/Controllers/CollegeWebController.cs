using Microsoft.AspNetCore.Mvc;
using CollegeWebsite.Data;
using CollegeWebsite.Entities;
using CollegeWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeWebsite.Controllers
{
	public class CollegeWebController : Controller
	{
		private readonly CollegeWebsiteDbContext _dbContext;

		public CollegeWebController(CollegeWebsiteDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		[HttpGet]
		public JsonResult Course()
		{
			var Cs = _dbContext.Courses.ToList();

			return Json(Cs);
		}
		public IActionResult College()
		{
			return View();
		}
	}
}
