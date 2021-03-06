﻿using PJDDD.Domain.Entities;
using PJDDD.Domain.Interfaces.Repositories;
using PJDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService

    { private readonly IProdutoRepository _produtoRepository;
          public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string Nome)
        {
            return _produtoRepository.BuscarPorNome(Nome);
        }
    }
}
