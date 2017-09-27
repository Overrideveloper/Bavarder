using Bavarder.Enums;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Bavarder.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Surname { get; set; }
        public string MidName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public Relationship Relationship { get; set; }
        public Country Country { get; set; }
        public byte[] UserPhoto { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("Bavarder")
        {
        }
    }
}