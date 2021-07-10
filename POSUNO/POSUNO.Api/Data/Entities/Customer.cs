using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSUNO.Api.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirtName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(200)]
        public string Adrress { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public User User { get; set; }
    }
}
