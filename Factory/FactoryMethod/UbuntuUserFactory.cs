using DesignPattern.Factory.UserManager;

namespace DesignPattern.Factory.FactoryMethod
{
    public class UbuntuUserFactory : BaseOSUserFactory
    {
        public UbuntuUserFactory(OperatingSystemUser user) : base(user)
        {
        }

        public override IOSUserManager Create()
        {
            UbuntuUserManager userManager = new UbuntuUserManager();
            _user.Source = userManager.SourceFind();
            return userManager;
        }
    }
}