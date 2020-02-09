using System;
using System.Collections.Generic;

namespace DesignPattern.Factory.AbstractFactory
{
    public class AbstractFactoryTest
    {
        private readonly IList<OperatingSystemUser> _operatingSystemUsers;

        public AbstractFactoryTest(IList<OperatingSystemUser> operatingSystemUsers)
        {
            Random random = new Random();
            foreach (OperatingSystemUser user in operatingSystemUsers)
            {
                user.OsType = (OSType) random.Next(0,1);
            }

            _operatingSystemUsers = operatingSystemUsers;
        }


        public void Test()
        {
            Console.WriteLine($"Abstract Factory --Generated OS Users By OS Abstract User Factory\n" +
                              $"_______________________________________________________________________" +
                              $"_______________________________________________________________________\n" +
                              "{0,-3} {1,-8} {2,-10} {3,-11} {4,-16} {5,-15} {6,-12} {7,-12} {8,-17} {9,-17}\n",
                $"ID", $"Name", $"OS", $"Kernel", $"GUI", $"Browser", $"Flexibility", $"Source", $"Hardware", $"Processor");

            foreach (OperatingSystemUser user in _operatingSystemUsers)
            {
                user.Id = _operatingSystemUsers.IndexOf(user);
                AbstractOSUserFactory.ApplyProcessor(user);
                Console.WriteLine("{0,-3} {1,-8} {2,-10} {3,-11} {4,-16} {5,-15} {6,-12} {7,-12} {8,-17} {9,-17}",
                    user.Id, user.UserName, user.OperatingSystem, user.Kernel, user.GUI, user.DefaultBrowser,
                    user.Flexibility, user.Source, user.Hardware, user.Processor);
            }
        }

    }
}