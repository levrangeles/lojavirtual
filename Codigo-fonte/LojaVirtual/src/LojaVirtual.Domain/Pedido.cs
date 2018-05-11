using System;
using System.Collections.Generic;

namespace LojaVirtual.Domain
{
    public class Pedido : EntityBase
    {
        public int ClienteId { get; set; }
        public IList<Produto> Produtos { get; set; }
    }
}
