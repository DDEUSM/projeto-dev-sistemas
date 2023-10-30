using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace devsistemas.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }  
        public string? Ra { get; set; }
        public int Note { get; set; }
    }
}
