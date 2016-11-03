using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;

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

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            return base.CreatePresenter();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}