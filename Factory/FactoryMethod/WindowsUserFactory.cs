using DesignPattern.Factory.UserManager;

namespace DesignPattern.Factory.FactoryMethod
{
    public class WindowsUserFactory : BaseOSUserFactory
    {
        public WindowsUserFactory(OperatingSystemUser user) : base(user)
        {
        }

        public override IOSUserManager Create()
        {
            WindowsUserManager userManager = new WindowsUserManager();
            _user.Flexibility = userManager.PowerOfUI();
            return userManager;
        }
    }
}