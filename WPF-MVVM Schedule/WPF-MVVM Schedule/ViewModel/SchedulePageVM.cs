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

            FindeShedule(gridShedule);
        }

        public void FindeShedule(Grid gridShedule)
        {
            for (int i = 0; i < 10; i++)
            {
                gridShedule.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 10; i++)
            {
                gridShedule.ColumnDefinitions.Add(new ColumnDefinition());
            }
            // draw grid here

            for (int j = 0; j < gridShedule.ColumnDefinitions.Count - 1; j++)
            {
                var textBlock = new TextBlock();
                textBlock.VerticalAlignment = VerticalAlignment.Center;

                textBlock.HorizontalAlignment = HorizontalAlignment.Center;

                textBlock.FontSize = 20;

                gridShedule.Children.Add(textBlock);
                textBlock.Text = "Table"; // EmployeeCollection[j].FIO;
                //textBlock.Text = "Кресло  " + Convert.ToString(j + 1);
                //if (j >= 2)
                //{
                //    textBlock.Text = "Дополнительно ";
                //}
                Grid.SetColumn(textBlock, j + 1);
                Grid.SetRow(textBlock, 0);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var border = new Border();
                    border.BorderThickness = new Thickness(1, 1, 1, 1);
                    border.BorderBrush = Brushes.Black;


                    var control = new ControlSchedule(i);
                    control.Visibility = Visibility.Visible;
                    control.BorderThickness = new Thickness(1, 1, 1, 1);
                    control.BorderBrush = Brushes.Black;
                    control.ImageDelete.Visibility = Visibility.Hidden;
                    control.ImageEdit.Visibility = Visibility.Hidden;
                    if (j % 4 == 0)
                    {
                        control.Background = Brushes.RosyBrown;
                    }

                    gridShedule.Children.Add(border);
                    gridShedule.Children.Add(control);

                    Grid.SetColumn(border, i);
                    Grid.SetRow(border, j);

                    Grid.SetRow(control, j + 1);
                    Grid.SetColumn(control, i + 1);

                }
            }
        }

    }
}
