using System.Collections.Generic;

namespace Cadastro.Core.Modelo.Dominio.Organizadores
{
    public interface IRepositorioOrganizador
    {
        void Adicionar(Organizador organizador);

        IEnumerable<Organizador> OrganizadoresAtivos();
    }
}