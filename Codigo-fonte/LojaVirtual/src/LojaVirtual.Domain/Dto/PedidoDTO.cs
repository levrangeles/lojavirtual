using System;
using System.Collections.Generic;

namespace LojaVirtual.Domain.Dto
{
    public class PedidoDTO : DTOBase
    {
        public int ClienteId { get; set; }
        public IList<ProdutoDTO> Produtos { get; set; }
        public DateTime Data { get; set; }
    }
}
