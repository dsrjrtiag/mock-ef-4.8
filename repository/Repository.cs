using repository.Context;
using repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    /// <summary>
    /// Partial implementation of a Repository that provides CRUD operations on an Entity 
    /// 
    /// Could be a Controller or Service if you are using the DBContext directly
    /// </summary>
    public class Repository
    {
        private readonly IRepoDbContext context;

        /// <summary>
        /// Constructor that supports dependency Injection
        /// 
        /// Allows the context to be swapped out as long as it adheres to the interface IRepoDbContext
        /// </summary>
        /// <param name="context">Interface representing a DbContext</param>
        public Repository(IRepoDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Entity> GetEntities()
        {
            return context.Entities;
        }

        public void AddEntity(Entity e)
        {
            context.Entities.Add(e);
        }
    }
}
