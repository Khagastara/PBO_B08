using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Core
{
    public static class UserSession
    {
        public static int LoggedInDoctorId { get; set; }
        public static string LoggedInDoctor { get; set; }
        public static string LoggedInSpecialize { get; set; }
        public static string LoggedInGender { get; set; }
        public static string LoggedInEmail { get; set; }
        public static string LoggedInPhone { get; set; }
        public static string LoggedInUsername { get; set; }
        public static string LoggedInPassword { get; set; }
    }
}
