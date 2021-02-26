using TesteGFT.Modelo;

namespace TesteGFT.Negocios
{
    class Negociar : INegociar
    {
        private static int NegociarID = 1;

        private string Nome;

        public double Valores { get; set; }
        public string Clientes { get; set; }
        public string Calculado { get; set; }

        public Negociar()
        {
            this.Nome = "Negociar " + NegociarID++;
        }

        public bool CalcularRisco(IRisco risco)
        {
            return risco.CalcularRisco(this);
        }

        public override string ToString()
        {
            return this.Nome;
        }

    }
}
