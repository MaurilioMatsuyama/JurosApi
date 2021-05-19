using JurosApi.Domain.Interfaces;
using JurosApi.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;

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
            try
            {
                var vm = _jurosService.CalculoJuros(valorInicial: valorinicial, meses: meses);
                return vm;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro no cálculo de juros. Erro interno: { ex.Message }");

            }
        }


        [HttpGet("/showmethecode")]
        public TaxaJurosViewModel ShowMeTheCode()
        {
            try
            {

                var vm = _jurosService.TaxaJuros();
                return vm;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao retornar o caminho do código fonte. Erro interno: { ex.Message }");
            }
        }
    }
}