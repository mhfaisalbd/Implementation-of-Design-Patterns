using DesignPattern.Factory.UserManager;

namespace DesignPattern.Factory.FactoryMethod
{
    public class MACUserFactory : BaseOSUserFactory
    {
        public MACUserFactory(OperatingSystemUser user) : base(user)
        {
        }

        public override IOSUserManager Create()
        {
            MACUserManager userManager = new MACUserManager();
            _user.Hardware = userManager.Stability();
            return userManager;
        }
    }
}