using Microsoft.AspNetCore.Identity;

namespace EmploymentManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
