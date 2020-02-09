namespace DesignPattern.Factory.AbstractFactory
{
    public static class AbstractOSUserFactory
    {
        private static IProcessor GetProcessor(OperatingSystemUser user)
        {
            IProcessor processor;
            switch (user.OperatingSystem)
            {
                case OperatingSystem.Windows:
                    processor = user.OsType == OSType.OS32bit ? new Windows32Factory() : new Windows64Factory();
                    break;
                case OperatingSystem.Macintosh:
                    processor = user.OsType == OSType.OS32bit ? new MAC32Factory() : new MAC64Factory();
                    break;
                case OperatingSystem.Ubuntu:
                    processor = user.OsType == OSType.OS32bit ? new Ubuntu32Factory(): new Ubuntu64Factory();
                    break;
                default:
                    processor = new Windows64Factory();
                    break;
            }

            return processor;
        }

        public static OperatingSystemUser ApplyProcessor(OperatingSystemUser user)
        {
            IProcessor processor = GetProcessor(user);
            user.Processor = $"{processor.AppointBrand().GetBrand()} " +
                             $"{processor.AppointVersion().GetVersion()} @" +
                             $"{processor.AppointBaseSpeed().GetBaseSpeed()}";
            return user;
        }
    }
}