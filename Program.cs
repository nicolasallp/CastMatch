using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using castmatch.Components;
using castmatch.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


//var kvUri = builder.Configuration["KVUrl"];

//var credential = new ClientSecretCredential(
//        builder.Configuration["TenantId"],
//        builder.Configuration["ClientId"],
//        builder.Configuration["ClientSecretId"]
//    );

//var client = new SecretClient(new Uri(kvUri), credential);
//ClientTvSecret.Secret = client.GetSecret(builder.Configuration["KeyVaultName"]).Value.Value;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
