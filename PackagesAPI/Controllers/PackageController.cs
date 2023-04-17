using FairyWeddingsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FairyWeddingsAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PackageController : ControllerBase
    {
        private readonly IPackagesService _packageService;

        public PackageController(IPackagesService packagesService)
        {
            _packageService = packagesService ?? throw new ArgumentNullException(nameof(packagesService));
        }

        /// <summary>
        /// Get all packages
        /// </summary>
        /// <returns>Return the package list</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_packageService.GetPackages());
        }

        /// <summary>
        /// Get the package by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the package with the selected ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _packageService.GetPackageById(id) != null ? Ok(_packageService.GetPackageById(id)) : NoContent();
        }

        /// <summary>
        /// Get the package by ID and get the Total to added services
        /// </summary>
        /// <param name="id"></param>
        /// <param name="calculateTotal"></param>
        /// <returns>Return the package updated Total</returns>
        [HttpGet("{id}/total")]
        public IActionResult GetPackageWithTotal(int id, bool calculateTotal)
        {
            if (calculateTotal)
            {
                return Ok(_packageService.CalculateGrossTotalForPackage(id));
            }
            else
            {
                return Ok(_packageService.GetPackageById(id));
            }
        }

        /// <summary>
        /// Add a package
        /// </summary>
        /// <param name="package"></param>
        /// <returns>Return the added package</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Packages packages)
        {
            return Ok(_packageService.AddPackage(packages));
        }

        /// <summary>
        /// Update the package
        /// </summary>
        /// <param name="package"></param>
        /// <returns>Return the updated package</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Packages packages)
        {
            return Ok(_packageService.UpdatePackage(packages));
        }

        /// <summary>
        /// Delete the selected package by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if deleted, False if not</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _packageService.DeletePackage(id);

            return result.HasValue & result == true ? Ok($"Package ID: {id} got deleted successfully.")
                : BadRequest($"Unable to delete the Package ID: {id}.");
        }

    }
}
