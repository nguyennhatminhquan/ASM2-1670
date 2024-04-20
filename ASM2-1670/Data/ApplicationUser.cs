using Microsoft.AspNetCore.Identity;

namespace ASM2_1670.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
        public string? AccountType { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
