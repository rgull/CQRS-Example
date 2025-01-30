using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CQRS.Entity.Models;
namespace CQRS.DL.Context
{
    public class CQRSDBContext : DbContext
    {
        public CQRSDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
