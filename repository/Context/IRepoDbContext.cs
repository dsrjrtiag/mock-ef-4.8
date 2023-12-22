using repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Context
{
    public interface IRepoDbContext
    {
        IDbSet<Entity> Entities { get; set; }
    }
}
