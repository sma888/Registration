using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrWpfApp.Model
{
    public class Time
    {
        public string TimeShow { get; set; }

        public Time(string FirstName, string _Subject)
        {
            TimeShow = FirstName + " : " + _Subject;
        }
    }
}
