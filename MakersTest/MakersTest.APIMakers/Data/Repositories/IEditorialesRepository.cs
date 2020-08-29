using MakersTest.APIMakers.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersTest.APIMakers.Data.Repositories
{
    public interface IEditorialesRepository
    {
        IEnumerable<Editorial> GetAll();
    }
}
