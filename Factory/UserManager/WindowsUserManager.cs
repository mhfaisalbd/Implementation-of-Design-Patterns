namespace DesignPattern.Factory.UserManager
{
    public class WindowsUserManager : IOSUserManager
    {
        public string ApplyKernel()
        {
            return $"Windows NT";   
        }

        public string ApplyGUI()
        {
            return $"Windows Desktop";
        }

        public string ApplyDefaultBrowser()
        {
            return $"Microsoft Edge";
        }
    }
}