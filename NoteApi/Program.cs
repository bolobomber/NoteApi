global using Note.DAL;
global using Microsoft.EntityFrameworkCore;
using Note.DAL.Helper;
using Note.DAL.Interface.Repositories;
using Note.DAL.Repositories;
using Note.Services.Interfaces;
using Note.Services.Services;
using Note.Services.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

   
builder.Services.AddControllers();
builder.Services.AddDbContext<NoteContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<INoteRepository, NoteRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<UserValidator>();
builder.Services.AddScoped<INoteService, NoteService>();
builder.Services.AddScoped<NoteValidator>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
UserHelper.AddStaticUser();
