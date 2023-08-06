using AwesomeShop.Core.Entities;

namespace AwesomeShop.Core.DomainServices;

public interface IOrderDomainService
{
    bool Validate(Customer customer, Order order);
}