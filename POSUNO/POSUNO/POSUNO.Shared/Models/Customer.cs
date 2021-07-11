using System;
using System.Collections.Generic;
using System.Text;

namespace POSUNO.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adrress { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public User User { get; set; }
    }
}
