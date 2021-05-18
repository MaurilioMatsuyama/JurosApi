using System;
using System.Collections.Generic;
using System.Text;

namespace JurosApi.Domain.ViewModels
{
    public class TaxaJurosViewModel
    {
        public decimal TaxaJuros { get; private set; }

        public TaxaJurosViewModel(decimal taxaJuros)
        {
            TaxaJuros = taxaJuros;
        }
    }
}
