
using Autofac;
using Dominio.Interfaces;
using Infra.Repositorio;
using Servico.Servicos;

namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {

            builder.RegisterType<PessoaRepositorio>().As<IRepositoryPessoa>();

            builder.RegisterType<PessoaServico>().As<IPessoaServico>();
            

        }
    }
}
