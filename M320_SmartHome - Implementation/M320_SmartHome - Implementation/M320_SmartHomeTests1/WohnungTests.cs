using Microsoft.VisualStudio.TestTools.UnitTesting;
using M320_SmartHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHome.Tests
{
    [TestClass()]
    public class WohnzimmerTests
    {
        [TestMethod()]
        public void HeizungsventielOffen20()
        {
            var wettersensor = new WettersensorMock(20,30,true);
            var wetterdaten = new Wetterdaten();
            var wohnung = new Wohnung(wettersensor);
            
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

            //Code um an bool heizungsventilOffen zu kommen

            Assert.IsTrue(bool heizungsventilOffen);

        }

    }

    
        [TestMethod()]
    public void Heizungsventiloffen19()
    {
        var wettersensor = new WettersensorMock(19, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool heizungsventilOffen zu kommen

        Assert.IsTrue(bool heizungsventilOffen);

    }


    [TestMethod()]
    public void Heizungsventiloffenuunter25()
    {
        var wettersensor = new WettersensorMock(-25, 30, true);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool heizungsventilOffen zu kommen

        Assert.IsFalse(bool heizungsventilOffen);

    }

    [TestMethod()]
    public void Heizungsventiloffen35()
    {
        var wettersensor = new WettersensorMock(35, 30, true);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool heizungsventilOffen zu kommen

        Assert.IsTrue(bool heizungsventilOffen);

    }


    [TestMethod()]
    public void MarkieseOffenKeinRegen()
    {
        var wettersensor = new WettersensorMock(35, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool markiseEingefahren zu kommen

        Assert.IsTrue(bool markiseEingefahren);

    }

    [TestMethod()]
    public void MarkieseOffeWenRegen()
    {
        var wettersensor = new WettersensorMock(35, 30, true);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool markiseEingefahren zu kommen

        Assert.IsFalse(bool markiseEingefahren);

    }

    [TestMethod()]
    public void MarkieseOffen20()
    {
        var wettersensor = new WettersensorMock(20, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool markiseEingefahren zu kommen

        Assert.IsFalse(bool markiseEingefahren);

    }

    [TestMethod()]
    public void MarkieseOffen19()
    {
        var wettersensor = new WettersensorMock(19, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool markiseEingefahren zu kommen

        Assert.IsFalse(bool markiseEingefahren) ;

    }

    [TestMethod()]
    public void MarkieseOffenunter25()
    {
        var wettersensor = new WettersensorMock(-25, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool markiseEingefahren zu kommen

        Assert.IsTrue(bool markiseEingefahren);

    }

    [TestMethod()]
    public void MarkieseOffen35()
    {
        var wettersensor = new WettersensorMock(35, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool markiseEingefahren zu kommen

        Assert.IsFalse(bool markiseEingefahren);

    }

    [TestMethod()]
    public void jalousieOffenKeinePerson()
    {
        var wettersensor = new WettersensorMock(35, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);
        wohnung.SetPersonenImZimmer("Wohnzimmer", false)

        //Code um an bool jalousieOffen zu kommen

        Assert.IsFalse(bool jalousieOffen);

    }

    [TestMethod()]
    public void jalousieOffenWenPerson()
    {
        var wettersensor = new WettersensorMock(35, 30, true);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);
        wohnung.SetPersonenImZimmer("Wohnzimmer", true);

        //Code um an bool jalousieOffen zu kommen

        Assert.IsTrue(bool jalousieOffen);

    }

    [TestMethod()]
    public void jalousieOffen20()
    {
        var wettersensor = new WettersensorMock(20, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool jalousieOffen zu kommen

        Assert.IsFalse(bool jalousieOffen);

    }

    [TestMethod()]
    public void jalousieOffen19()
    {
        var wettersensor = new WettersensorMock(19, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool jalousieOffen zu kommen

        Assert.IsFalse(bool jalousieOffen);

    }

    [TestMethod()]
    public void jalousieOffenUnter25()
    {
        var wettersensor = new WettersensorMock(-25, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool jalousieOffen zu kommen

        Assert.IsTrue(bool jalousieOffen);

    }

    [TestMethod()]
    public void jalousieOffen35()
    {
        var wettersensor = new WettersensorMock(35, 30, false);
        var wetterdaten = new Wetterdaten();
        var wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

        //Code um an bool jalousieOffen zu kommen

        Assert.IsFalse(bool jalousieOffen);

    }


}
