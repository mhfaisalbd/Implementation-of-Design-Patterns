﻿namespace DesignPattern.Factory
{
    public class OperatingSystemUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public OperatingSystem OperatingSystem { get; set; }
        public string Kernel { get; set; }
        public string GUI { get; set; }
        public string DefaultBrowser { get; set; }
    }
}