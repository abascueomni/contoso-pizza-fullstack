/* using ContosoPizza.Models;
public static class OrderService
{
    static List<Order> Orders { get; }
    static int nextId = 2;
    static OrderService()
    {
        Orders = new List<Order>
        {
            new Order(){Id= 1, PizzaIds = new List<int>(){1,1}, OrderName ="Jim" }
        };
    }

    public static List<Order> GetAll() => Orders;
    public static Order? Get(int id) => Orders.FirstOrDefault(p => p.Id == id);

    public static void Add(Order order)
    {
        order.Id = nextId++;
        Orders.Add(order);
    }

    public static void Delete(int id)
    {
        var order = Get(id);
        if (order is null)
            return;

        Orders.Remove(order);
    }

    public static void Update(Order order)
    {
        var index = Orders.FindIndex(p => p.Id == order.Id);
        if (index == -1)
            return;

        Orders[index] = order;
    }
} */