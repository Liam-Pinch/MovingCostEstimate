using MovingCostEstimate.Services;
using MovingCostEstimate.Services.MovingCosts;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddScoped<VanCostCalculator>();
builder.Services.AddScoped<KitchenCostCalculator>();
builder.Services.AddScoped<LivingRoomCostCalculator>();
builder.Services.AddScoped<BedroomCostCalculator>();
builder.Services.AddScoped<EssentialsCostCalculator>();
builder.Services.AddScoped<DecoratingCostCalculator>();
builder.Services.AddScoped<MovingCostAggregator>();
builder.Services.AddScoped<BathroomCostCalculator>();
builder.Services.AddOpenApi();     

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); 
}

app.UseHttpsRedirection(); 

app.MapControllers(); 

app.Run();

