using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuintaApp.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O id deve estar entre 1 a 200")]
        public int UsuId { get; set; }
        [Required(ErrorMessage = "O nome é obrigátorio")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 200 caracteres")]
        public string Obs { get; set; }
        [Required(ErrorMessage = "Informe a data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode = true)]
        public DateTime Nasc { get; set; }
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Digite um email valido")]
        public string Email { get; set; }
        [Required(ErrorMessage ="O login é obrigatorio")]
        [Remote("ValidaLogin","Usuario",ErrorMessage ="Este login já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatoria")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas são diferentes")]
        public string ConfirmarSenha { get; set; }

    }
}