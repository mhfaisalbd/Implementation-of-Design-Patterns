namespace DesignPattern.Factory.UserManager
{
    public class MACUserManager : IOSUserManager
    {
        public string ApplyKernel()
        {
            return $"Unix";
        }

        public string ApplyGUI()
        {
            return $"Aqua";
        }

        public string ApplyDefaultBrowser()
        {
            return $"Safari";
        }

        public string Stability()
        {
            return $"Stable Hardware";
        }
    }
}