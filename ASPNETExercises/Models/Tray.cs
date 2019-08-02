using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ASPNetExercises.Models
{
    public class Tray
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public int TotalCalories { get; set; }
        [Required]
        public int TotalCholesterol { get; set; }
        [Required]
        [Column(TypeName = "decimal(9, 2)")]
        public decimal TotalFat { get; set; }
        [Required]
        public int TotalFibre { get; set; }
        [Required]
        public int TotalProtein { get; set; }
        [Required]
        public int TotalSalt { get; set; }
    }
}