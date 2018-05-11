using AutoMapper;
using LojaVirtual.Application.AutoMapper.Profiles;

namespace LojaVirtual.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new LojaVirtualProfile());
            });
        }
    }
}
