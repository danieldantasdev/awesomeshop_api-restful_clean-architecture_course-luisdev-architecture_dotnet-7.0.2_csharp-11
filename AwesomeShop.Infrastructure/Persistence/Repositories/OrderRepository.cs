﻿using AwesomeShop.Core.Entities;
using AwesomeShop.Core.Repositories;

namespace AwesomeShop.Infrastructure.Persistence.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task<int> Add(Order order)
    {
        return Task.FromResult(new Random().Next(1, 10000));
    }

    public Task<List<Order>> GetAll()
    {
        var orders = new List<Order>
            { new("1234", "LuisDev", "luisdev@mail.com", new List<OrderItem> { new(1, "Product 1", 10.5m, 3) }) };

        return Task.FromResult(orders);
    }

    public Task<Order> GetById(int id)
    {
        var order = new Order("1234", "LuisDev", "luisdev@mail.com",
            new List<OrderItem> { new(1, "Product 1", 10.5m, 3) });

        return Task.FromResult(order);
    }
}