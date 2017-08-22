using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace PJDDD.MVC.ViewsModels
{
    public class ProdutoViewModel
    {
       [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "minimo {0} caracteres")]
        public string Nome { get; set; }
            [Required(ErrorMessage = "Preencha o campo Valor")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","99999999999")]
        public decimal valor { get; set; }
        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}