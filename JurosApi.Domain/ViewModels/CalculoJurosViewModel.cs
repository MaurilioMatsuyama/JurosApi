namespace JurosApi.Domain.ViewModels
{
    public class CalculoJurosViewModel
    {
        public decimal ResultadoFinal { get; private set; }

        public CalculoJurosViewModel(decimal resultadoFinal)
        {
            ResultadoFinal = resultadoFinal;
        }
    }
}
