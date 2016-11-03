using MvvmCross.Core.ViewModels;
using MyFirstAppXamarin.ViewModels;

namespace MyFirstAppXamarin
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewModel>();
        }
    }
}

