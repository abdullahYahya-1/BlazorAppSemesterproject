using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppProject.Data
{
    public enum Gender
    {
        [Display(Name = "Male")]
        Male = 1,

        [Display(Name = "Female")]
        Female = 2,
    }

    public class AddmissionStudents
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name must not exceed 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name must not exceed 50 characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Father Name is required.")]
        [StringLength(50, ErrorMessage = "Father Name must not exceed 50 characters.")]
        public string FatherName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Guardian Name is required.")]
        [StringLength(50, ErrorMessage = "Guardian Name must not exceed 50 characters.")]
        public string GardianName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Birth Date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format.")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(50, ErrorMessage = "City must not exceed 50 characters.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Region is required.")]
        [StringLength(50, ErrorMessage = "Region must not exceed 50 characters.")]
        public string Region { get; set; } = string.Empty;

        [Required(ErrorMessage = "Street Address is required.")]
        [StringLength(100, ErrorMessage = "Street Address must not exceed 100 characters.")]
        public string StreetAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Class is required.")]
        [StringLength(20, ErrorMessage = "Class must not exceed 20 characters.")]
        public string Class { get; set; } = string.Empty;

        [Required(ErrorMessage = "Gender is required.")]
        public Gender Gender { get; set; } // Use an enum for gender
    }
}
