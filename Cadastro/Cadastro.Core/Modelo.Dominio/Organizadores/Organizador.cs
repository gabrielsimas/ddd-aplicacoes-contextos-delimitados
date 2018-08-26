using System;
using System.Collections.Generic;

namespace Cadastro.Core.Modelo.Dominio.Organizadores
{
    public class Organizador
    {
        public Organizador(Guid id, string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }

        public override bool Equals(object obj)
        {
            Organizador organizador = obj as Organizador;
            return organizador != null &&
                   Id.Equals(organizador.Id) &&
                   Nome == organizador.Nome;
        }

        public override int GetHashCode()
        {
            int hashCode = -1643562096;
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            return hashCode;
        }
    }
}