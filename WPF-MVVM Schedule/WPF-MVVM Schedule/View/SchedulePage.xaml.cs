using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_MVVM_Schedule.ViewModel;

namespace WPF_MVVM_Schedule.View
{
    /// <summary>
    /// Interaction logic for SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        public static SchedulePage Instance;
        private SchedulePageVM schedulePageVM;
        public SchedulePage()
        {
            InitializeComponent();

            schedulePageVM = new SchedulePageVM(this);
            DataContext = schedulePageVM;
            Instance = this;
        }
    }
}
