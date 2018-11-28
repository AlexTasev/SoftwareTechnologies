using System.Linq;
using IMDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMDB.Controllers
{
    public class FilmController : Controller
    {
        private readonly IMDBDbContext dbContext;

        public FilmController(IMDBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var films = dbContext.Films.ToList();

            return View(films);
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Film film)
        {
            if (ModelState.IsValid)
            {
                dbContext.Films.Add(film);
                dbContext.SaveChanges();
                return Redirect("/");
            }

            return View();
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int? id)
        {
            var film = this.dbContext.Films.Find(id);
            return View(film);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Film film)
        {
            if (ModelState.IsValid)
            {
                dbContext.Films.Update(film);
                this.dbContext.SaveChanges();
                return Redirect("/");
            }

            return View(film);
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int? id)
        {
            var film = this.dbContext.Films.Find(id);
            return View(film);
        }

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult Delete(Film film)
        {
            this.dbContext.Films.Remove(film);
            this.dbContext.SaveChanges();
            return Redirect("/");
        }
    }
}