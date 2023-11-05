using System.Security.Cryptography.X509Certificates;

namespace Fussballmannschaft
{
    internal class Spiel
    {
        private List<Fussballmannschaft> mannschaften;
        private Resultat? resultat;

        public Spiel(List<Fussballmannschaft> mannschaften)
        {
            if (mannschaften.Count() != 2)
            {
                throw new ArgumentException("Ein Spiel kann nur mit 2 Mannschaften durchgeführt werden. " +
                    $"Anzahl übergebene Mannschaften: {mannschaften.Count()}");
            }
            this.mannschaften = mannschaften;
        }

        public void Spielen()
        {
            Console.WriteLine($"Der Schiedsrichter pfeifft das Spiel zwischen {mannschaften[0].Name} und {mannschaften[1].Name} an");
            int[] tore = new int[2];
            for (int i = 0; i < mannschaften.Count(); i++)
            {
                int geschosseneTore = mannschaften[i].Spielzug();
                int indexDerAnderenMannschaft = i == 0 ? 1 : 0;
                int mannschaftDieToreSchiesstIndex = geschosseneTore > 0 ? i : indexDerAnderenMannschaft;
                SchreibeToreAufKonsole(Math.Abs(geschosseneTore), mannschaftDieToreSchiesstIndex);
                tore[mannschaftDieToreSchiesstIndex] += Math.Abs(geschosseneTore);
            }
            resultat = new Resultat(tore[0], tore[1]);
        }
        private void SchreibeToreAufKonsole(int anzahl, int mannschaftsIndex)
        {
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine($"{mannschaften[mannschaftsIndex].Name} schiessen ein Tor!");
            }
        }
        public void SchreibeResultatAufKonsole()
        {
            Console.WriteLine("Der Schiedsrichter pfeifft das Spiel ab");
            Console.WriteLine($"{mannschaften[0].Name} {resultat} {mannschaften[1].Name}");
        }
    }
}
