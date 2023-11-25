namespace CSharp11_11
{
    public class Adaptee
    {
        private int _a, _b;

        public Adaptee(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public void GetAll(out int a, out int b)
        {
            a = _a;
            b = _b;
        }

        public int[] GetAll() => new int[] { _a, _b };

        public int SpecificRequest() => _a * _b;
    }
}