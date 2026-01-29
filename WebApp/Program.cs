using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("""
        <!doctype html>
        <html>
        <head><meta charset="utf-8"><title>Simple .NET WebApp</title></head>
        <body>
          <h1>Simple .NET Core WebApp</h1>
          <p>Hello from ASP.NET Core minimal app!</p>
        </body>
        </html>
        """);
});

app.MapGet("/api/hello", () => Results.Json(new { message = "Hello from API", time = DateTime.UtcNow }));

app.Run();
