namespace DesignPattern.Factory.AbstractFactory
{
    public class Windows64Factory : IProcessor
    {
        
        public IBrand AppointBrand()
        {
            return new Intel();
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
    public class Windows32Factory : Windows64Factory
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