﻿using PJDDD.Domain.Entities;
using PJDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJDDD.Infra.Data.Repositories
{
    public class ClienteRepository :RepositoryBase<Cliente> ,IClienteRepository
    {
    }
}
