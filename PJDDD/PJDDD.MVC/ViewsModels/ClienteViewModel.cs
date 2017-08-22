using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace PJDDD.MVC.ViewsModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150,ErrorMessage ="Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "minimo {0} caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Sobre Nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "minimo {0} caracteres")]
        public string SobreNome { get; set; }
        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "minimo {0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha um E-mail valido!")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEquatable<ProdutoViewModel> Produtos { get; set; }
    }
}