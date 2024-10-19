using DataAccess.DataBaseContexts;
using DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RepoProvider.Repositories
{
    public class CounterRepository : IBaseRepository<CounterDataModel>
    {
        private readonly CounterDBContext _dbContext;

        public CounterRepository(CounterDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(CounterDataModel entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(CounterDataModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CounterDataModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CounterDataModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public CounterDataModel GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CounterDataModel> GetByIDAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(CounterDataModel entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CounterDataModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
