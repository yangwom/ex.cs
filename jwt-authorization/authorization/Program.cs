var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization(options => {
    options.AddPolicy("TrybeStudent", policy => policy.RequireClaim("Student"));
    builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("SouthAmerica", policy =>
    policy.RequireClaim(ClaimTypes.Country));
});
});

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

app.UseAuthorization();

app.Run();
