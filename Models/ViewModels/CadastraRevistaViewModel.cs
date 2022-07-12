using Arthes_2022.Models.Entities;

using System.ComponentModel.DataAnnotations;

namespace Arthes_2022.Models.ViewModels
{
    public class CadastraRevistaViewModel
    {
        [Display(Name = "Tema:")]
        public string? Tema { get; set; }

        [Display(Name = "Número da Edição:")]
        public int NumeroEdicao { get; set; }

        [Display(Name = "Mês de Edição:")]
        public Mes MesEdicao { get; set; }

        [Display(Name = "Ano da Edição:")]
        public int AnoEdicao { get; set; }

        [Display(Name = "Foto de Capa:")]
        public string? Foto { get; set; }
    }
}
