using exercise;

internal class Program

{
    private static void Main(string[] args)
    {
        Product box = new Product();
        box.setPrice(10);
        box.setCode(12345);

        Product bag = new Product();
        bag.setPrice(5);
        bag.setCode(12346);

        Order order = new Order();

        order.cuenta(12345,1);
        order.cuenta(12345,1);
        order.cuenta(12345,13);
        Console.WriteLine(order.cuentaTotal);

    }
}