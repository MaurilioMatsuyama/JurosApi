using JurosApi.Domain.Interfaces;
using JurosApi.Domain.ViewModels;
using System;

namespace JurosApis.Domain.Services
{
    public class JurosService : IJurosService
    {
        #region Api1

        public TaxaJurosViewModel TaxaJuros()
        {
            var vm = new TaxaJurosViewModel(taxaJuros: 0.01m);
            return vm;
        }

        #endregion

        #region Api2

        //API2
        public CalculoJurosViewModel CalculoJuros(decimal valorInicial, decimal meses)
        {
            var taxaJuros = TaxaJuros();

            //Validações em conversões iniciais
            if (!double.TryParse((1 + taxaJuros.TaxaJuros).ToString(), out double taxaJurosDouble))
                throw new Exception("Erro na conversão da taxa de juros");
            if (!double.TryParse(meses.ToString(), out double mesesDouble))
                throw new Exception("Erro na conversão dos meses");

            var calculoPotencia = Math.Pow(taxaJurosDouble, mesesDouble);

            //Valida conversão calculo potencia
            if (!decimal.TryParse(calculoPotencia.ToString(), out decimal calculoPotenciaDecimal))
            {
                throw new Exception("Erro na conversão do resultado do cálculo da potência");
            }

            var valorResultado = valorInicial * calculoPotenciaDecimal;

            //Valida conversão do resultado para decimal
            if (!decimal.TryParse(valorResultado.ToString("0.00"), out decimal valorResultadoTruncado))
            {
                throw new Exception("Erro na conversão do resultado final");
            }

            var vm = new CalculoJurosViewModel(resultadoFinal: valorResultadoTruncado);

            return vm;
        }
        //OBS: Dependendo da região...esse ToString("0.00") pode não funcionar...alguns países é separado por , então nesses casos deve ser ToString("0,00")

        public ShowMeTheCodeViewModel ShowMeTheCode()
        {
            var vm = new ShowMeTheCodeViewModel(urlCodigoFonte: "https://github.com/MaurilioMatsuyama/JurosApi");
            return vm;
        }

        #endregion
    }
}
