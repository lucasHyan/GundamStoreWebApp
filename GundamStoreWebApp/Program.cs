using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Localization;
using NToastNotify;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IModelKitService, ModelKitService>();

//Add service ToastNotify
builder.Services.AddRazorPages().AddNToastNotifyToastr(new ToastrOptions()
{
    ProgressBar=true,
    PositionClass=ToastPositions.TopRight,
    PreventDuplicates=true,
    CloseButton=true
});


var app = builder.Build();
app.UseNToastNotify();
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

// Configurar a cultura padrão para en-US
var defaultCulture = new CultureInfo("en-US");
app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(defaultCulture),
    SupportedCultures = new List<CultureInfo> { defaultCulture },
    SupportedUICultures = new List<CultureInfo> { defaultCulture }
});

app.MapRazorPages();

app.Run();
