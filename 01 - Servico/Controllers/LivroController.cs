using Livraria.Aplicacao.DTO;
using Livraria.Aplicacao.Interfaces;
using Livraria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Servico.Api.Controllers
{
    public class LivroController : ControllerBase<Livro, LivroDTO>
    {
        public LivroController(ILivroApp app)
            : base(app)
        { }
    }
}
