using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Schedule.View;
using WPF_MVVM_Schedule.ViewModel.Base;

namespace WPF_MVVM_Schedule.ViewModel
{
    class MainWindowVM : BaseVM
    {
        private MainWindow _ownerWindow;
        public MainWindowVM(MainWindow ownerWindow)
        {
            _ownerWindow = ownerWindow;
            _ownerWindow.FrameMain.NavigationService.Navigate(new SchedulePage());
        }
    }
}
