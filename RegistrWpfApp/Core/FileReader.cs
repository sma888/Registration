using RegistrWpfApp.Model;
using System.Collections.ObjectModel;
using System.IO;

namespace RegistrWpfApp.Core
{
    public class FileReader
    {
        public ObservableCollection<Teacher> Teacher()
        {
            var teacherList = new ObservableCollection<Teacher>();
            using (StreamReader teacherReader = new StreamReader(@"..\..\File\Teachers.txt"))
            {
                foreach (var item in teacherReader.ReadToEnd().Split('\n'))
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
        public ObservableCollection<Lesson> Lesson()
        {
            var lessonList = new ObservableCollection<Lesson>();
            using (StreamReader subjectReader = new StreamReader(@"..\..\File\Lesson.txt"))
            {
                foreach (var item in subjectReader.ReadToEnd().Split('\n'))
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
