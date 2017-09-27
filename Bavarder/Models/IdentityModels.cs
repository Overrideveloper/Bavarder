using Bavarder.Enums;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Bavarder.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Surname { get; set; }
        public virtual string MidName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public Relationship Relationship { get; set; }
        public Country Country { get; set; }
        public virtual string UserPhoto { get; set; }
        public virtual string Website { get; set; }
        public virtual string Bio { get; set; }
        public virtual string Twitter { get; set; }
        public virtual string Snapchat { get; set; }
        public virtual string PhoneNumber { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DOB { get; set; }
        public virtual bool EmailVisible { get; set; }
        public virtual bool PhoneVisible { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("Bavarder")
        {
        }
    }
}