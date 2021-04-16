using RepositoryPattern.Models;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.Data
{
    public class DbSet<T>
    {
        internal void Remove(Dna dna)
        {
            throw new NotImplementedException();
        }

        internal List<Dna> ToList()
        {
            throw new NotImplementedException();
        }

        internal object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal void Add(Dna dna)
        {
            throw new NotImplementedException();
        }

        internal void Update(Dna dna)
        {
            throw new NotImplementedException();
        }
    }
}