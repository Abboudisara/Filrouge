using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DestisteApp.Models
{
    public class OperationModel
    {
        [Key]
        public int id_op { get; set; }
        [Required(ErrorMessage = "Ce champ Obligatoire")]
        [Display(Name = "Nom d'operation")]
        public string Operation { get; set; }

        [Required(ErrorMessage ="Ce Champ Obligatoire")]
        [Display(Name ="prix")]
        public float price { get; set; }

    }
}
