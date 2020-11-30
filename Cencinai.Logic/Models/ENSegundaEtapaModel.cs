using System;
using System.Collections.Generic;
using System.Text;

namespace Cencinai.Logic.Models
{
    public class ENSegundaEtapaModel
    {
        public IndiceMasaCorporalModel IndiceMasaCorporal { get; set; } = new IndiceMasaCorporalModel();

        public TallaEdadModel TallaEdad { get; set; } = new TallaEdadModel();
    }
}
