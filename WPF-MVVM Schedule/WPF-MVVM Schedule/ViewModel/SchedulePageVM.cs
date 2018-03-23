using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPF_MVVM_Schedule.View;
using WPF_MVVM_Schedule.ViewModel.Base;

namespace WPF_MVVM_Schedule.ViewModel
{
    class SchedulePageVM : BaseVM
    {
        public static SchedulePageVM Instance;
        public static Grid GridInstance;
        private SchedulePage _ownershedulePage;
        private List<ControlSchedule> _controlShedules = new List<ControlSchedule>();

        public SchedulePageVM(SchedulePage ownePage)
        {
            Instance = this;
            _ownershedulePage = ownePage;

            var gridShedule = _ownershedulePage.gridShedule;
            GridInstance = gridShedule;
            gridShedule.Background = new SolidColorBrush();
            gridShedule.Height = 2000;
            gridShedule.MinWidth = 1100;
            gridShedule.MaxWidth = 1200;

            //FindeShedule(gridShedule);
        }

        public void FindeShedule(Grid gridShedule)
        {
            
            // draw grid here
        }

    }
}
