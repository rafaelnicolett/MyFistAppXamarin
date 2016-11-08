using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using System;
using UIKit;

namespace MyFirstAppXamarin.iOS
{

    public class StoryboardContainer : MvxIosViewsContainer
    {
        protected override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            return (IMvxIosView)UIStoryboard.FromName("Main", null).InstantiateViewController(viewType.Name);
        }
    }
}
