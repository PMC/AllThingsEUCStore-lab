using WebApp.Entities;

namespace WebApp.Services.CartService;

public interface ICartService
{
    event Action OnChange;
    Task AddToCart(CartItem item);
    Task SetQuantityAsync(int id, int quantity);
    Task<List<CartItem>> GetCartItems();
    Task DeleteItem(CartItem item);
    Task EmptyCart();
    int GetCount();
}
