using System;
using System.Linq.Expressions;

namespace Cadastro.Core.Modelo.Dominio.Organizadores
{
    public class EscopoOrganizador
    {
        public static Expression<Func<Organizador,bool>> TodosAtivos => x => x.Ativo == true;
    }
}