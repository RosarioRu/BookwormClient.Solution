using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookwormClient.Models
{
    public class BookwormClientContext : IdentityDbContext<ApplicationUser>
    {
      // Don't change code in here.
    }
}