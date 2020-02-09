namespace DesignPattern.Factory.AbstractFactory
{
    public class MAC64Factory : IProcessor
    {

        public IBrand AppointBrand()
        {
            return new Apple();
        }

        public virtual IBaseSpeed AppointBaseSpeed()
        {
            return new GH32();
        }

        public virtual IVersion AppointVersion()
        {
            return new Corei5();
        }
    }
    public class MAC32Factory : MAC64Factory
    {
        public override IBaseSpeed AppointBaseSpeed()
        {
            return new GH23();
        }

        public override IVersion AppointVersion()
        {
            return new Corei3();
        }
    }
}