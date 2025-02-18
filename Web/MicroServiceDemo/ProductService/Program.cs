var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var products = new List<Product>()
{
    new () { Id = 1, Name = "Computer", Type = "Electronics", Stock = 0 },
    new () { Id = 2, Name = "Sweater", Type = "Clothes", Stock = 5},
    new () { Id = 3, Name = "Pokemon Figure", Type = "Toys", Stock =  10}
};

//Get all products
app.MapGet("/products", () => products);

//Get product from ID
app.MapGet("/products/{id}", (int id) => {
    var product = products.FirstOrDefault(p => p.Id == id);
    if (product == null)
    {
        return Results.NotFound("Product not found.");
    }
    return Results.Ok(product);
});


// app.MapPost("/products", (Product product) => 
// { 
//     products.Add(product); 
//     return Results.Created($"/orders/{product.Id}", product); 
// });

app.Run();

class Product()
{
    public int Id { get; set;}
    public required string Type { get; set; }
    public required string Name { get; set;}
    public int Stock { get; set; }

}
