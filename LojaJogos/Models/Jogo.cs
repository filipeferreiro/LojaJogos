using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace LojaJogos.Models
{
    public class Jogo
    {
        [Display(Name = "Código do jogo")]
        [Required(ErrorMessage = "O campo código é obrigatório.")]
        public string CodJogo { get; set; }

        [Display(Name = "Nome do jogo")]
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string NomeJogo { get; set; }

        [Display(Name = "Versão do jogo")]
        public string VersaoJogo { get; set; }

        [Display(Name = "Desenvolvedora do jogo")]
        [Required(ErrorMessage = "O campo desenvolvedora é obrigatório.")]
        public string DesJogo { get; set; }

        [Display(Name = "Gênero do jogo")]
        [Required(ErrorMessage = "O campo gênero é obrigatório.")]
        public string GeneroJogo { get; set; }

        [Display(Name = "Faixa etária do jogo")]
        [Required(ErrorMessage = "O campo faixa etária é obrigatório.")]
        [Range(0, 18, ErrorMessage = "Insira uma faixa entre 0 (livre) e 18")]
        public int EtariaJogo { get; set; }

        [Display(Name = "Plataforma do jogo")]
        [Required(ErrorMessage = "O campo plataforma é obrigatório.")]
        public string PlatJogo { get; set; }

        [Display(Name = "Ano do jogo")]
        [Required(ErrorMessage = "O campo ano de lançamento é obrigatório.")]
        [RegularExpression(@"(^[0-9]{4})")]
        public int AnoJogo { get; set; }

        [Display(Name = "Sinopse do jogo")]
        public string SinopseJogo { get; set; }
    }
}