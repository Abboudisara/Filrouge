using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DestisteApp.Models
{
    public class ReservationModel
    {
        [Key]
        public int id{ get; set; }
        [Required]
        public DateTime dateTme { get; set; }

         [Required(ErrorMessage = "Svp choisir un Type Reservation ")]
        public int operationid { get; set; }

        [ForeignKey(nameof(operationid))]
        public OperationModel operations{ get; set; }

        public string User_id { get; set; }

        [ForeignKey("User_id")]
        public ApplicationUser User { get; set; }
        public string Confirmation { get; set; }

    }
}
