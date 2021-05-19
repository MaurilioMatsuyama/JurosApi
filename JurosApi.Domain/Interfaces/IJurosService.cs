using JurosApi.Domain.ViewModels;

namespace JurosApi.Domain.Interfaces
{
    public interface IJurosService
    {
        TaxaJurosViewModel TaxaJuros();

        CalculoJurosViewModel CalculoJuros(decimal valorInicial, decimal meses);

        ShowMeTheCodeViewModel ShowMeTheCode();
    }
}
