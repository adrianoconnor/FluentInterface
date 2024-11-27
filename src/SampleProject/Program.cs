using EntityInterface.Core;
using EntityInterface.SqliteAdapter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging();

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddEntityInterfaceCore(options => {
    //options.UseSqlServerAdapter(builder.Configuration.GetConnectionString("demo_database")!);
    options.UseSqliteAdapter("Data Source=test.db");
    options.ConfigureInterface(@"");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapEntityInterfacePages();
app.MapRazorPages();

app.Run();
