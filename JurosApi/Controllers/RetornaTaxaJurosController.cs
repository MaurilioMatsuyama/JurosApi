using JurosApi.Domain.Interfaces;
using JurosApi.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JurosApi.Controllers
{
    [ApiController]
    [Route("api1")]
    public class RetornaTaxaJurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;

        public RetornaTaxaJurosController(IJurosService jurosService)
        {
            _jurosService = jurosService;
        }

        [HttpGet("/taxaJuros")]
        public TaxaJurosViewModel RetornaTaxaJuros()
        {
            var vm = _jurosService.TaxaJuros();
            return vm;
        }
    }
}
