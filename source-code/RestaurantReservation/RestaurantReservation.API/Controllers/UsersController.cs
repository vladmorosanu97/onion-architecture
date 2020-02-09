using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Core.SharedKernel;
using RestaurantReservation.DomainServices.Common;
using RestaurantReservation.Infrastructure.RestaurantContext;

namespace RestaurantReservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepository<User> _restaurantRepository;

        public UsersController(IRepository<User> restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }


        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_restaurantRepository.GetAll());
        }
    }
}