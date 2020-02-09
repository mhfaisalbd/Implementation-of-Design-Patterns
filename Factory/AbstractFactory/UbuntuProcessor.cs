namespace DesignPattern.Factory.AbstractFactory
{
    public class Ubuntu64Factory : IProcessor
    {

        public IBrand AppointBrand()
        {
            return new AMD();
        }

        public virtual IBaseSpeed AppointBaseSpeed()
        {
            return new GH32();
        }

        public virtual IVersion AppointVersion()
        {
            return new Corei3();
        }
    }
    public class Ubuntu32Factory : Ubuntu64Factory
    {
        public override IBaseSpeed AppointBaseSpeed()
        {
            return new GH23();
        }

        public override IVersion AppointVersion()
        {
            return new Pentium();
        }
    }
}