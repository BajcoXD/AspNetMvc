using System.ComponentModel.DataAnnotations;

namespace Avenga.Class07.ModelBinding.Models.ViewModels
{
    public class CreateStudentVM
    {
        [Display(Name ="Firstname")]
        public string FirstName { get; set; }


        [Display(Name = "Lastname")]
        public string LastName { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Additional Info")]
        public string AdditionalInfo { get; set; }


        [Display(Name = "Date Of Birht")]
        public DateTime DateOfBirth { get; set; }
        
    }
}
