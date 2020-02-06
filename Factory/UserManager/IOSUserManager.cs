namespace DesignPattern.Factory.UserManager
{
    public interface IOSUserManager
    {
        string ApplyKernel();
        string ApplyGUI();
        string ApplyDefaultBrowser();
    }
}