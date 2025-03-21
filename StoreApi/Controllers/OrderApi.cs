using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Entities;

namespace StoreApi.Controllers;

public static class OrderApi
{
    public static void MapOrderEndpoints(this IEndpointRouteBuilder app)
    {
        // Get all orders
        app.MapGet("/orders", async (SqliteDbContext db) =>
            await db.Orders.Include(o => o.OrderDetails).ToListAsync());

        // Get order by ID
        app.MapGet("/orders/{id}", async (int id, SqliteDbContext db) =>
            await db.Orders.Include(o => o.OrderDetails).FirstOrDefaultAsync(o => o.OrderId == id)
                is Order order
                    ? Results.Ok(order)
                    : Results.NotFound());

        // Create a new order
        // Configure the HTTP request pipeline.
        app.MapPost("/orders", async (CreateOrderDto orderDto, SqliteDbContext db) =>
        {
            var order = new Order
            {
                CustomerId = orderDto.CustomerId,
                FirstName = orderDto.FirstName,
                LastName = orderDto.LastName,
                Address1 = orderDto.Address1,
                Address2 = orderDto.Address2,
                City = orderDto.City,
                ZipCode = orderDto.ZipCode,
                Email = orderDto.Email,
                PhoneNumber = orderDto.PhoneNumber,
                OrderDate = DateTime.UtcNow,
                Status = "Pending" // Set initial status
            };

            decimal? totalAmount = 0;

            foreach (var itemDto in orderDto.OrderItems)
            {
                var product = await db.Products.FindAsync(itemDto.ProductId);
                if (product == null)
                {
                    return Results.BadRequest($"Product with ID {itemDto.ProductId} not found.");
                }

                var orderDetail = new OrderDetail
                {
                    ProductId = itemDto.ProductId,
                    ProductName = product.ProductName,
                    Quantity = itemDto.Quantity,
                    Price = (decimal)product.Price
                };

                order.OrderDetails.Add(orderDetail);
                totalAmount += product.Price * itemDto.Quantity;
            }

            order.TotalAmount = totalAmount;

            db.Orders.Add(order);
            await db.SaveChangesAsync();

            return Results.Created($"/orders/{order.OrderId}", order);
        });


        // Delete an order
        app.MapDelete("/orders/{id}", async (int id, SqliteDbContext db) =>
        {
            if (await db.Orders.FindAsync(id) is Order order)
            {
                db.Orders.Remove(order);
                await db.SaveChangesAsync();
                return Results.NoContent();
            }
            return Results.NotFound();
        });
    }
}

// Define your DTO for creating an order



