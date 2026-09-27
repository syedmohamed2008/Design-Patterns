namespace Singleton_Shared_Configuration
{
    public class ApplicationSettings
    {
        public string ApplicationName { get; set; } = string.Empty;

        public string SupportEmail { get; set; } = string.Empty;

        public int MaxUploadSizeMB { get; set; }

        public bool MaintenanceMode { get; set; }
    }
}
