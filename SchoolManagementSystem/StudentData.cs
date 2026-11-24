
using System.Collections.Generic;

namespace SchoolManagementSystem
{
    public class StudentInfo
    {
        public string ID { get; set; } = "";
        public string Name { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string Birth { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Class { get; set; } = "";
    }

    public static class StudentData
    {
        public static List<StudentInfo> Students = new List<StudentInfo>();
    }
}
