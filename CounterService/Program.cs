using DataAccess.DataModels;
using DataAccess.RepoProvider.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region Builder

builder.Services.AddScoped<IBaseRepository<CounterDataModel>, CounterRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/CounterApi/{id:string}", async (string id, IBaseRepository<CounterDataModel> repository) =>
{
    var entity = await repository.GetByIDAsync(id);
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
}).WithName("GetByIDAsync").WithOpenApi();
app.Run();
