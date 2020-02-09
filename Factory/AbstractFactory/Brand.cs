namespace DesignPattern.Factory.AbstractFactory
{
    public class Apple : IBrand
    {
        public Brand GetBrand()
        {
            return Brand.APPLE;
        }
    }

    public class Intel : IBrand
    {
        public Brand GetBrand()
        {
            return Brand.Intel;
        }
    }
    public class AMD : IBrand
    {
        public Brand GetBrand()
        {
            return Brand.AMD;
        }
    }
}