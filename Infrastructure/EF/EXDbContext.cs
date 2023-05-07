using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Infrastructure.Entities;
using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.EF
{
    public class EXDbContext : DbContext
    {
        public EXDbContext(DbContextOptions<EXDbContext> options) : base(options)
        {
        }

        public DbSet<User> user { get; set; }
        public DbSet<SinhVien> sinhvien { get; set; }
    }
}
