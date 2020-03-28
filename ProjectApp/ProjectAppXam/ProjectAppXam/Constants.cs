using Xamarin.Forms;

namespace ProjectAppXam
{
    public static class Constants
    {
        public static string HostName { get; set; } = "https://kotoba.azurewebsites.net/";
        // Local
        //public static string HostName { get; set; } = "https://localhost:8000/";

        public static string MessageName { get; set; } = "newMessage";

        public static string Username =>  $"{Device.RuntimePlatform} User";
    }
}
