using SmartHome_dki_es.Aktoren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Zimmer
{
    internal abstract class  ZimmerDecorator : IZimmer
    {
    private List<Heizungsventil> heizungsVentile;
    private List<Jalousiesteuerung> jalousieSteuerungen;
    private List<MarkisenSteuerungDecorator> markisenSteuerungen;

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VorgegebeneTemperatur { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PersonImZimmer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void WetterSensorDecorator()
    {
        this.heizungsVentile = new List<Heizungsventil>();
        this.jalousieSteuerungen = new List<Jalousiesteuerung>();
        this.markisenSteuerungen = new List<MarkisenSteuerungDecorator>();
    }
 
    public void RegistriereHeizungsVentil(Heizungsventil ventil)
    {
        heizungsVentile.Add(ventil);
    }
 
    public void RegistriereJalousieSteuerung(Jalousiesteuerung jalousie)
    {
        jalousieSteuerungen.Add(jalousie);
    }
 
    public void RegistriereMarkisenSteuerung(MarkisenSteuerungDecorator markise)
    {
        markisenSteuerungen.Add(markise);
    }
 
    public void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit, bool personImZimmer)
    {
        foreach (var ventil in heizungsVentile)
        {
            ventil.VerarbeiteWetterdaten(aussenTemperatur, personImZimmer);
        }
 
        foreach (var jalousie in jalousieSteuerungen)
        {
            jalousie.VerarbeiteWetterdaten(aussenTemperatur, personImZimmer);
        }
 
        foreach (var markise in markisenSteuerungen)
        {
            markise.VerarbeiteWetterdaten(aussenTemperatur, windgeschwindigkeit);
        }
    }

        public void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit)
        {
            throw new NotImplementedException();
        }
    }

}
