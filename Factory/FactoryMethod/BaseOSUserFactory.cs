using DesignPattern.Factory.UserManager;

namespace DesignPattern.Factory.FactoryMethod
{
    public abstract class BaseOSUserFactory
    {
        protected OperatingSystemUser _user;

        protected BaseOSUserFactory(OperatingSystemUser user)
        {
            _user = user;
        }

        public OperatingSystemUser ApplyFeatures()
        {
            IOSUserManager userManager = this.Create();

            _user.Kernel = userManager.ApplyKernel();
            _user.GUI = userManager.ApplyGUI();
            _user.DefaultBrowser = userManager.ApplyDefaultBrowser();

            return _user;
        }
        public abstract IOSUserManager Create();
    }
}