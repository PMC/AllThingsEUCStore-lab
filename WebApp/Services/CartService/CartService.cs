using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using MudBlazor;
using WebApp.Entities;
namespace WebApp.Services.CartService;

public class CartService : ICartService
{
    private readonly ProtectedLocalStorage _localStorage;
    private readonly ISnackbar _snackbar;
    private int _count;
    public event Action OnChange;

    public CartService(ProtectedLocalStorage localStorage, ISnackbar snackbar)
    {
        _localStorage = localStorage;
        _snackbar = snackbar;
    }
    public async Task AddToCart(CartItem item)
    {
        var result = await _localStorage.GetAsync<List<CartItem>>("cart");
        List<CartItem> cartList;

        if (result.Success == false || result.Value == null)
        {
            cartList = new();
        }
        else
        {
            cartList = result.Value;
        }

        //if exists then update quantity
        var sameItem = cartList.Find(i => i.ProductId == item.ProductId);
        if (sameItem == null)
        {
            cartList.Add(item);
        }
        else
        {
            sameItem.Quantity += item.Quantity;
        }

        _count = cartList.Count;
        await _localStorage.SetAsync("cart", cartList);

        _snackbar.Add($"{item.ProductName} Added to cart:", Severity.Success);
        OnChange.Invoke();
    }

    public async Task<List<CartItem>> GetCartItems()
    {
        var result = await _localStorage.GetAsync<List<CartItem>>("cart");

        if (result.Success == false || result.Value == null)
        {
            _count = 0;
            return new();
        }

        _count = result.Value.Count;
        return result.Value;
    }

    public async Task DeleteItem(CartItem item)
    {
        var result = await _localStorage.GetAsync<List<CartItem>>("cart");

        if (result.Success == false || result.Value == null)
        {
            _count = 0;
            return;
        }

        List<CartItem> cartList = result.Value;

        var cartItem = cartList.Find(i => i.ProductId == item.ProductId);

        if (cartItem != null)
            cartList.Remove(cartItem);

        _count = cartList.Count;
        await _localStorage.SetAsync("cart", cartList);

        OnChange.Invoke();

    }

    public async Task EmptyCart()
    {
        await _localStorage.DeleteAsync("cart");
        _count = 0;
        OnChange.Invoke();
    }

    public int GetCount()
    {
        return _count;
    }
}
