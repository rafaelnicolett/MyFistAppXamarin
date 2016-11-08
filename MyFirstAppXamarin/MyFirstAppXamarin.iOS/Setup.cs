using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using MyFirstAppXamarin.iOS.Services;
using MyFirstAppXamarin.Services;

namespace MyFirstAppXamarin.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter window)
            : base(applicationDelegate, window)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxIosViewsContainer CreateIosViewsContainer()
        {
            return new StoryboardContainer();
        }

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            return base.CreatePresenter();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeFirstChance()
        {
            Mvx.RegisterSingleton<ISQLitePlatformService>(new SQLitePlatformService());
            base.InitializeFirstChance();
        }
    }
}