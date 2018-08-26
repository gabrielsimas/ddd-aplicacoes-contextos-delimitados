using System;

namespace Cadastro.Core.Modelo.Dominio.Eventos
{
    public class Periodo
    {
        public Periodo(DateTime dataInicial, int diasValidos)
        {
            DataInicial = dataInicial;
            DataFinal = DataInicial.AddDays(diasValidos);
        }

        public Periodo(DateTime dataInicial, DateTime dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }

        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }
    }
}