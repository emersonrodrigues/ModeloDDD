using PJDDD.Application.Interfaces;
using PJDDD.Domain.Entities;
using PJDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJDDD.Application.Services
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string Nome)
        {
            return _produtoService.BuscarPorNome(Nome);
        }
    }
}
