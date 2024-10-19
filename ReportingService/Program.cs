using DataAccess.DataModels;

var builder = WebApplication.CreateBuilder(args);

#region Builder

builder.Services.AddScoped<IBaseRepository<ReportingDataModel>, ReportingRepository>();


#endregion

var app = builder.Build();

app.MapGet("/api/ReportingApi/{id:string}", async (string id, IBaseRepository<ReportingDataModel> repository) =>
{
    var entity = await repository.GetByIDAsync(id);
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});
app.Run();
