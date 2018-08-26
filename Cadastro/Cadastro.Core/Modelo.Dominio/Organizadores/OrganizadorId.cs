using System;

namespace Cadastro.Core.Modelo.Dominio.Organizadores
{
    public class OrganizadorId
    {
        public Guid Id { get; protected set; }
        public OrganizadorId()
        {
            Id = Guid.NewGuid();
        }

        public OrganizadorId(Guid id)
        {
            Id = id;
        }        
    }
}