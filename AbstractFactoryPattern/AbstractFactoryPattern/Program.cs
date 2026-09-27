using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Loggers;
using AbstractFactoryPattern.Notifications;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Products
builder.Services.AddScoped<EmailNotification>();
builder.Services.AddScoped<EmailLogger>();

builder.Services.AddScoped<SmsNotification>();
builder.Services.AddScoped<SmsLogger>();


// Factories
builder.Services.AddScoped<EmailNotificationFactory>();
builder.Services.AddScoped<SmsNotificationFactory>();


// Factory Provider
builder.Services.AddScoped<NotificationFactoryProvider>();


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
