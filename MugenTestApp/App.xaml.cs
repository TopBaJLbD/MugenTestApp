using System.Windows;
using MugenMvvmToolkit;
using MugenMvvmToolkit.WPF.Infrastructure;
using System;
using MugenTestApp.ViewModels;
using MugenMvvmToolkit.Models.IoC;

namespace MugenTestApp
{
    public partial class App : Application
    {
        public App()
        {
            var diContainer = new NinjectContainer();
            diContainer.Bind<FirstChildWindowViewModel, FirstChildWindowViewModel>(DependencyLifecycle.TransientInstance);
            diContainer.Bind<SecondChildWindowViewModel, SecondChildWindowViewModel>(DependencyLifecycle.TransientInstance);

            new Bootstrapper<MugenApp>(this, diContainer);
        }

        public class MugenApp : MvvmApplication
        {
            public override Type GetStartViewModelType()
            {
                return typeof(MainViewModel);
            }
        }
    }
}