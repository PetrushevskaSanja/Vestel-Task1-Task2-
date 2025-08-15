var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/api/reverse", (ReverseRequest req) =>
{
    if (req is null || string.IsNullOrWhiteSpace(req.Text))
    {
        return Results.BadRequest(new { error = "Text cannot be empty." });
    }

    var reversed = ReverseApi.TextUtils.Reverse(req.Text);

    return Results.Ok(new { reversedText = reversed });
})
.WithName("ReverseText")
.Produces(200)
.Produces(400); 

app.Run();

public record ReverseRequest(string? Text);
