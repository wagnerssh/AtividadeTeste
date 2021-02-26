using TesteGFT.Negocios;

namespace TesteGFT.Modelo
{
    class AltoRisco : IRisco
    {
        //public string TipoRisco { get; }
        public string Tipo { get; private set; }

        public string TipoRisco { get; private set; }

        public string Calculado { get;  set; }

        public enum RiscoNulo { NONERISK }

        public enum TipoCliente { Private, Public }

        public bool CalcularRisco(INegociar negociar)
        {
            if (negociar.Valores > 1000000 && negociar.Clientes.Equals(TipoCliente.Private.ToString()))
            {
                this.Tipo = TypeRisk.HighRisk.ToString().ToUpper();
                if (Tipo != null) {
                    //negociar.Calculado.Equals(CalcRisco.ALTO_RISCO.ToString());
                    Calculado = "ALTO_RISCO";
                    negociar.Calculado = Calculado;
                }
                else
                {

                }

                return true;
            }

            //this.Tipo = RiscoNulo.NONERISK.ToString();
            Calculado = "Nunhum_Risco";
            negociar.Calculado = Calculado;

            return false;
        }
    }

    
}
