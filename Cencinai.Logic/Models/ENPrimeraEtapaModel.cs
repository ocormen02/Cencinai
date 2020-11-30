using Cencinai.Data.Models;

namespace Cencinai.Logic.Models
{
    public class ENPrimeraEtapaModel
    {
        public PesoEdad PesoEdad { get; set; } = new PesoEdad();

        public PesoTalla PesoTalla { get; set; } = new PesoTalla();

        public TallaEdad TallaEdad { get; set; } = new TallaEdad();
    }
}
