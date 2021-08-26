using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace LojaJogos.Models
{
    public class Funcionario
    {
        [Display(Name = "Código do funcionário")]
        [Required(ErrorMessage = "O campo código é obrigatório.")]
        public string CodFuncionario { get; set; }

        [Display(Name = "Nome do funcionário")]
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string NomeFuncionario { get; set; }

        [Display(Name = "CPF do funcionário")]
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", ErrorMessage = "CPF inválido!")]
        public string CPFFuncionario { get; set; }

        [Display(Name = "RG do funcionário")]
        [Required(ErrorMessage = "O campo RG é obrigatório.")]
        [RegularExpression(@"(^\d{1,2}).(\d{3}).(\d{3})-(\d{1}|X|x$)", ErrorMessage = "RG inválido!")]
        public string RGFuncionario { get; set; }

        [Display(Name = "Data de nascimento do funcionário")]
        [Required(ErrorMessage = "O campo Nascimento é obrigatório.")]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$", ErrorMessage = "Data inválida!")]
        public string NascFuncionario { get; set; }

        [Display(Name = "Endereço do funcionário")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        public string EnderecoFuncionario { get; set; }

        [Display(Name = "Número de celular do funcionário")]
        [Required(ErrorMessage = "O campo Número de celular é obrigatório.")]
        [RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Número inválido!")]
        public string CelFuncionario { get; set; }

        [Display(Name = "Email do funcionário")]
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$", ErrorMessage = "Email inválido!")]
        public string EmailFuncionario { get; set; }

        [Display(Name = "Cargo do funcionário")]
        [Required(ErrorMessage = "O campo Cargo é obrigatório.")]
        public string CargoFuncionario { get; set; }
    }
}