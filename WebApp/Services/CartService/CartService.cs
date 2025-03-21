using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using MudBlazor;
using WebApp.Entities;
namespace WebApp.Services.CartService;

public class CartService : ICartService
{
    private readonly ProtectedLocalStorage _localStorage;
    private readonly ISnackbar _snackbar;
    private int _count;
    public event Action? OnChange;

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

        _count = cartList.Sum(i => i.Quantity);
        await _localStorage.SetAsync("cart", cartList);

        //_snackbar.Add($"{item.ProductName} Added to cart:", Severity.Success);
        ShowVariant($"{item.ProductName} Added to cart:", Variant.Filled);
        if (OnChange != null) OnChange?.Invoke();
    }

    public async Task SetQuantityAsync(int id, int quantity)
    {
        try
        {
            var result = await _localStorage.GetAsync<List<CartItem>>("cart");
            if (result.Success == false || result.Value == null)
            {
                return;
            }

            var cart = result.Value;
            var item = cart.FirstOrDefault(i => i.ProductId == id);
            if (item == null)
            {
                return;
            }

            item.Quantity = quantity;
            _count = cart.Sum(i => i.Quantity);
            await _localStorage.SetAsync("cart", cart);
            if (OnChange != null) OnChange?.Invoke();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);

        }
        return;
    }

    public async Task<List<CartItem>> GetCartItems()
    {
        try
        {
            var result = await _localStorage.GetAsync<List<CartItem>>("cart");

            if (result.Success == false || result.Value == null)
            {
                return new();
            }

            _count = result.Value.Sum(i => i.Quantity);
            return result.Value;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new();
        }

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

        _count = cartList.Sum(i => i.Quantity);
        await _localStorage.SetAsync("cart", cartList);

        if (OnChange != null) OnChange?.Invoke();

    }

    public async Task EmptyCart()
    {
        await _localStorage.DeleteAsync("cart");
        _count = 0;
        if (OnChange != null) OnChange?.Invoke();
    }

    public int GetCount()
    {
        return _count;
    }

    protected void ShowVariant(string message, Variant variant)
    {

        _snackbar.Add(message, Severity.Success, (options) =>
        {
            options.CloseAfterNavigation = true;
            options.SnackbarVariant = variant;
            options.VisibleStateDuration = 2000;

        });
    }
}
