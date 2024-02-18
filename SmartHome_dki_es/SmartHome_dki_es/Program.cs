namespace SmartHome_dki_es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wettersensor = new WetterSensorDecorator(wetterSensor);
    
            // Räume erstellen
            Kueche kueche = new Kueche { Name = "Küche", VorgegebeneTemperatur = 20, Kochherd = KochherdStatus.Aus };
            Bad badWC = new Bad { Name = "Bad/WC", VorgegebeneTemperatur = 22, Feuchtigkeit = 50 };
            Wohnzimmer wohnzimmer = new Wohnzimmer { Name = "Wohnzimmer", VorgegebeneTemperatur = 23, AmbientebeleuchtungR = 255, AmbientebeleuchtungG = 200, AmbientebeleuchtungB = 100 };
            
                
            
        }
    }
}