namespace DesignPattern.Factory.AbstractFactory
{
    public class Pentium : IVersion
    {
        public Version GetVersion()
        {
            return Version.Pentium;
        }
    }
    public class Corei3 : IVersion
    {
        public Version GetVersion()
        {
            return Version.Corei3;
        }
    }
    public class Corei5 : IVersion
    {
        public Version GetVersion()
        {
            return Version.Corei5;
        }
    }
}