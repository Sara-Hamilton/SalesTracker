using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace SalesTracker.Models
{
    [Table("Users")]
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public string UserId { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public decimal Commission { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
