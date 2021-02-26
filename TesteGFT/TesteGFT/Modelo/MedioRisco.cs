using TesteGFT.Modelo;
using TesteGFT.Negocios;

namespace TesteGFT.Modelo
{
    class MedioRisco : IRisco
    {
        public string Tipo { get; private set; }
        public string TipoRisco { get; private set; }
        public string Calculado { get; set; }
        public enum RiscoNulo { NONERISK }
        public enum ITipoRisco { LowRisk, MediumRisk, HighRisk }
        public enum TipoCliente { Private, Public }

        public bool CalcularRisco(INegociar negocio)
        {
            if (negocio.Valores > 1000000 && negocio.Clientes.Equals(TipoCliente.Public.ToString()))
            {
                this.Tipo = TypeRisk.MediumRisk.ToString().ToUpper();
                if (Tipo != null)
                {
                    //negocio.Calculado.Equals(CalcRisco.MEDIO_RISCO.ToString());
                    Calculado = "MEDIO_RISCO";
                    negocio.Calculado = Calculado;
                }


                return true;
            }

            //this.Tipo = RiscoNulo.NONERISK.ToString();
            Calculado = "Nunhum_Risco";
            negocio.Calculado = Calculado;

            return false;
        }
    }
}
