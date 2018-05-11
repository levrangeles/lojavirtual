using System;
using System.Collections.Generic;

namespace LojaVirtual.Domain.Dto
{
    public class PedidoDTO : DTOBase
    {
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
        public int ProdutoId { get; set; }
        public IList<ProdutoDTO> Produtos { get; set; }
    }
}
