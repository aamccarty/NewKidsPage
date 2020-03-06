using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKidsPage.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }

        //public string UserEmail { get; set; }

        //public string Phone { get; set; }

    }
}