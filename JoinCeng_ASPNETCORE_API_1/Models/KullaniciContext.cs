using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoinCeng_ASPNETCORE_API_1.Models
{
    public class KullaniciContext
        : DbContext
    {
        public DbSet<Kullanici> Kullanicis { get; set; }

        public KullaniciContext(DbContextOptions<KullaniciContext> options)
            : base(options)
        {
        }
    }
}
