using System.ComponentModel.DataAnnotations;

namespace RajorTestDemo.Models
{
    public class Employ
    {
        [Key]
        public int Empno { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [RegularExpression("^(MALE|FEMALE)$", ErrorMessage = "Gender must be Male, Female, or Other")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [StringLength(30, ErrorMessage = "Department cannot exceed 30 characters")]
        public string? Dept { get; set; }

        [Required(ErrorMessage = "Designation is required")]
        [StringLength(30, ErrorMessage = "Designation cannot exceed 30 characters")]
        public string? Desig { get; set; }

        [Required(ErrorMessage = "Basic salary is required")]
        [Range(5000, 200000, ErrorMessage = "Basic salary must be between 5000 and 200000")]
        public decimal? Basic { get; set; }
    }


}
