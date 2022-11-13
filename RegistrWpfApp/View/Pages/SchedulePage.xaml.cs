using RegistrWpfApp.Core;
using RegistrWpfApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace RegistrWpfApp
{
    /// <summary>
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        public SchedulePage()
        {
            InitializeComponent();
            FileReader fileReader = new FileReader();
            fileReader.Teacher();
            TeacherBox.ItemsSource = fileReader.Teacher();
            TeacherBox.DisplayMemberPath = "TeacherName";
            fileReader.Lesson();
            LessonBox.ItemsSource = fileReader.Lesson();
            LessonBox.DisplayMemberPath = "Name";
            times = new ObservableCollection<Time>();
        }

        Time time;
        public ObservableCollection<Time> times;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TeacherBox.Text == null || LessonBox.Text == null)
            {
                MessageBox.Show("Выберите учителя и предмет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                time = new Time(TeacherBox.Text, LessonBox.Text);
                times.Add(time);
                TeacherListView.ItemsSource = times;
                TeacherListView.DisplayMemberPath = "TimeShow";
            }
        }
    }
}
