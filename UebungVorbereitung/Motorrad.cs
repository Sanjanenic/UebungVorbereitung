namespace UebungVorbereitung
{
    public class Motorrad : Fahrzeug
    {
        public Motorrad(string marke) : base(marke)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void Fahren(int kilometer)
        {
            base.Fahren(kilometer);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
