using AKidsPage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKidsPage.Models
{
    public class Joke
    {
        public int JokeID { get; set; }
        private List<AppUser> users = new List<AppUser>();
        [RegularExpression("^[A-Z]+[a-zA-Z]*$")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 4)]
        [Required]
        public string KeyWord { get; set; }
        [RegularExpression("^[A-Z]+[a-zA-Z]*$")]
        [StringLength(50, MinimumLength = 2)]
        public string UserEmail { get; set; }

        public string Phone { get; set; }
        public string JokeLine { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PubDate { get; set; }

        public List<AppUser> Users { get { return users; } }

    }
}
