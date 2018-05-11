using System;
using System.Collections.Generic;

namespace LojaVirtual.Domain
{
    public class Pedido : EntityBase
    {
        public Cliente Cliente { get; set; }
        public IList<Produto> Produtos { get; set; }
        public DateTime Data { get; set; }
    }
}
