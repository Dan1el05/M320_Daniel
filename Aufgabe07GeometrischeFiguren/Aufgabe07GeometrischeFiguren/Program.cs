namespace Aufgabe07GeometrischeFiguren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dreieck> dreiecke = new List<Dreieck>();
            List<Rechteck> rechtecke = new List<Rechteck>();
            List<Kreis> kreise = new List<Kreis>();
            List<Quadrate> quadrate = new List<Quadrate>();

            Dreieck dreieck1 = new Dreieck(100, 100, 5, 10, 8, 7);
            Rechteck rechteck1 = new Rechteck(100, 100, 10, 30);
            Kreis kreis1 = new Kreis(3,100,100);
            Quadrate quadrat1 = new Quadrate(100,100, 10, 10);
            dreiecke.Add(dreieck1);
            rechtecke.Add(rechteck1);
            kreise.Add(kreis1);
            quadrate.Add(quadrat1 );

            foreach(Dreieck dreieck in dreiecke) 
            {     
                dreieck.Rotiern();
                dreieck.PrintArea();
                dreieck.verschieben();
                 dreieck.PrintPossition();
            }
            foreach (Kreis kreis in kreise)
            {
                
                kreis.PrintArea();
                kreis.verschieben();
                kreis.PrintPossition();
            }
            foreach (Rechteck rechteck in rechtecke)
            {

                rechteck.Rotiern();
                rechteck.PrintArea();
                rechteck.verschieben();
                rechteck.PrintPossition();
            }

            foreach (Quadrate quadrat in quadrate)
            {
                quadrat.TesteGleicheSeiten();
                quadrat.Rotiern();
                quadrat.PrintArea();
                quadrat.verschieben();
                quadrat.PrintPossition();
            }

        }
    }
}
