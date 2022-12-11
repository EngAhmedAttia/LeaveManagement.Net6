using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name ="Leave Type Name")]
        [Required]

        public string Name { get; set; }

        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1,10 ,ErrorMessage ="Please Enter Number Between 1-10 ")]

        public int DefaultDays { get; set; }
    }
}
