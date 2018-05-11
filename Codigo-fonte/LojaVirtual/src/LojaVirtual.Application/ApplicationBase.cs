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

        public virtual TDto Add(TDto obj)
        {
            var entity = Mapper.Map<T>(obj);
            return Mapper.Map<TDto>(Service.Add(entity));
        }

        public virtual IList<TDto> GetAll()
        {
            return Mapper.Map<IList<TDto>>(Service.GetAll());
        }

        public virtual TDto GetById(int id)
        {
            return Mapper.Map<TDto>(Service.GetById(id));
        }

        public virtual void Remove(TDto obj)
        {
            throw new System.NotImplementedException();
        }

        public virtual void RemoveBydId(int id)
        {
            Service.RemoveBydId(id);
        }

        public virtual TDto Update(TDto obj)
        {
            return Mapper.Map<TDto>(Service.Update(Mapper.Map<T>(obj)));
        }
    }
}
