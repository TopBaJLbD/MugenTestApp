using MugenMvvmToolkit.Interfaces.ViewModels;
using MugenMvvmToolkit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugenTestApp.ViewModels
{
    public class SecondChildWindowViewModel : ViewModelBase, IHasResultViewModel<bool>
    {
        public bool Result { get { return true; } }
    }
}
