using AutoMapper;
using LojaVirtual.Application.Interfaces;
using LojaVirtual.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace LojaVirtual.Application
{
    public class ApplicationBase<T, TDto> : IApplicationBase<T, TDto>
        where T : class
        where TDto : class
    {
        IServiceBase<T> Service;
        private IClienteService service;

        public ApplicationBase(IServiceBase<T> service)
        {
            Service = service;
        }

        public TDto Add(TDto obj)
        {
            var entity = Mapper.Map<T>(obj);
            return Mapper.Map<TDto>(Service.Add(entity));
        }

        public IList<TDto> GetAll()
        {
            return Mapper.Map<IList<TDto>>(Service.GetAll());
        }

        public TDto GetById(int id)
        {
            return Mapper.Map<TDto>(Service.GetById(id));
        }

        public void Remove(TDto obj)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveBydId(int id)
        {
            Service.RemoveBydId(id);
        }

        public TDto Update(TDto obj)
        {
            return Mapper.Map<TDto>(Service.Update(Mapper.Map<T>(obj)));
        }
    }
}
