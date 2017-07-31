using MugenMvvmToolkit;
using MugenMvvmToolkit.Interfaces.Presenters;
using MugenMvvmToolkit.Interfaces.ViewModels;
using MugenMvvmToolkit.Models;
using MugenMvvmToolkit.ViewModels;
using MugenMvvmToolkit.DataConstants;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MugenTestApp.ViewModels
{
    public class MainViewModel : CloseableViewModel
    {
        private IMessagePresenter mMessagePresenter;

        public ICommand OpenFirstChildCommand { get; private set; }
        public ICommand OpenSecondChildCommand { get; private set; }

        public MainViewModel(IMessagePresenter messagePresenter)
        {
            mMessagePresenter = messagePresenter;

            OpenFirstChildCommand = RelayCommandBase.FromAsyncHandler(ShowFirst);
            OpenSecondChildCommand = RelayCommandBase.FromAsyncHandler(ShowSecond);
        }

        private async Task ShowFirst()
        {
            using (var vm = GetViewModel<FirstChildWindowViewModel>())
            {
                var v = await vm.ShowAsync();
            }
        }

        private async Task ShowSecond()
        {
            using (var vm = GetViewModel<SecondChildWindowViewModel>())
            {
                if (await vm.ShowAsync())
                {

                }
            }
        }
    }
}
