using System;

namespace luis_beuth.Models.Data
{
    public class Rent 
    {
        public int Id { get; set; }
        public int ExamId { get; set;}
        public Exam Exam { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }

    }
}