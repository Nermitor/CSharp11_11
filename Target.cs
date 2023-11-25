namespace CSharp11_11
{
    public abstract class Target
    {
        public abstract int GetA();
        public abstract int GetB();
        public abstract int Request();
    }

    public class ConcreteTarget : Target
    {
        private int _a, _b;

        public ConcreteTarget(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public override int GetA() => _a;

        public override int GetB() => _b;

        public override int Request() => _a + _b;
    }
}