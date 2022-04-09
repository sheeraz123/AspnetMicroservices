using Basket.API.Entities;

namespace Basket.API.Respositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> updateBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);

    }
}
