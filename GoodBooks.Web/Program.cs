using GoodBooks.Data;
using GoodBooks.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
// adding database connection
builder.Services.AddDbContext<GoodBooksDBContext>(opts => {
    opts.EnableDetailedErrors();
    opts.UseNpgsql(builder.Configuration.GetConnectionString("goodbooks.dev"));
});

/*
 * this tells .NET that whenever we request the BookService interface that we actually want a short lived instance of the class
 * that is disposed of after that use, this is ok because there is no state in the class
 * you could also use AddSingleton to have a persistent class or AddScoped that would remain for the lifetime of the http request
 */
builder.Services.AddTransient<IBookService, BookService>();

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

// enable cors for local development
app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
