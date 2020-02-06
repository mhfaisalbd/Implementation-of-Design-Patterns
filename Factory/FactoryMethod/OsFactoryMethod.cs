using System.Collections.Generic;
using DesignPattern.Factory.UserManager;

namespace DesignPattern.Factory.FactoryMethod
{
    public static class OsFactoryMethod
    {
        private static BaseOSUserFactory UserManager(OperatingSystemUser user)
        {
            switch (user.OperatingSystem)
            {
                case OperatingSystem.Windows:
                    return new WindowsUserFactory(user);
                case OperatingSystem.Ubuntu:
                    return new UbuntuUserFactory(user);
                case OperatingSystem.Macintosh:
                    return new MACUserFactory(user);

                default:
                    return new WindowsUserFactory(user);
            }
        }

        public static OperatingSystemUser NewUser(string userName, OperatingSystem operatingSystem)
        {
            OperatingSystemUser user = new OperatingSystemUser
            {
                UserName = userName,
                OperatingSystem = operatingSystem
            };

            return UserManager(user).ApplyFeatures();

        }
    }
}