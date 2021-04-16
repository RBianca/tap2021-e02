using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Infrastructure
{
   public  interface IDna
    {
        List<Dna> GetAll();
        Dna GetById(Guid Id);
        void Insert(Dna dna);
        void Update(Dna dna);
        void Delete(Dna dna);
        void Save();
    }
}
