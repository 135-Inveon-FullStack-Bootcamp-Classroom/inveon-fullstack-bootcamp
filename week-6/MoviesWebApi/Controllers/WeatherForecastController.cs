﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("name")]
        public string GetName()
        {
            return "Murat";
        }

        [HttpPost("post-movies")]
        public IActionResult SaveMovie([FromBody] Movie movie, [FromQuery] string x)
        {
            return Ok(movie);
        }
    }
}
