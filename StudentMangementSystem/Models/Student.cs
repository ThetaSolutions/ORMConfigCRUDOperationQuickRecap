using System;
using System.Collections.Generic;

namespace StudentMangementSystem.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string RollNumber { get; set; }
    }
}
