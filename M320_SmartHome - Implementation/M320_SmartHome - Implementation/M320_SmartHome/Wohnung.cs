﻿namespace M320_SmartHome {
    public class Wohnung {
        private List<IZimmer> zimmerList = new List<IZimmer>();
        private IWettersensor wettersensor;
        public Wohnung(IWettersensor wettersensor) {
            // Wettersensor ggf. in einem ersten Schritt hier generieren. Dann kann das später beim Testing für den WettersensorMock nach IoC umgebaut werden.
            this.wettersensor = wettersensor;

            this.zimmerList.Add(new Heizungsventil(new BadWC()));
            this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Kueche())));
            this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Schlafzimmer())));
            this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Wohnzimmer())));
            this.zimmerList.Add(new Jalousiensteuerung(new Markisensteuerung(new Wintergarten())));
        }

        public void SetTemperaturvorgabe(string zimmername, double temperaturvorgabe) {
            var zimmer = this.zimmerList.FirstOrDefault(x => x.Name == zimmername);
            if(zimmer != null) {
                zimmer.TemperaturVorgabe = temperaturvorgabe;
            }
        }
        public void SetPersonenImZimmer(string zimmername, bool personenImZimmer) {
            var zimmer = this.zimmerList.FirstOrDefault(x => x.Name == zimmername);
            if (zimmer != null) {
                zimmer.PersonenImZimmer = personenImZimmer;
            }
        }
        public void GenerateWetterdaten() {
            var wetterdaten = this.wettersensor.GetWetterdaten();

            Console.WriteLine($"\n*** Verarbeite Wetterdaten:\n    Aussentemperatur: {wetterdaten.Aussentemperatur}°C\n    Regen: {(wetterdaten.Regen ? "ja" : "nein")}\n    Windgeschwindigkeit: {wetterdaten.Windgeschwindigkeit}km/h");
            foreach(var zimmer in this.zimmerList) {
                zimmer.VerarbeiteWetterdaten(wetterdaten);
            }
        }
    }
}
