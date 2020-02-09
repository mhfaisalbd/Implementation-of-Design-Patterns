namespace DesignPattern.Factory.AbstractFactory
{
    public interface IProcessor
    {
        IBrand AppointBrand();
        IBaseSpeed AppointBaseSpeed();
        IVersion AppointVersion();
    }
}