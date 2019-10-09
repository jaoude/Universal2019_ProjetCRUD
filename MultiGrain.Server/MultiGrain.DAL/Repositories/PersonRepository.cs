using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;

namespace MultiGrain.DAL.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private MultiGrainDbContext _context;

        public PersonRepository(MultiGrainDbContext _db)
            : base(_db)
        {
        }

        public async Task<Person> GetPersonAsync(Guid id, CancellationToken ct)
        {
            return await _db.Set<Person>().FirstOrDefaultAsync(ct);
        }

        public async Task<IEnumerable<Person>> GetPersonsAsync(CancellationToken ct)
        {
            return await _db.Set<Person>().ToListAsync(ct);
        }

        public void CreatePerson(Person personEntity)
        {
             _db.Set<Person>().Add(personEntity);
        }
    }
}
