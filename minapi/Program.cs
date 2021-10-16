var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{ 
    app.UseDeveloperExceptionPage(); 
}

app.UseSwagger();
app.MapGet("/", () => "Hello World!");
app.MapGet("/person",()=> new Person("Rajdeep","Das"));
app.UseSwaggerUI();
app.Run();


public record Person(string FirstName, string LastName);
