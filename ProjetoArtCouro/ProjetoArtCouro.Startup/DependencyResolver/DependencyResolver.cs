using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Startup.DependencyResolver
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<DataBaseContext, DataBaseContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsuarioService, UsuarioService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsuarioRepository, UsuarioRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPermissaoRepository, PermissaoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IGrupoPermissaoRepository, GrupoPermissaoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IAutenticacao, AutenticacaoService>(new HierarchicalLifetimeManager());

            container.RegisterType<IPessoaService, PessoaService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPessoaRepository, PessoaRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPapelRepository, PapelRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPessoaFisicaRepository, PessoaFisicaRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPessoaJuridicaRepository, PessoaJuridicaRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IMeioComunicacaoRepository, MeioComunicacaoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IEnderecoRepository, EnderecoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IEstadoCivilRepository, EstadoCivilRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IEstadoRepository, EstadoRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IProdutoService, ProdutoService>(new HierarchicalLifetimeManager());
            container.RegisterType<IProdutoRepository, ProdutoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnidadeRepository, UnidadeRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<ICondicaoPagamentoService, CondicaoPagamentoService>(new HierarchicalLifetimeManager());
            container.RegisterType<IFormaPagamentoService, FormaPagamentoService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICondicaoPagamentoRepository, CondicaoPagamentoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IFormaPagamentoRepository, FormaPagamentoRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IVendaService, VendaService>(new HierarchicalLifetimeManager());
            container.RegisterType<IVendaRepository, VendaRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IItemVendaRepository, ItemVendaRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<ICompraService, CompraService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICompraRepository, CompraRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IItemCompraRepository, ItemCompraRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IContaReceberService, ContaReceberService>(new HierarchicalLifetimeManager());
            container.RegisterType<IContaReceberRepository, ContaReceberRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IContaPagarService, ContaPagarService>(new HierarchicalLifetimeManager());
            container.RegisterType<IContaPagarRepository, ContaPagarRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IEstoqueService, EstoqueService>(new HierarchicalLifetimeManager());
            container.RegisterType<IEstoqueRepository, EstoqueRepository>(new HierarchicalLifetimeManager());

            //container.RegisterType<User, User>(new HierarchicalLifetimeManager());
        }
    }
}
