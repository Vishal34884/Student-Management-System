using Microsoft.AspNetCore.Identity;

namespace StudentManagement.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
