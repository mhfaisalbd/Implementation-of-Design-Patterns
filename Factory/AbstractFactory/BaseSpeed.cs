namespace DesignPattern.Factory.AbstractFactory
{
    public class GH32 : IBaseSpeed
    {
        public string GetBaseSpeed()
        {
            return $"3.20GHz";
        }
    }
    public class GH23 : IBaseSpeed
    {
        public string GetBaseSpeed()
        {
            return $"2.30GHz";
        }
    }
}