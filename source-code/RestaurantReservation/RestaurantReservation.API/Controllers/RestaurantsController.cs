using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.Mappers;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Core.RestaurantContext;
using RestaurantReservation.Core.SharedKernel;
using RestaurantReservation.DomainServices.Common;
using RestaurantReservation.DomainServices.RestaurantContext;
using RestaurantReservation.Infrastructure.Utils;

namespace RestaurantReservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapperSession<Restaurant> _mapperSession;

        public RestaurantsController(IRestaurantRepository restaurantRepository, IMapperSession<Restaurant> mapperSession)
        {
            _restaurantRepository = restaurantRepository;
            _mapperSession = mapperSession;
        }


        [HttpGet]
        public IActionResult GetRestaurants()
        {
            var query = _restaurantRepository.GetAll();
            var items = query.ToList();
               
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetRestaurantById(int id)
        {
            var item = _restaurantRepository.GetById(id);

            return Ok(item);
        }

        [HttpPost]
        public IActionResult RegisterRestaurant([FromBody] RestaurantDto item)
        {
         
            _mapperSession.BeginTransaction();
            _restaurantRepository.Save(item.GetDataItem());

            _mapperSession.Commit();
            _mapperSession.CloseTransaction();
            // TODO: TRY CATCH OR USING

            return StatusCode(201);
        }
    }
}