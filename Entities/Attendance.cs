﻿namespace SchoolManagementApplication.Entities
{
    public class Attendance : BaseEntity
    {
        public int StudentId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsPresent { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
