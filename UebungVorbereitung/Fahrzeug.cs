namespace UebungVorbereitung
{
    public class Fahrzeug
    {
        internal string Marke { get; set; }
        internal int Kilometerstand { get; set; }

        public Fahrzeug(string marke)  //ct -->tab, tab --> ovako se generise konstruktor
        {
            Marke = marke;
        }

        public virtual void Fahren(int kilometer) {
            Kilometerstand = kilometer;
        
        }  //virtual znaci da moze biti ovveride u podklasama aovdje mora biti implementirana

    }

}
