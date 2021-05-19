using JurosApi.Domain.Interfaces;
using JurosApi.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

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
            try
            {
                var vm = _jurosService.TaxaJuros();
                return vm;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao retornar a taxa de juros. Erro interno: {ex.Message}");
            }
        }
    }
}
