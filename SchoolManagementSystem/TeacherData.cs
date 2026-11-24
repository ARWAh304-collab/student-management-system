
using System.Collections.Generic;

namespace SchoolManagementSystem
{
    public class TeacherInfo
    {
        public string Name { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Address { get; set; } = "";
        public string Department { get; set; } = "";
    }

    public static class TeacherData
    {
        public static List<TeacherInfo> Teachers =
            new List<TeacherInfo>();
    }
}
