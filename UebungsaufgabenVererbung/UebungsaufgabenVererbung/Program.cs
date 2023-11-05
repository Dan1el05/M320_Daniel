namespace UebungsaufgabenVererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personen = new List<Person>();
            //Person person1 = new Person() { Name = "Bora", Vorname = "Efe"};
            Kunde kunde1 = new Kunde("Kiener", "Daniel", 1, "toptop", 300);
            Lagerist lagerist1 = new Lagerist("Epper", "Michael", 1, "top", 1.80);
            Kind kind1 = new Kind("Toma", "Amadeo", 2, "gut", 2);
            personen.Add(kunde1);
            personen.Add(kind1);
            personen.Add(lagerist1);

            foreach (Person p in personen)
            {
                p.Esse();
                p.Trage();
            }

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