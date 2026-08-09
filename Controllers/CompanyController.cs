using Accounting.Api.Models;
using Accounting.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyService _companyService;
        public CompanyController(CompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_companyService.GetAll());
        }
    }
}