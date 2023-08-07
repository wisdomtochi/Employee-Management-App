using System.ComponentModel.DataAnnotations;

namespace EmploymentManagement.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
