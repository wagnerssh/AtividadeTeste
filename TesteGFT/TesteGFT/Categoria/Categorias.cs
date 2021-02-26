
using System.Collections.Generic;
using TesteGFT.Modelo;
using TesteGFT.Negocios;

namespace TesteGFT.Categoria
{
    class Categorias
    {
        //private List<INegociar> portfolio;
        public enum TipoRisco { LowRisk, MediumRisk, HighRisk }

        readonly List<INegociar> port = new List<INegociar>();

        public Categorias(List<INegociar> port) {
            this.port = port;
        }

        public List<string> GetCategorias()
        {
            IRisco risco = null;

            List<string> tradeCategories = new List<string>();

            List<IRisco> irisco = new List<IRisco> {
                ProcessarRisco.Create(TypeRisk.LowRisk),
                ProcessarRisco.Create(TypeRisk.MediumRisk),
                ProcessarRisco.Create(TypeRisk.HighRisk)
            };

            foreach (Negociar Negociar in port)
            {
                foreach (IRisco r in irisco)
                {
                    risco = r;

                    if (Negociar.CalcularRisco(r))
                    {
                        break;
                    }
                }

                tradeCategories.Add(risco.TipoRisco);
            }

            return tradeCategories;
        }
    }

    
}
