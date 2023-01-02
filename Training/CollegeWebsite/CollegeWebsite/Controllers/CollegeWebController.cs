using Microsoft.AspNetCore.Mvc;
using CollegeWebsite.Data;
using CollegeWebsite.Entities;
using CollegeWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

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
			var courses = _dbContext.Courses.ToList();

			return Json(courses);
		}

		[HttpPost]
		public async Task<IActionResult> College(CollegeWebsiteViewModel model)
		{

			var College = new Admissions
			{
				Courses = model.Courses,
				Name = model.Name,
				Email = model.Email,
				PhoneNumberExtension = model.PhoneNumberExtension,
				PhoneNumber = model.PhoneNumber,
				City = model.City,
				State = model.State,
				Query = model.Query,
			};

			_dbContext.Admissions.Add(College);
			await _dbContext.SaveChangesAsync();
			return View(model);
		}
		public IActionResult College()
		{
			return View();
		}
	}
}
