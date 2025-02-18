var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var orders = new List<Order>
{
    new Order { Id = 1, Quantity = 10, Status = "Pending" },
    new Order { Id = 2, Quantity = 20, Status = "Completed" },
    new Order { Id = 3, Quantity = 30, Status = "Pending" }
};

//Get all orders
app.MapGet("/orders", () => orders);

//Get order from ID
app.MapGet("/orders/{id}", (int id) => {
    var order = orders.FirstOrDefault(o => o.Id == id);
    if (order == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(order);
});

//Create new order
app.MapPost("/orders", (Order order) => 
{ 
    orders.Add(order); 
    return Results.Created($"/orders/{order.Id}", order); 
});

app.Run();



class Order
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public required string Status { get; set; }
}