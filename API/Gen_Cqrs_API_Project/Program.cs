using Gen_Cqrs_API_Project.ManuelCQRS.Handlers.CommandHandlers;
using Gen_Cqrs_API_Project.ManuelCQRS.Handlers.QueryHandler;
using Gen_Cqrs_API_Project.Models;

var builder = WebApplication.CreateBuilder(args);


#region Manuel CQRS
builder.Services.AddSingleton<CreateProductCommandHandler>()
                .AddSingleton<DeleteProductCommandHandler>()
                .AddSingleton<GetByIdProductQueryHandler>()
                .AddSingleton<GetAllProductQueryHandler>();
#endregion

#region Mediator CQRS
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationDbContext).Assembly));
#endregion

builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Varsayýlan olarak /swagger adresinde açýlýr
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
