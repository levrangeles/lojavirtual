using AutoMapper;
using LojaVirtual.Domain;
using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Application.AutoMapper.Profiles
{
    public class LojaVirtualProfile : Profile
    {
        public LojaVirtualProfile()
        {
            this.CreateMap<ClienteDTO, Cliente>();
            this.CreateMap<Cliente, ClienteDTO>();

            this.CreateMap<PedidoDTO, Pedido>();
            this.CreateMap<Pedido, PedidoDTO>();

            this.CreateMap<ProdutoDTO, Produto>();
            this.CreateMap<Produto, ProdutoDTO>();
        }
    }
}
