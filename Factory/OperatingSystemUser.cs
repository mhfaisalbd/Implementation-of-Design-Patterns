namespace DesignPattern.Factory
{
    public class OperatingSystemUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public OperatingSystem OperatingSystem { get; set; }
        public OSType OsType { get; set; }
        public string Kernel { get; set; }
        public string GUI { get; set; }
        public string DefaultBrowser { get; set; }
        public string Flexibility { get; set; }
        public string Source { get; set; }
        public string Hardware { get; set; }
        public string Processor { get; set; }
    }
}