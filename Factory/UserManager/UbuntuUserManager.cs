namespace DesignPattern.Factory.UserManager
{
    public class UbuntuUserManager : IOSUserManager
    {
        public string ApplyKernel()
        {
            return $"Linux";
        }

        public string ApplyGUI()
        {
            return $"Gnome Desktop";
        }

        public string ApplyDefaultBrowser()
        {
            return $"Firefox";
        }

        public string SourceFind()
        {
            return $"Open-Source";
        }
    }
}