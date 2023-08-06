using AwesomeShop.Application.InputModels;
using AwesomeShop.Application.ViewModels;

namespace AwesomeShop.Application.Services;

public interface IOrderService
{
    Task<ResultBase<int>> Add(AddOrderInputModel input);
    Task<ResultBase<GetAllOrdersViewModel>> GetAll();
    Task<ResultBase<GetOrderByIdViewModel>> GetById(int id);
}