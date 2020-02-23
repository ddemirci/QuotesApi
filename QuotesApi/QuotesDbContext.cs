using Microsoft.EntityFrameworkCore;
using QuotesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApi
{
    public class QuotesDbContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }

        public QuotesDbContext(DbContextOptions<QuotesDbContext> options) : base(options)
        {

        }
    }
}
