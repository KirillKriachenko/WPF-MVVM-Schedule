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

namespace WPF_MVVM_Schedule
{
    /// <summary>
    /// Interaction logic for ControlSchedule.xaml
    /// </summary>
    public partial class ControlSchedule : UserControl
    {
        //public SheduleControlVM SheduleControl;
        //private Add_ScheduleVM add_ScheduleVM;

        public ControlSchedule(int columnNumber)
        {
            InitializeComponent();
        }
    }
}
