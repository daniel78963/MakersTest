using MakersTest.APIMakers.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersTest.APIMakers.Data.Repositories
{
    public class EditorialesRepository : IEditorialesRepository
    {
        private readonly DataContext context;

        public EditorialesRepository(DataContext context)
        {
            this.context = context;
        }

        //public IQueryable<Editorial> GetAll()
        //{
        //    return context.Editorials;
        //}

        public IEnumerable<Editorial> GetAll()
        {
            return context.Editorials;
        }

        //public async Task<IEnumerable<Editorial>> GetAllAsync()
        //{
        //    return await context.Editorials.AsAsyncEnumerable();
        //}
    }
}
