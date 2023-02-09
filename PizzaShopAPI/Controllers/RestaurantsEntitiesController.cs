using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaShopAPI.Data;
using PizzaShopAPI.Entities;

namespace PizzaShopAPI.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class RestaurantsEntitiesController : Controller
    {
       

        RestaurantContext _context= new RestaurantContext();

        [HttpGet]
        public async Task<IActionResult> Restaurants()
        {
            var restaurants = _context.Restaurants
                .ToList()
                .Select(p => new
                {
                    p.name,
                    p.id,
                    distance = (395 * Math.Acos((Math.Cos(radians(40.93183287042033)) *
                    Math.Cos(radians(p.lat)) * Math.Cos(radians(p.lng) - radians(29.147347272335548))) + Math.Sin(radians(40.93183287042033)) * Math.Sin(radians(p.lat))))
                })
                .Where(d => d.distance < 10)
                .OrderBy(d => d.distance).Take(5);
            return Ok(restaurants);
        }

        private double radians(double v)
        {
            return (Math.PI / 180) * v;
        }

        // default koordinat olarak maltepe huzur evi 40.93183287042033, 29.147347272335548 alindi.


       
    }
}
