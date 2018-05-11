using System.Collections.Generic;

namespace LojaVirtual.Domain
{
    public class Produto : EntityBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public IList<Pedido> Pedidos { get; set; }
    }
}
