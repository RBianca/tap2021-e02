using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data
{
    public class DnaContext: DbContext
    {
        public DnaContext(DbContextOptions<DnaContext>options):base(options)
        {

        }
        public DbSet<Dna> Dnas { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
