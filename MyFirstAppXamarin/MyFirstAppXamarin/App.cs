using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MyFirstAppXamarin.Services;
using MyFirstAppXamarin.ViewModels;

namespace MyFirstAppXamarin
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
               .InNamespace("MyFirstAppXamarin.Services")
               .AsInterfaces()
               .RegisterAsLazySingleton();

            Mvx.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);

			var bookRepository = Mvx.Resolve<IBookRepository>();

			bookRepository.CreateDatabase();

            RegisterAppStart<HomeViewModel>();
        }
    }
}

