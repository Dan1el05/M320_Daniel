namespace UebungsaufgabenVererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person() { Name = "Bora", Vorname = "Efe"};
            Kunde kunde1 = new Kunde("Kiener", "Daniel", 1, "toptop", 300);
            Lagerist lagerist1 = new Lagerist("Epper", "Michael", 1, "top", 1.80);
            Kind kind1 = new Kind("Toma", "Amadeo", 2, "gut", 2);
            lagerist1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            lagerist1.LagereEin();
            lagerist1.Esse();
            kunde1.Trage();
            lagerist1.Trage();
            kind1.Trage();
            kind1.Esse();
            
        }
    }
}