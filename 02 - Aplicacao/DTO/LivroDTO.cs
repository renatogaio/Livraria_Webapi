using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Aplicacao.DTO
{
    public class LivroDTO : DTOBase
    {
        public string Titulo { get; set; }
        public int Exemplar { get; set; }
    }
}
