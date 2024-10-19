using DataAccess.DataBaseContexts;
using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
/// <summary>
/// Summary description for Class1
/// </summary>
public class ReportingRepository : IBaseRepository<ReportingDataModel>
{
    private readonly ReportingDBContext _dbContext;

    public ReportingRepository(ReportingDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(ReportingDataModel entity)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(ReportingDataModel entity)
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

    public IEnumerable<ReportingDataModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ReportingDataModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public ReportingDataModel GetByID(string id)
    {
        throw new NotImplementedException();
    }

    public Task<ReportingDataModel> GetByIDAsync(string id)
    {
        throw new NotImplementedException();
    }

    public void Update(ReportingDataModel entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ReportingDataModel entity)
    {
        throw new NotImplementedException();
    }
}
