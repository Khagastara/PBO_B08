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
        public static string LoggedInUsername { get; set; }
        public static string LoggedInPassword { get; set; }
    }
}
