using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGFT.Negocios;

namespace TesteGFT.Modelo
{
    interface IRisco
    {
        string TipoRisco { get;  }
        bool CalcularRisco(INegociar negociar);
    }

    
}
