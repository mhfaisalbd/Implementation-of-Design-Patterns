using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Factory
{
    public class FactoryTest
    {
        private readonly IList<OperatingSystemUser> _operatingSystemUsers;
        public FactoryTest()
        {
            _operatingSystemUsers = new List<OperatingSystemUser>
            {
                OSUserFactory.NewUser($"Vince", OperatingSystem.Ubuntu),
                OSUserFactory.NewUser($"Berani", OperatingSystem.Macintosh),
                OSUserFactory.NewUser($"Ierani", OperatingSystem.Macintosh),
                OSUserFactory.NewUser($"Malwer", OperatingSystem.Windows),
                OSUserFactory.NewUser($"Nano", OperatingSystem.Ubuntu),
                OSUserFactory.NewUser($"Shoha", OperatingSystem.Windows)
            };
        }

        public void Test()
        {
            Console.WriteLine($"Factory --Generated OS Users By OS User Factory\n" +
                              $"______________________________________________________________________\n" +
                              "{0,-3} {1,-8} {2,-10} {3,-11} {4,-16} {5,-24}\n", $"ID",$"Name",$"OS",$"Kernel",$"GUI", $"Browser");

            foreach (OperatingSystemUser user in _operatingSystemUsers)
            {
                user.Id = _operatingSystemUsers.IndexOf(user);
                Console.WriteLine("{0,-3} {1,-8} {2,-10} {3,-11} {4,-16} {5,-24}",user.Id,user.UserName,user.OperatingSystem,user.Kernel,user.GUI,user.DefaultBrowser);
            }
        }

        public IList<OperatingSystemUser> GetUsers()
        {
            return _operatingSystemUsers;
        }
    }
}