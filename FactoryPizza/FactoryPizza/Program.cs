namespace FactoryPizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria  = new Pizzeria(new EinfachePizzaFabrik());
            
            var pizza = pizzeria.bestellePizza("Salami");

            pizza.vorbereiten();
            pizza.schneiden();
            pizza.backen();
            pizza.einpacken();

            


            
        }
    }
}