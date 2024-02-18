namespace FactoryPizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalamiPizza pizza = new SalamiPizza();
            SchinkenPizza schinkenPizza = new SchinkenPizza();
             
            EinfachePizzaFabrik einfachePizzaFabrik = new EinfachePizzaFabrik();
            Pizzeria pizzeria = new Pizzeria();


            
        }
    }
}