using System;

public class CoffeeShop
{
    private IMenu _menu;

    public CoffeeShop(IMenu menu)
    {
        _menu = menu;
    }

    public void ProcessOrder(string customerName, bool wantsCoffee, bool wantsSandwich)
    {
        double total = 0;

        if (wantsCoffee)
            total += _menu.GetCoffeePrice();
        if (wantsSandwich)
            total += _menu.GetSandwichPrice();

        Console.WriteLine($"Order processed for {customerName}");
        Console.WriteLine($"Total amount to pay: {total}");
        ProcessPayment(total);
    }

    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of {amount}");
    }
}

public interface IMenu
{
    double GetCoffeePrice();
    double GetSandwichPrice();
}

public class Menu : IMenu
{
    private double coffeePrice;
    private double sandwichPrice;

    public Menu(double coffeePrice, double sandwichPrice)
    {
        this.coffeePrice = coffeePrice;
        this.sandwichPrice = sandwichPrice;
    }

    public double GetCoffeePrice() => coffeePrice;

    public double GetSandwichPrice() => sandwichPrice;

    public void UpdateMenu(double coffeePrice, double sandwichPrice)
    {
        this.coffeePrice = coffeePrice;
        this.sandwichPrice = sandwichPrice;
    }
}
