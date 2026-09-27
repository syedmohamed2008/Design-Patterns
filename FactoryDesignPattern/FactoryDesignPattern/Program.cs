using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<EmailService>();

builder.Services.AddScoped<SmsService>();

builder.Services.AddScoped<WhatsAppService>();

builder.Services.AddScoped<INotificationFactory, NotificationFactory>();

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
