using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tasalia.Intranet.Web.Data
{
    public class TasaliaCredentialsContext : IdentityDbContext
    {
        public TasaliaCredentialsContext(DbContextOptions<TasaliaCredentialsContext> options)
            : base(options)
        {
        }
    }
}
