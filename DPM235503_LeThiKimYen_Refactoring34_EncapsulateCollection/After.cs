using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring34_EncapsulateCollection
{
    public class CourseAfter
    {
        private readonly List<string> _students = new List<string>();

        // Chỉ công khai danh sách dạng ReadOnly để bảo vệ tập hợp
        public IReadOnlyCollection<string> Students => _students.AsReadOnly();

        public void AddStudent(string student) => _students.Add(student);
        public void RemoveStudent(string student) => _students.Remove(student);
    }
}