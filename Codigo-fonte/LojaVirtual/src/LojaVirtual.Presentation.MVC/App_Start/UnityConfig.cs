using LojaVirtual.Application;
using LojaVirtual.Application.Interfaces;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Domain.Services;
using LojaVirtual.Domain.Services.Interfaces;
using LojaVirtual.Infra.Data;
using LojaVirtual.Infra.Data.Contexts;
using LojaVirtual.Infra.Data.Interfaces;
using System;

using Unity;
using Unity.Lifetime;

namespace LojaVirtual.Presentation.MVC
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IClienteRepository, ClienteRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProdutoRepository, ProdutoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPedidoRepository, PedidoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPessoaRepository, PessoaRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IClienteService, ClienteService>(new HierarchicalLifetimeManager());
            container.RegisterType<IProdutoService, ProdutoService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPedidoService, PedidoService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPessoaService, PessoaService>(new HierarchicalLifetimeManager());

            container.RegisterType<IPedidoApplication, PedidoApplication>(new HierarchicalLifetimeManager());
            container.RegisterType<IProdutoApplication, ProdutoApplication>(new HierarchicalLifetimeManager());
            container.RegisterType<IClienteApplication, ClienteApplication>(new HierarchicalLifetimeManager());

            container.RegisterType<IDatasourceContext, LojaVirtualContext>(new HierarchicalLifetimeManager());
        }
    }
}