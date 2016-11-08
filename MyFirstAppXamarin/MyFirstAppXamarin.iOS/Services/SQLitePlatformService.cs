using MyFirstAppXamarin.Services;
using SQLite.Net.Interop;

namespace MyFirstAppXamarin.iOS.Services
{
    public class SQLitePlatformService : ISQLitePlatformService
    {
        public SQLitePlatformService() { }

        public ISQLitePlatform GetPlatform()
        {
            return new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
        }
    }
}
