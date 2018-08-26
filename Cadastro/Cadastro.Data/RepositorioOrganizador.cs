using System.Collections.Generic;
using System.Linq;
using Cadastro.Core.Modelo.Dominio.Organizadores;

namespace Cadastro.Cadastro.Data
{
    public class RepositorioOrganizador : IRepositorioOrganizador
    {
        public void Adicionar(Organizador organizador)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Organizador> OrganizadoresAtivos()
        {
            return new List<Organizador>().AsQueryable().Where(EscopoOrganizador.TodosAtivos);
        }
    }
}