namespace JurosApi.Domain.ViewModels
{
    public class ShowMeTheCodeViewModel
    {
        public string UrlCodigoFonte { get; private set; }

        public ShowMeTheCodeViewModel(string urlCodigoFonte)
        {
            UrlCodigoFonte = urlCodigoFonte;
        }
    }
}
