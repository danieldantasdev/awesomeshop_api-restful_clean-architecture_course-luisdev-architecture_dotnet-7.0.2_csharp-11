﻿using AwesomeShop.Core.Entities;

namespace AwesomeShop.Core.DomainServices;

public class OrderDomainService : IOrderDomainService
{
    public bool Validate(Customer customer, Order order)
    {
        if (customer.Status != Enums.CustomerStatusEnum.Active)
            return false;

        if (order.Items == null || order.Items.Count == 0)
            return false;

        if (order.TotalCost < 10)
            return false;

        return true;
    }
}