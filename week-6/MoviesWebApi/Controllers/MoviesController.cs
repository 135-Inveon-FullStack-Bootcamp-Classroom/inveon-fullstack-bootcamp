using Microsoft.AspNetCore.Mvc;
using MoviesWebApi.Entities;
using System;
using System.Linq;

namespace MoviesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public MoviesController(ApplicationDbContext dbContext)
        {
            Console.WriteLine("MoviesController Constructor Method");
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            Console.WriteLine("GetMovies Method");

            var movies = _dbContext.Movies.ToList();

            return Ok(movies);

        }

        [HttpPost]
        public IActionResult SaveMovie([FromBody] Movie movie)
        {
            _dbContext.Movies.Add(movie);

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
