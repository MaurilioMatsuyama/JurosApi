using JurosApi.Domain.Interfaces;
using JurosApi.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JurosApi.Controllers
{
    [ApiController]
    [Route("api2")]
    public class CalculoTaxaJurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;

        public CalculoTaxaJurosController(IJurosService jurosService)
        {
            _jurosService = jurosService;
        }

        [HttpGet("/calculajuros")]
        public CalculoJurosViewModel CalculaJuros([FromQuery] decimal valorinicial, [FromQuery] int meses)
        {
            var vm = _jurosService.CalculoJuros(valorInicial: valorinicial, meses: meses);
            return vm;
        }


        [HttpGet("/showmethecode")]
        public TaxaJurosViewModel ShowMeTheCode()
        {
            var vm = _jurosService.TaxaJuros();
            return vm;
        }
    }
}
