using System;
using System.Collections.Generic;

namespace DesignPattern.Factory.FactoryMethod
{
    public class FactoryMethodTest
    {
        private readonly IList<OperatingSystemUser> _operatingSystemUsers;
        public FactoryMethodTest()
        {
            _operatingSystemUsers = new List<OperatingSystemUser>
            {
                OsFactoryMethod.NewUser($"Vince", OperatingSystem.Ubuntu),
                OsFactoryMethod.NewUser($"Berani", OperatingSystem.Macintosh),
                OsFactoryMethod.NewUser($"Ierani", OperatingSystem.Macintosh),
                OsFactoryMethod.NewUser($"Malwer", OperatingSystem.Windows),
                OsFactoryMethod.NewUser($"Nano", OperatingSystem.Ubuntu),
                OsFactoryMethod.NewUser($"Shoha", OperatingSystem.Windows)
            };
        }

        public void Test()
        {
            Console.WriteLine($"Factory Method --Generated OS Users By OS User Factory Method\n" +
                              $"_______________________________________________________________________" +
                              $"__________________________________________\n" +
                              "{0,-3} {1,-8} {2,-10} {3,-11} {4,-16} {5,-15} {6,-12} {7,-12} {8,-12}\n",
                $"ID", $"Name", $"OS", $"Kernel", $"GUI", $"Browser", $"Flexibility", $"Source", $"Hardware");

            foreach (OperatingSystemUser user in _operatingSystemUsers)
            {
                user.Id = _operatingSystemUsers.IndexOf(user);
                Console.WriteLine("{0,-3} {1,-8} {2,-10} {3,-11} {4,-16} {5,-15} {6,-12} {7,-12} {8,-12}", 
                    user.Id, user.UserName, user.OperatingSystem, user.Kernel, user.GUI, user.DefaultBrowser, 
                    user.Flexibility, user.Source, user.Hardware);
            }
        }

        public IList<OperatingSystemUser> GetUsers()
        {
            return _operatingSystemUsers;
        }

    }
}