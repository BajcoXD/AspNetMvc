using System.ComponentModel.DataAnnotations;

namespace Avenga.Class07.ModelBinding.Models.Dtos
{
    public class StudentDto
    {
        
        public int Id { get; set; }



        [Display(Name = "Student's full name")]
       // [Display(Name = "Име на студент")]
        public string FullName { get; set; }

        [Display(Name = "Student's age")]
        //[Display(Name = "Години на студент")]
        public int Age { get; set; }

    }
}
