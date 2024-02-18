using SmartHome_dki_es.Zimmer;
using SmartHome_dki_es.Zimmer.Zimmer;

namespace SmartHome_dki_es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zimmern zimmern = new Zimmern(Kueche, 22, true);
           zimmern.VerarbeiteWetterdaten();
            
                
            
        }
    }
}