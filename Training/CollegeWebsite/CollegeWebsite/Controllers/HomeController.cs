using CollegeWebsite.Data;
using CollegeWebsite.Models;
using Microsoft.AspNetCore.Mvc;
namespace CollegeWebsite.Controllers
{
	public class HomeController : Controller
	{
		private readonly CollegeWebsiteDbContext _dbContext;

		public HomeController(CollegeWebsiteDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			var programmes = _dbContext.Programmes.Select(x => new ProgrammesModel
			{
				Description = x.Description,
				Title = x.Title,
				PictureUrl = x.PictureUrl,
				Url = x.Url
			}).ToList();
			return View(programmes);
		}

		[Route("programmes/{url}")]
		public IActionResult Programme(string url)
		{
			var programme = _dbContext.Programmes.FirstOrDefault(x => x.Url == url);

			var model = new ProgrammesModel
			{
                Title = programme.Title,
                Description = programme.Description,
				PictureUrl = programme.PictureUrl
			};
			return View(model);
		}

		[Route("programmes/engineering")]
		public IActionResult Engineering() { 
		      return View();
		}

        [Route("programmes/science")]
        public IActionResult Science()
        {
            return View();
        }

        [Route("programmes/management")]
        public IActionResult Management()
        {
            return View();
        }

        [Route("programmes/computer")]
        public IActionResult Computer()
        {
            return View();
        }

    }
}
