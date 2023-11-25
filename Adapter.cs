namespace CSharp11_11
{
    public class Adapter: Target
    {
        private Adaptee _ad;

        public Adapter(int a, int b)
        {
            _ad = new Adaptee(a, b);
        }

        public override int GetA()
        {
            
            return _ad.GetAll()[0];
        }

        public override int GetB()
        {
            return _ad.GetAll()[1];
        }

        public override int Request() => _ad.SpecificRequest();
    }
}