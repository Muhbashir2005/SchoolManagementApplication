using SchoolManagementApplication.Entities;
using SchoolManagementApplication.Repository.Interfaces;

namespace SchoolManagementApplication.Services.Implementations
{
    public class AttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;
        private readonly IStudentRepository _studentRepository;
       /* public async Task MarkAttendanceAsync(int studentId, DateTime date, bool isPresent)
        {
            var student = await _studentRepository.GetByIdAsync(studentId);

            if (student == null)
            {
                throw new ArgumentException($"Student with ID {studentId} does not exist.");
            }

            var attendanceRecord = new Attendance
            {
                StudentId = studentId,
                Date = date,
                IsPresent = isPresent
            };

            await _attendanceRepository.AddAsync(attendanceRecord);
        }*/
    }
}
