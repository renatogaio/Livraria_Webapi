using AutoMapper;
using Livraria.Aplicacao.DTO;
using Livraria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Livro, LivroDTO>();
            CreateMap<LivroDTO, Livro>();
        }
    }
}
