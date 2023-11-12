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
            Dreieck dreieck2 = new Dreieck(100, 100, 20, 30, 25, 10);
            Rechteck rechteck2 = new Rechteck(100, 100, 50, 80);
            Kreis kreis2 = new Kreis(-6, 100, 100);
            Quadrate quadrat2 = new Quadrate(100, 100, 40, 40);
            dreiecke.Add(dreieck1);
            rechtecke.Add(rechteck1);
            kreise.Add(kreis1);
            quadrate.Add(quadrat1 );

            dreiecke.Add(dreieck2);
            rechtecke.Add(rechteck2);
            kreise.Add(kreis2);
            quadrate.Add(quadrat2);

            foreach (Dreieck dreieck in dreiecke) 
            {     
                dreieck.Rotiern();
                dreieck.PrintArea();
                dreieck.Verschieben();
                 dreieck.PrintPossition();
            }
            foreach (Kreis kreis in kreise)
            {
                
                kreis.PrintArea();
                kreis.Verschieben();
                kreis.PrintPossition();
            }
            foreach (Rechteck rechteck in rechtecke)
            {

                rechteck.Rotiern();
                rechteck.PrintArea();
                rechteck.Verschieben();
                rechteck.PrintPossition();
            }

            foreach (Quadrate quadrat in quadrate)
            {
                quadrat.TesteGleicheSeiten();
                quadrat.Rotiern();
                quadrat.PrintArea();
                quadrat.Verschieben();
                quadrat.PrintPossition();
            }
            // Ich kann die Methode für die Rotation aufrufen
        }
    }
}
