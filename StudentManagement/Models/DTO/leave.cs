using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.DTO
{
    public class leave
    {
        [Key]
        public string lid { get; set; }
        [Required]
        public string StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int NoOfDays { get; set; }
        [Required]
        public string Reason { get; set; }
    }
}
