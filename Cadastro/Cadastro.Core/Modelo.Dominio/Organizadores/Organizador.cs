using System;
using System.Collections.Generic;
using NucleoCompartilhado.Nucleo.Core;

namespace Cadastro.Core.Modelo.Dominio.Organizadores
{
    public class Organizador
    {        
        public OrganizadorId Id { get; private set; }
        public string Nome { get; set; }        
        public NomeCompleto Responsavel { get; private set; }
        public bool Ativo { get; private set; }

        public Organizador(OrganizadorId id)
        {
            Id = id;
        }        

        public override bool Equals(object obj)
        {
            Organizador organizador = obj as Organizador;
            return organizador != null &&
                   Id.Equals(organizador.Id) &&
                   Nome == organizador.Nome;
        }

        public override int GetHashCode()
        {
            var hashCode = -744223603;
            hashCode = hashCode * -1521134295 + EqualityComparer<OrganizadorId>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<NomeCompleto>.Default.GetHashCode(Responsavel);
            return hashCode;
        }
    }
}