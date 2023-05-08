using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAssignment2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAssignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
       
        [HttpGet("/{id}")]
        public IActionResult Get(int id)
        {
            var options = new DbContextOptionsBuilder<Database>().UseSqlServer("Data Source=DESKTOP-M74NI34;Initial Catalog=Reviews;integrated security=true;Trusted_Connection=true;TrustServerCertificate=True;").Options;
            var db_connection = new Database(options);
            var review = db_connection.Reviews.SingleOrDefault(i => i.ID.Equals(id));
            return Ok(review);
        }


        // PUT api/<ReviewsController>/5
        [HttpPut("/{product}/{name}/{feedback}")]
        public IActionResult Put(string product, string name, string feedback)
        {
            var options = new DbContextOptionsBuilder<Database>().UseSqlServer("Data Source=DESKTOP-M74NI34;Initial Catalog=Reviews;integrated security=true;Trusted_Connection=true;TrustServerCertificate=True;").Options;
            var db_connection = new Database(options);
            var review = new Reviews
            {
                Product = product,
                Name = name,
                Feedback = feedback
            };
            db_connection.Reviews.Add(review);
            db_connection.SaveChanges();
            return Ok(review);
        }

    }
}
