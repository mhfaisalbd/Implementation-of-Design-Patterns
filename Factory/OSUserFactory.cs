using DesignPattern.Factory.UserManager;

namespace DesignPattern.Factory
{
    public static class OSUserFactory
    {
        private static IOSUserManager UserManager(OperatingSystem operatingSystem)
        {
            switch (operatingSystem)
            {
                case OperatingSystem.Windows:
                    return new WindowsUserManager();
                case OperatingSystem.Ubuntu:
                    return new UbuntuUserManager();
                case OperatingSystem.Macintosh:
                    return new MACUserManager();

                default:
                    return new WindowsUserManager();
            }
        }
        public static OperatingSystemUser NewUser(string userName, OperatingSystem operatingSystem)
        {
            var userManager = UserManager(operatingSystem);
            return new OperatingSystemUser
            {
                UserName = userName,
                OperatingSystem = operatingSystem,
                Kernel = userManager.ApplyKernel(),
                GUI = userManager.ApplyGUI(),
                DefaultBrowser = userManager.ApplyDefaultBrowser()
            };
        }
    }
}