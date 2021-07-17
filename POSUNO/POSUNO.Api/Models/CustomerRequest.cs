using System.ComponentModel.DataAnnotations;

namespace POSUNO.Api.Models
{
    public class CustomerRequest
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
    }
}
