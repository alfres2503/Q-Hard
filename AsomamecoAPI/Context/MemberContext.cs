using AsomamecoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AsomamecoAPI.Context
{
    public class MemberContext: DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options): base(options)
        {
        }
        public DbSet<Member> Members { get; set; }
    }
}
