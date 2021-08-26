using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace LojaJogos.Models
{
    public class Cliente
    {
        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string NomeCliente { get; set; }

        [Display(Name = "CPF do cliente")]
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", ErrorMessage = "CPF inválido!")]
        public string CPFCliente { get; set; }

        [Display(Name = "Data de nascimento do cliente")]
        [Required(ErrorMessage = "O campo Nascimento é obrigatório.")]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$", ErrorMessage = "Data inválida!")]
        public string NascCliente { get; set; }

        [Display(Name = "Endereço do cliente")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        public string EnderecoCliente { get; set; }

        [Display(Name = "Número de celular do cliente")]
        [Required(ErrorMessage = "O campo Número de celular é obrigatório.")]
        [RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Número inválido!")]
        public string CelCliente { get; set; }

        [Display(Name = "Email do cliente")]
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$", ErrorMessage = "Email inválido!")]
        public string EmailCliente { get; set; }
    }
}