using RegistrWpfApp.Model;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;

namespace RegistrWpfApp.Core
{
    public class FileReader
    {
        public async Task<ObservableCollection<Teacher>> Teacher()
        {
            var teacherList = new ObservableCollection<Teacher>();
            using (StreamReader teacherReader = new StreamReader(@"..\..\File\Teachers.txt"))
            {
                var teacherSplit = await teacherReader.ReadToEndAsync();
                foreach (var item in teacherSplit.Split('\n'))
                {
                    var arrayString = item.Split(',');
                    if (arrayString[0] != "ID")
                    {
                        var teacher = new Teacher()
                        {
                            ID = int.Parse(arrayString[0]),
                            FirstName = arrayString[1],
                            LastName = arrayString[2],
                            Login = arrayString[3],
                            Password = arrayString[4]
                        };
                        teacherList.Add(teacher);
                    }
                }
                return teacherList;
            }
        }
        public async Task<ObservableCollection<Lesson>> Lesson()
        {
            var lessonList = new ObservableCollection<Lesson>();
            using (StreamReader lessonReader = new StreamReader(@"..\..\File\Lesson.txt"))
            {
                var lessonSplit = await lessonReader.ReadToEndAsync();
                foreach (var item in lessonSplit.Split('\n'))
                {
                    var arrayString = item.Split('?');
                    if (arrayString[0] != "ID")
                    {
                        var subject = new Lesson()
                        {
                            Id = int.Parse(arrayString[0]),
                            Name = arrayString[1]
                        };
                        lessonList.Add(subject);
                    }
                }
                return lessonList;
            }
        }
    }
}
