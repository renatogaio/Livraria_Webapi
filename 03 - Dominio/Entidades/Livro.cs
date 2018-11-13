using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Dominio.Entidades
{
    public class Livro : EntidadeBase
    {
        public string Titulo { get; set; }
        public int Exemplar { get; set; }
    }
}
