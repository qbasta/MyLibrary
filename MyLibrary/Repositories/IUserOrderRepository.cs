using MyLibrary.Models.OrderModels;

namespace MyLibrary.Repositories
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders();

    }
}
