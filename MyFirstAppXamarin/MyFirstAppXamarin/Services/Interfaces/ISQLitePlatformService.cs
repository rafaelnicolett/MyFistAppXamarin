using SQLite.Net.Interop;

namespace MyFirstAppXamarin.Services
{
    public interface ISQLitePlatformService
    {
        ISQLitePlatform GetPlatform();
    }
}
