﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJDDD.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal valor { get; set; }
        public bool Disponivel{ get; set; }
        public int  ClienteId{ get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
