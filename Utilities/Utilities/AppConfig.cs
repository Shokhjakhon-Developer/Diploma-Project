namespace Utilities.Utilities;

public class AppConfig
{
    public Driver Driver { get; set; }
}

public class Driver
{
    public string Browser { get; set; }
    public string Link { get; set; }
    public BOptions ChromeOptions { get; set; }


    public class BOptions
    {
        public string Disable_extensions { get; set; }
        public string No_sandbox { get; set; }
        public string Disable_dev_shm_usage { get; set; }
        public string Headless { get; set; }
        public string Window_size { get; set; }
    }
}