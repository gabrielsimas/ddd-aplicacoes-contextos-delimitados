using Emissao.Core.Modelo.Dominio.Certificados;

namespace Emissao.Core.Aplicacao.Certificados
{
    public interface IServicoCertificados
    {
        Certificado EmitirCertificados(EventoId eventoId, string cpf);
    }
}