using AutoMapper;
using Livraria.Aplicacao.DTO;
using Livraria.Aplicacao.Interfaces;
using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Aplicacao.Servicos
{
    public class LivroApp : ServicoAppBase<Livro, LivroDTO>, ILivroApp
    {
        public LivroApp(IMapper iMapper, ILivroServico servico)
            : base(iMapper, servico)
        {

        }
    }
}
