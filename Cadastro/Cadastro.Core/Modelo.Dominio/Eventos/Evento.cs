using System.Collections.Generic;
using System.Linq;
using Cadastro.Core.Modelo.Dominio.Organizadores;
using NucleoCompartilhado.Nucleo.Core;

namespace Cadastro.Core.Modelo.Dominio.Eventos
{
    /// <summary>
    /// Raiz Agregada para o Modelo de Dominio Evento
    /// OBS.: NÃO CONFUNDIR COM O PADRÃO DE EVENTOS DE DOMÍNIO OU DOMAIN EVENTS
    /// </summary>
    public class Evento
    {
        private List<Participante> _participantes;

        protected Evento()
        { }
        public Evento(EventoId eventoId, OrganizadorId organizadorId)
        {
            EventoId = eventoId;
            OrganizadorId = organizadorId;            

            _participantes = new List<Participante>();
        }

        public EventoId EventoId { get; private set; }
        public OrganizadorId OrganizadorId { get; private set; }
        public Periodo PeriodoEntregaCertificado { get; private set; }
        public string Nome { get; private set; }
        public IReadOnlyCollection<Participante> Participantes => _participantes.ToArray(); 

        public void AdicionarParticipante(Participante participante)
        {
            //TODO: Validar se o parâmetro está válido
            _participantes.Add(participante);
        }

        public void AtualizarListDeParticipantes(IEnumerable<Participante> participantes)
        {
            _participantes.Clear();
            _participantes.AddRange(participantes);
        }
    }
}