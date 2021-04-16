using RepositoryPattern.Data;
using RepositoryPattern.Infrastructure;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Services
{
    public class DnaRepo : IDna
    {
        private DnaContext _context;

        public DnaRepo(DnaContext context)
        {
            _context = context;
        }

        public void Delete(Dna dna)
        {
            _context.Dnas.Remove(dna);
        }

        public List<Dna> GetAll()
        {
            return _context.Dnas.ToList();
        }

        public Dna GetById(Guid Id)
        {
            //return _context.Dnas.Where(x => x.Id == Id).FirstOrDefault();
            throw new NotImplementedException();
        }

        public void Insert(Dna dna)
        {
            _context.Dnas.Add(dna);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Dna dna)
        {
            _context.Dnas.Update(dna);
        }
    }
}
