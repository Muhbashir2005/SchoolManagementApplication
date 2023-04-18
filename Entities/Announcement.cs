﻿namespace SchoolManagementApplication.Entities
{
    public class Announcement : BaseEntity
    {
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
