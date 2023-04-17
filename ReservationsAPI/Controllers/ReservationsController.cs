using Microsoft.AspNetCore.Mvc;
using FairyWeddingsAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FairyWeddings.Reservations.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationsService _reservationsService;

        public ReservationsController(IReservationsService reservationsService)
        {
            _reservationsService = reservationsService ?? throw new ArgumentNullException(nameof(reservationsService));
        }

        /// <summary>
        /// Get all reservations
        /// </summary>
        /// <returns>Return the reservation list</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_reservationsService.GetReservations());
        }

        /// <summary>
        /// Get the reservation by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the reservation with the selected ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _reservationsService.GetReservations(id) != null ? Ok(_reservationsService.GetReservations(id)) : NoContent();
        }

        /// <summary>
        /// Add a reservation
        /// </summary>
        /// <param name="reservations"></param>
        /// <returns>Return the added reservation</returns>
        [HttpPost]
        public IActionResult Post([FromBody] FairyWeddingsAPI.Models.Reservations reservations)
        {
            return Ok(_reservationsService.AddReservations(reservations));
        }

        /// <summary>
        /// Update the reservation
        /// </summary>
        /// <param name="reservations"></param>
        /// <returns>Return the updated reservation</returns>
        [HttpPut]
        public IActionResult Put([FromBody] FairyWeddingsAPI.Models.Reservations reservations)
        {
            return Ok(_reservationsService.UpdateReservations(reservations));
        }

        /// <summary>
        /// Delete the selected reservation by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _reservationsService.DeleteReservations(id);

            return result.HasValue & result == true ? Ok($"Reservation ID: {id} got deleted successfully.")
                : BadRequest($"Unable to delete the reservation ID: {id}.");
        }
    }
}
