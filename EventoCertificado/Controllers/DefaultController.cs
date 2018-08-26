using Cadastro.Cadastro.Core.Aplicacao.Organizadores;
using Microsoft.AspNetCore.Mvc;

namespace EventoCertificado.Controllers
{
    public class DefaultController: Controller
    {
        private readonly IServicoOrganizador _servicoOrganizador;

        public DefaultController(IServicoOrganizador servicoOrganizador)
        {
            _servicoOrganizador = servicoOrganizador;
        }

        // GET: Default
        public IActionResult Index()
        {
            return View();
        }
    }
}