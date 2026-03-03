/* using ContosoPizza.Models;

namespace ContosoPizza.Services;

public static class PizzaDataService
{
    static List<Pizza> Pizzas { get; }
    static List<CustomPizza> CustomPizzas { get; } = new();
    static int nextId = 4;
    static PizzaDataService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian",Price=5.00, Toppings = new List<string>(){"Cheese","Tomato"},IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie",Price=4.99, IsGlutenFree = true },
            new Pizza { Id = 3, Name = "Notpizza", Price =25.52,IsGlutenFree = false, IsDeleted = true}
        };
    }

    public static List<Pizza> GetAll() => Pizzas;
    public static Pizza? Get(string name) => Pizzas.FirstOrDefault(p => p.Name == name);
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
    public static CustomPizza CreateCustomPizza(Action<CustomPizzaBuilder> configure)
    {
        var builder = new CustomPizzaBuilder();
        configure(builder);
        var pizza = builder.Build();
        CustomPizzas.Add(pizza);
        return pizza;
    }


    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    public static void Delete(string name)
    {
        var pizza = Get(name);
        if (pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Name == pizza.Name);
        if (index == -1)
            return;

        Pizzas[index] = pizza;
    }
} */