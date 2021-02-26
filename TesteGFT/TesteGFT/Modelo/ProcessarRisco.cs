using System;
using System.Collections.Generic;
using TesteGFT.Modelo;
using TesteGFT.Negocios;

namespace TesteGFT.Modelo
{
    class ProcessarRisco
    {
        //public enum CTipoRisco { LowRisk, MediumRisk, HighRisk }


        public static IRisco Create(TypeRisk risco)
        {
            return Create(risco.ToString());
        }

        public static IRisco Create(string risco)
        {
            switch (risco)
            {
                case "LowRisk":
                    return new BaixoRisco();
                case "MediumRisk":
                    return new MedioRisco();
                case "HighRisk":
                    return new AltoRisco();
                default:
                    throw new NotImplementedException();
            }
        }

       
    }

}
