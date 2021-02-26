using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGFT.Negocios
{
    interface INegociar
    {
        double Valores { get; }
        string Clientes { get; }
        string Calculado { get; set; }
    }
   
}
