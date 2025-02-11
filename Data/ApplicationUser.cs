using Microsoft.AspNetCore.Identity;
using BlazorEFIdentity.Models;

namespace BlazorEFIdentity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Handle { get; set; }

        //public string userId { get; set; }

        //public string UserName {  get; set; } Behövs ej då det finns i IdentityUser klassen.

        //public string Password { get; set; } Behövs ej då det finns i IdentityUser klassen.

        public string? SocialSecurityNumber { get; set; }

        public List<Account> Accounts { get; set; }

        public string? Address { get; set; }

        //public string TelephoneNumber { get; set; } Behövs ej då det finns i IdentityUser klassen.

        //public string Email { get; set; }   Behövs ej då det finns i IdentityUser klassen.

        //public string Role { get; set; } Behövs ej för att vi har RoleManager

    }


}
