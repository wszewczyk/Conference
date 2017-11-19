using System;
using Conf.Core.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Conf.Database
{
    public class ConfContext : DbContext
    {
        public ConfContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Conference> Conferences { get; set; }
    }
}
