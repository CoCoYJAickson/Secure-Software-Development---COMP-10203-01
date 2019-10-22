using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1B.Data
{
    public class ApplicationUser:IdentityUser
    {

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Position { get; set; }

        [Required]
        public string BirthDate { get; set; }
    }
}
