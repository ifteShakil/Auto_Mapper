using System.ComponentModel.DataAnnotations;

namespace AutoMapperCore.Models
{
    public class EmpVM
    {

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [Compare("Email")]
        public string EmailConfirm { get; set; }



        public string Country { get; set; }
    }
}
