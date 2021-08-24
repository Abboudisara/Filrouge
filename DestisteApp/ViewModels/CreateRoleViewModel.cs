using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DestisteApp.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name ="Enter Role Name")]
        public string RoleName { get; set; }
    }
}
