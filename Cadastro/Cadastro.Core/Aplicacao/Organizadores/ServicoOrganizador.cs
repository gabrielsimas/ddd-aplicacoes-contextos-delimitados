using Cadastro.Core.Modelo.Dominio.Organizadores;

namespace Cadastro.Cadastro.Core.Aplicacao.Organizadores
{
    public class ServicosOrganizador : IServicoOrganizador
    {
        private readonly IRepositorioOrganizador _repositorio;

        public ServicosOrganizador(IRepositorioOrganizador repositorio) =>  _repositorio = repositorio;

        public void CadastrarNovoOrganizador(Organizador organizador) => _repositorio.Adicionar(organizador);
        
    }
}