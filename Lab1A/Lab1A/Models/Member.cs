using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1A.Models
{
    public class Member
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Position { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string BirthDate { get; set; }
    }
}
