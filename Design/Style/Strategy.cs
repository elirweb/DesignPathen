using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Style
{
    public interface Strategy
    {
        Guid NumeroPedido(); 
    }

    public class PedidoCompra : Strategy
    {
        // a interface stra
        public Guid NumeroPedido()
        {
            return Guid.NewGuid();
        }
    }

    public class PedidoSolicitacao : Strategy
    {
        public Guid NumeroPedido()
        {
            return Guid.NewGuid();
        }
    }
}
