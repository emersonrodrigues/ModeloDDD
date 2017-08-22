using PJDDD.Domain.Entities;
using PJDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJDDD.Domain.Interfaces.Repositories;

namespace PJDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>,IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> cliente)
        {
            return cliente.Where(c => c.ClienteEspecial(c));
        }
    }
}
