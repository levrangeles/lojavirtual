using System.Collections.Generic;

namespace LojaVirtual.Domain
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
