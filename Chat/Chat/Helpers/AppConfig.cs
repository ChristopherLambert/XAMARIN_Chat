using PCLAppConfig;

namespace Chat.Helpers
{
    public static class AppConfig
    {
        public static string urlBase = ConfigurationManager.AppSettings["api.url"];
    }
}