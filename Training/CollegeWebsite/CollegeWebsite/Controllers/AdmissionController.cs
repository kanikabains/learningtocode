using CollegeWebsite.Data;
using CollegeWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeWebsite.Controllers
{
    public class AdmissionController : Controller
    {
            private readonly CollegeWebsiteDbContext _dbContext;

            public AdmissionController(CollegeWebsiteDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public IActionResult Create()
            {
                var admissions = _dbContext.Admissions.Select(x => new CollegeWebsiteViewModel
                {
                    Courses = x.Courses,
                    Name = x.Name,
                    Email = x.Email,
                    PhoneNumberExtension = x.PhoneNumberExtension,
                    PhoneNumber = x.PhoneNumber,
                    City = x.City,
                    State = x.State,
                    Query = x.Query,
                }).ToList();
                return View(admissions);
            }

            public IActionResult Index()
        {
            return View();
        }
    }
}
