using repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Context
{
    public class RepoDbContext : DbContext, IRepoDbContext
    {
        public RepoDbContext() : base("connectionStringPlaceholder") { }
        public IDbSet<Entity> Entities { get; set; }
    }
}
