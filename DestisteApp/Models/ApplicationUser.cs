using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DestisteApp.Models
{
    public class ApplicationUser: IdentityUser
    {
     
       
        public string Name{ get; set; }
        public string Fullname { get; set; }
        public virtual List<ReservationModel> Reservations { get; set; }
    }
}
